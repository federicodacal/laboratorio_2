using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero)
            :base(precio, titulo, autor)
        {
            this.genero = genero;
        }

        public static implicit operator Single(Novela n)
        {
            return n.precio;
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = (Libro)a == (Libro)b && a.genero == b.genero;
            }
            return rta;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            Novela otraNovela = obj as Novela;
            return otraNovela is not null && this == otraNovela;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((string)this);
            sb.AppendLine($"GENERO: {this.genero}");

            return sb.ToString();
        }

    }
}
