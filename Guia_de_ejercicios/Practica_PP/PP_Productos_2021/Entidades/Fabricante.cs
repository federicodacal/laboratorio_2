using System;

namespace Entidades
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        public static implicit operator String(Fabricante f)
        {
            return $"{f.marca} - {f.pais}";
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = a.marca == b.marca && a.pais == b.pais;
            }
            return rta;
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

    }
}
