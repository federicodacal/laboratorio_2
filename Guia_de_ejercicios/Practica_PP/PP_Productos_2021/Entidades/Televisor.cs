using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Televisor : Producto
    {
        public ETipo tipo;

        public Televisor(string modelo, string marca, EPais pais, ETipo tipo)
            :base(modelo, new Fabricante(marca, pais))
        {
            this.tipo = tipo;
        }

        public static explicit operator Double(Televisor tv)
        {
            return tv.Precio;
        }

        public static bool operator ==(Televisor a, Televisor b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = (Producto)a == (Producto)b && a.tipo == b.tipo;
            }
            return rta;
        }

        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Televisor otraTv = obj as Televisor;
            return otraTv is not null && this == otraTv;
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
