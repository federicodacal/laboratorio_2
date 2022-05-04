using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas;

namespace Entidades
{
    namespace Establecimiento
    {
        public class Bar
        {
            private List<Botella> botellas;
            private int capacidadMaximaBotellas;
            private string nombre;
            private double recaudacion;

            public Bar()
            {
                this.capacidadMaximaBotellas = 5;
                this.nombre = "Sin nombre";
                this.botellas = new List<Botella>();
            }

            public Bar(int capacidad):this(capacidad, "Sin nombre")
            {

            }

            public Bar(int capacidad, string nombre):this()
            {
                this.capacidadMaximaBotellas = capacidad;
                this.nombre = nombre;
            }

            public List<Botella> Botellas
            {
                get { return this.botellas; }
            }

            public string MostrarBar
            {
                get { return this.Mostrar(); }
            }

            private string Mostrar()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{this.GetType().Name}: {this.nombre}");
                sb.AppendLine($"Capacidad: {this.capacidadMaximaBotellas} ({this.Botellas.Count})");
                sb.AppendLine($"Recaudacion: {this.recaudacion}");
                foreach (Botella item in this.Botellas)
                {
                    sb.AppendLine(item.ToString());
                    sb.AppendLine("-----------------------------------------------");
                }
                return sb.ToString();
            }

            private int OrdenarPorContenido(Botella a, Botella b)
            {
                return (int)b.PorcentajeContenido - (int)a.PorcentajeContenido;
            }

            private int OrdenarPorGanancia(Botella a, Botella b)
            {
                return (int)a.Ganancia - (int)b.Ganancia;
            }

            private int OrdenarPorMarca(Botella a, Botella b)
            {
                return String.Compare((string)a, (string)b);
            }

            public void OrdenarBotellas(Ordenamiento o)
            {
                if(o == Ordenamiento.Marca)
                {
                    this.Botellas.Sort(OrdenarPorMarca);
                }
                else if (o == Ordenamiento.Ganancia)
                {
                    this.Botellas.Sort(OrdenarPorGanancia);
                }
                else if (o == Ordenamiento.PorcentajeContenido)
                {
                    this.Botellas.Sort(OrdenarPorContenido);
                }
            }

            public static explicit operator Double(Bar b)
            {
                return b.recaudacion;
            }

            public static bool operator ==(Bar a, Botella b)
            {
                bool rta = false;
                if(a is not null && b is not null)
                {
                    foreach (Botella item in a.Botellas)
                    {
                        if (item.Equals(b))
                        {
                            rta = true;
                            break;
                        }
                    }
                }
                return rta;
            }

            public static bool operator !=(Bar a, Botella b)
            {
                return !(a == b);
            }

            public static Bar operator +(Bar a, Botella b)
            {
                if(a != b && a.capacidadMaximaBotellas > a.Botellas.Count)
                {
                    a.Botellas.Add(b);
                }
                return a;
            }

            public static Bar operator +(Bar a, double g)
            {
                if(a is not null)
                {
                    a.recaudacion += g;
                }
                return a;
            }

            public static Bar operator -(Bar a, Botella b)
            {
                if(a == b)
                {
                    b--;
                    a.recaudacion += b.Ganancia;
                    if(b.PorcentajeContenido == 0)
                    {
                        a.Botellas.Remove(b);
                    }
                }
                return a;
            }
        }

    }
}
