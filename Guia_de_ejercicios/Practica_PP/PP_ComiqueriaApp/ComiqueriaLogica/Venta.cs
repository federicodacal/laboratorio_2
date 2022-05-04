using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            return precioSinIva + (precioSinIva * (Venta.porcentajeIva / 100));
        }

        public string ObtenerDescripcionBreve()
        {
            return $"{this.Fecha.ToLongTimeString()} - {this.producto.Descripcion} - {String.Format("{0:0.00}",this.precioFinal)}";
        }
    }
}
