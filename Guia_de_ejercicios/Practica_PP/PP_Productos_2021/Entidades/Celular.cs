using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular : Producto
    {
        public EGama gama;

        public Celular(string modelo, Fabricante fabricante, EGama gama)
            :base(modelo, fabricante)
        {
            this.gama = gama;
        }

        public static implicit operator Double(Celular celu)
        {
            return celu.Precio;
        }

        public static bool operator ==(Celular a, Celular b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = (Producto)a == (Producto)b && a.gama == b.gama;
            }
            return rta;
        }

        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Celular otroCelu = obj as Celular;
            return otroCelu is not null && this == otroCelu;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"GAMA: {this.gama}");

            return sb.ToString();
        }
    }
}
