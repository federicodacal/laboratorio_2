using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Reloj
    {
        public delegate void NotificadorCambioTiempo(Reloj reloj);

        public event NotificadorCambioTiempo SegundoCambiado;

        private int segundo;
        private int minuto;
        private int hora;

        public void Iniciar()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;
                    Thread.Sleep(100);

                    if (dt.Second != this.segundo)
                    {
                        if(this.SegundoCambiado is not null)
                        {
                            this.SegundoCambiado.Invoke(this); // Le paso la instancia de reloj
                        }
                    }

                    this.segundo = dt.Second;
                    this.minuto = dt.Minute;
                    this.hora = dt.Hour;
                }
            });        
        }

        public override string ToString()
        {
            return $"{this.hora}:{this.minuto.ToString("D2")}:{this.segundo.ToString("D2")}";
        }
    }
}
