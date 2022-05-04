using System;
using System.Text;

namespace Entidades
{
    namespace Botellas
    {
        public abstract class Botella
        {
            protected int capacidad;
            protected int contenido;
            protected string marca;
            protected double precio;

            public Botella(string marca, double precio)
                :this(marca, precio, 1000)
            {

            }

            public Botella(string marca, double precio, int capacidad)
            {
                this.marca = marca;
                this.precio = precio;
                this.capacidad = capacidad;
                this.contenido = capacidad;
            }

            public abstract double Ganancia { get; }

            public double PorcentajeContenido
            {
                get { return (this.contenido * 100) / this.capacidad; }
            }

            protected abstract void ServirMedida();

            private static string ObtenerDatos(Botella b)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"MARCA: {b.marca}");
                sb.AppendLine($"PRECIO: $ {b.precio}");
                sb.AppendLine($"CAPACIDAD: {b.capacidad}");
                sb.AppendLine($"CONTENIDO: {b.contenido}");
                sb.AppendLine($"% CONTENIDO: %{b.PorcentajeContenido}");

                return sb.ToString();
            }

            public override string ToString()
            {
                return Botella.ObtenerDatos(this);
            }

            public static bool operator ==(Botella a, Botella b)
            {
                bool rta = false;
                if(a is not null && b is not null)
                {
                    rta = a.marca == b.marca && a.capacidad == b.capacidad;
                }
                return rta;
            }

            public static bool operator !=(Botella a, Botella b)
            {
                return !(a == b);
            }

            public static explicit operator String(Botella a)
            {
                return a.marca;
            }

            public static Botella operator --(Botella botella)
            {
                botella.ServirMedida();
                return botella;
            }
        }
    }

}

