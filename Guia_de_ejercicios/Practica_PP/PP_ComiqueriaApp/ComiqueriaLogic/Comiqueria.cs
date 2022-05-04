using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public Producto this[Guid codigo]
        {
            get
            {
                Producto p = null;
                foreach (Producto item in this.productos)
                {
                    if((Guid)item == codigo)
                    {
                        p = item;
                    }
                }
                return p;
            }
        }

        public static bool operator ==(Comiqueria c, Producto p)
        {
            bool rta = false;
            if(c is not null && p is not null)
            {
                foreach (Producto item in c.productos)
                {
                    if(item.Descripcion == p.Descripcion)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Comiqueria c, Producto p)
        {
            return !(c == p);
        }

        public static Comiqueria operator +(Comiqueria c, Producto p)
        {
            if(c != p)
            {
                c.productos.Add(p);
            }
            return c;
        }

        public void Vender(Producto p)
        {
            this.Vender(p, 1);
        }

        public void Vender(Producto p, int cantidad)
        {
            this.ventas.Add(new Venta(p, cantidad));
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Listado de Ventas:");

            this.ventas.Sort(OrdenarVentasPorFecha);

            foreach (Venta item in this.ventas)
            {
                sb.AppendLine(item.ObtenerDescripcionBreve());
                sb.AppendLine("--------------------------------");
            }
            return sb.ToString();
        }

        public static int OrdenarVentasPorFecha(Venta v1, Venta v2)
        {
            return DateTime.Compare(v1.Fecha, v2.Fecha);
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();

            foreach (Producto item in this.productos)
            {
                diccionario.Add((Guid)item, item.Descripcion);
            }

            return diccionario;
        }
    }
}
