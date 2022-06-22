using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Files;

namespace CoreLibraries
{
    public delegate void FinalizaRegistro();

    public enum EVoto { Indefinido, Abstencion, Afirmativo, Negativo }

    public class Parlamento<T>
        where T : IParlamentario
    {
        public delegate void InformaCambioEstado(T banca);

        private List<T> bancas;
        private bool estadoSesion;
        private T presidente;

        public event FinalizaRegistro FinVotacion;
        public event InformaCambioEstado OcupaBanca;
        public event FinalizaRegistro ParlamentariosRegistrados;
        public event InformaCambioEstado VotoEmitido;

        public Parlamento(T presidente)
        {
            this.presidente = presidente;
            this.bancas = new List<T>();
        }

        public List<T> Bancas { get => bancas; set => bancas = value; }
        public bool EstadoSesion 
        { 
            set
            {
                this.estadoSesion = value;
                Task.Run(() =>
                {
                    foreach (T item in this.bancas)
                    {
                        item.AperturaSesion = estadoSesion;
                        if(this.OcupaBanca is not null)
                        {
                            this.OcupaBanca(item);
                            Thread.Sleep(10); 
                        }
                        if(this.ParlamentariosRegistrados is not null)
                        {
                            this.ParlamentariosRegistrados.Invoke();
                        }
                    }
                });
            } 
        }
        public T Presidente { get => presidente; }

        public int VotosAbstenciones { get => ContarVotos(EVoto.Abstencion); }
        public int VotosAfirmativos { get => ContarVotos(EVoto.Afirmativo); }
        public int VotosNegativos { get => ContarVotos(EVoto.Negativo); }

        public void CancelarVotacion()
        {

        }


        private int ContarVotos(EVoto voto)
        {
            int cantidad = 0;
            foreach (T item in this.bancas)
            {
                if(item.Voto == voto)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public void DesempatePresidente()
        {
            if(this.VotosAfirmativos == this.VotosNegativos)
            {
                this.presidente.EmitirVoto();
                if(this.VotoEmitido is not null)
                {
                    this.VotoEmitido.Invoke(this.presidente);
                }
            }
            else
            {
                
            }
        }

        public void IniciarVotacion()
        {
            Task.Run(() =>
            {
                foreach (T item in this.bancas)
                {
                    if (item.Presentismo)
                    {
                        item.EmitirVoto();
                        if(this.VotoEmitido is not null)
                        {
                            this.VotoEmitido.Invoke(item);
                            Thread.Sleep(new Random().Next(100, 500));
                        }
                    }
                }
                try
                {
                    this.DesempatePresidente();
                    if (this.FinVotacion is not null)
                    {
                        this.FinVotacion.Invoke();
                        JsonManager<Parlamento<T>>.Guardar(this);
                    }
                }
                catch (Exception)
                {
                    //throw new NoNecesitaDesempateException();
                }
            });
        }


    }
}
