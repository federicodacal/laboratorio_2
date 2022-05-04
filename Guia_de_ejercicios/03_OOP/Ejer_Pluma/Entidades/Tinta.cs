using System;

namespace Entidades
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta(ConsoleColor color, ETipoTinta tipo)
        {
            this.color = color;
            this.tipo = tipo;
        }

        public Tinta(ConsoleColor color):this(color, ETipoTinta.Comun)
        {

        }

        public Tinta(ETipoTinta tipo):this(ConsoleColor.Black, tipo)
        {

        }

        public Tinta():this(ConsoleColor.Black, ETipoTinta.Comun)
        {

        }

        public string Mostrar()
        {
            return $"Tinta {this.color} tipo {this.tipo}";
        }

        public static string Mostrar(Tinta t)
        {
            return t.Mostrar();
        }

        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool rta = false;
            if(t1 is not null && t2 is not null)
            {
                rta = t1.tipo == t2.tipo && t1.color == t2.color;
            }
            return rta;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator string(Tinta t)
        {
            return t.Mostrar();
        }
    }
}
