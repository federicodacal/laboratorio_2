using System;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public static implicit operator string(Autor a)
        {
            return $"{a.nombre} {a.apellido}";
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = a.apellido == b.apellido && a.nombre == b.nombre;
            }
            return rta;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

    }
}
