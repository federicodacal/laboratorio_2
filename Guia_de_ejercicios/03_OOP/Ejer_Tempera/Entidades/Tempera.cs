using System;

namespace Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return $"Color: {this.color} | Marca: {this.marca} | Cantidad {this.cantidad}";
        }

        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool rta = false;
            if(t1 is not null && t2 is not null)
            {
                rta = t1.color == t2.color && t1.marca == t2.marca;
            }
            return rta;
        }
        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera t)
        {
            return t.cantidad;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if(t1 == t2)
            {
                t1.cantidad += t2.cantidad;
                // auxTemp = new Tempera(t1.color, t1.marca, t1.cantidad + t2.cantidad);
            }
            return t1;
        }

        public static Tempera operator +(Tempera t, int cantidad)
        {
            if(t is not null)
            {
                t.cantidad += cantidad;
            }
            return t;
        }
    }
}
