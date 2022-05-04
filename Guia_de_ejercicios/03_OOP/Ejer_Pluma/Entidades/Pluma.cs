using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this.marca = marca;
            this.tinta = tinta;
            this.cantidad = cantidad;
        }

        public Pluma(string marca, int cantidad):this(marca, null, cantidad)
        {

        }

        public Pluma(Tinta tinta):this("Sin marca", tinta, 1)
        {

        }

        public Pluma():this("Sin marca", null, 1)
        {

        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pluma:");
            sb.AppendLine($"Marca: {this.marca}");
            sb.Append("Tinta: ");
            if(this.tinta is not null)
            {
                sb.AppendLine(this.tinta.Mostrar());
            }
            else
            {
                sb.AppendLine("No tiene tinta cargada");
            }
            sb.AppendLine($"Cantidad: {this.cantidad}");
            return sb.ToString();
        }

        public static implicit operator string (Pluma p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Pluma p, Tinta t)
        {
            bool rta = false;
            if(p is not null && t is not null)
            {
                rta = p.tinta == t;
            }

            return rta;
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p == t);
        }

        public static bool operator +(Pluma p, Tinta t)
        {
            bool rta = false;
            if(p == t)
            {
                p.cantidad++;
                rta = true;
            }
            return rta;
        }

        public static bool operator -(Pluma p, Tinta t)
        {
            bool rta = false;
            if(p == t)
            {
                if(p.cantidad > 0)
                {
                    p.cantidad--;
                    rta = true;
                }
            }
            return rta;
        }

    }
}
