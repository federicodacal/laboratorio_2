using System;
using System.Text;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected Publicacion(string nombre):this(nombre, 0)
        {

        }

        protected Publicacion(string nombre, int stock):this(nombre, stock, 0)
        {

        }

        protected Publicacion(string nombre, int stock, float importe)
        {
            this.importe = importe;
            this.nombre = nombre;
            this.Stock = stock;
        }

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                return this.stock > 0 && this.importe > 0;
            }
        }

        public float Importe
        {
            get { return this.importe; }
        }

        public int Stock
        {
            get { return this.stock; }
            set
            {
                if(value > 0)
                {
                    this.stock = value;
                }
            }
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre); ;
            sb.Append("Stock: ");
            sb.AppendLine(this.Stock.ToString()); 
            sb.Append("Es color: ");
            if (this.EsColor)
            {
                sb.AppendLine("SI"); 
            }
            else
            {
                sb.AppendLine("NO");
            }
            sb.Append("Valor: ");
            sb.AppendLine($"$ {this.Importe}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
