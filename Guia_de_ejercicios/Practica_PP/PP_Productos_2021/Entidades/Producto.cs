using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected double precio;

        static Producto()
        {
            generadorDePrecios = new Random();
        }

        public Producto(string modelo, Fabricante fabricante)
        {
            this.fabricante = fabricante;
            this.modelo = modelo;
        }

        public Producto(string modelo, string marca, EPais pais)
            :this(modelo, new Fabricante(marca, pais))
        {

        }
        
        public double Precio
        {
            get 
            {
                if(this.precio == 0)
                {
                    this.precio = generadorDePrecios.Next(10500, 125000);
                }
                return this.precio;
            }
        }

        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"FABRICANTE: ");
            sb.AppendLine(p.fabricante);
            sb.AppendLine($"MODELO: {p.modelo}");
            sb.AppendLine($"PRECIO: {p.Precio}");

            return sb.ToString();
        }

        public static explicit operator String(Producto p)
        {
            return Producto.Mostrar(p);
        }

        public static bool operator ==(Producto a, Producto b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = a.fabricante == b.fabricante && a.modelo == b.modelo;
            }
            return rta;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

    }
}
