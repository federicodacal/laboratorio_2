using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformarReparacion(Barco barco);

    public class Taller
    {
        private List<Barco> barcos;

        public event InformarReparacion ReparacionTerminada;

        public Taller()
        {
            this.barcos = new List<Barco>();
        }

        public List<Barco> Barcos { get => barcos; }

        public void Reparar(object taller, CancellationToken ct)
        {
            if (ct.IsCancellationRequested)
            {
                throw new TaskCanceledException("Reparaciones canceladas");
            }
            else
            {
                if (taller != null && taller.GetType() == typeof(Taller))
                {
                    foreach (Barco item in ((Taller)taller).Barcos)
                    {
                        if (!item.EstadoReparado)
                        {
                            item.CalcularCosto();

                            Thread.Sleep(3000);

                            item.EstadoReparado = true;

                            AccesoDatos.Guardar($"Se reparo el {item.Nombre} a un costo de {(string)item} berries");

                            if(this.ReparacionTerminada != null)
                            {
                                this.ReparacionTerminada.Invoke(item);
                            }
                        }
                    }
                }
            }
                      
        }

        public static bool operator ==(Taller c, Barco b)
        {
            bool rta = false;
            if(!(c is null && b is null))
            {
                foreach (Barco item in c.Barcos)
                {
                    if(item == b)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Taller c, Barco b)
        {
            return !(c == b);
        }

        public static Taller operator +(Taller c, Barco b)
        {
            if(c != b)
            {
                c.Barcos.Add(b);
            }
            else
            {
                throw new BarcoRepetidoException($"Barco repetido: el barco {b.Nombre} ya se encuentra cargado en la lista del Taller");
            }
            return c;
        }
    }
}
