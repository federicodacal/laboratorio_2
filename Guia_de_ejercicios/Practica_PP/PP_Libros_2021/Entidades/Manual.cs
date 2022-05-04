using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo)
            :base(precio, titulo, new Autor(nombre, apellido))
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = (Libro)a == (Libro)b && a.tipo == b.tipo;
            }
            return rta;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }

        public override bool Equals(object obj)
        {
            Manual otroManual = obj as Manual;
            return otroManual is not null && this == otroManual;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((string)this);
            sb.AppendLine($"TIPO: {this.tipo}");

            return sb.ToString();
        }

    }
}
