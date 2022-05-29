using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static string ObtenerInformeVentas(Vendedor v)
        {
            StringBuilder sb = new StringBuilder();
            float ganancia = 0; 

            sb.AppendLine(v.nombre);
            sb.AppendLine("--------------------------------------");
            foreach (Publicacion item in v.ventas)
            {
                sb.AppendLine(item.ObtenerInformacion());
                ganancia += item.Importe;
            }

            sb.AppendLine($"Ganancia Total: ${ganancia}");

            return sb.ToString();
        }

        public static bool operator +(Vendedor v, Publicacion p)
        {
            bool rta = false;
            if(v is not null && p is not null)
            {
                if (p.HayStock)
                {
                    v.ventas.Add(p);
                    p.Stock--;
                    rta = true;
                }
            }
            return rta;
        }
    }
}
