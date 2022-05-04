using System;
using System.Text;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }

        public int Stock
        {
            get { return this.stock; }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Descripcion: {this.Descripcion}");
            sb.AppendLine($"Codigo: {(Guid)this}");
            sb.AppendLine($"Precio: {this.Precio}");
            sb.AppendLine($"Stock: {this.Stock} unidades");

            return sb.ToString();
        }

    }
}
