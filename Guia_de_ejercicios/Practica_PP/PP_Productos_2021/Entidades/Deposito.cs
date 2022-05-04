using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        private int capacidad;
        private List<Producto> productos;

        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        private Deposito(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }

        public double PrecioDeCelulares
        {
            get { return this.ObtenerPrecio(EProducto.PrecioDeCelulares); }
        }

        public double PrecioDeTelevisores
        {
            get { return this.ObtenerPrecio(EProducto.PrecioDeTelevisores); }
        }

        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(EProducto.PrecioTotal); }
        }

        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(d.GetType().Name);
            sb.AppendLine($"Capacidad: {d.capacidad} ({d.productos.Count})");
            sb.AppendLine($"Total por Televisores: {String.Format("{0:0.00}",d.PrecioDeTelevisores)}");
            sb.AppendLine($"Total por Celulares: {String.Format("{0:0.00}", d.PrecioDeCelulares)}");
            sb.AppendLine($"Total: {String.Format("{0:0.00}", d.PrecioTotal)}");
            sb.AppendLine("*********************************************");
            sb.AppendLine("\tListado de Productos");
            sb.AppendLine("*********************************************");
            foreach (Producto item in d.productos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        private double ObtenerPrecio(EProducto tipo)
        {
            double precioTotal = 0;
            foreach (Producto item in this.productos)
            {
                if(tipo == EProducto.PrecioDeTelevisores && item.GetType() == typeof(Televisor))
                {
                    precioTotal += (float)(Televisor)item;
                }
                else if(tipo == EProducto.PrecioDeCelulares && item.GetType() == typeof(Celular))
                {
                    precioTotal += (Celular)item;
                }
                else if(tipo == EProducto.PrecioTotal)
                {
                    if(item.GetType() == typeof(Televisor))
                    {
                        precioTotal += (float)(Televisor)item;
                    }
                    else if(item.GetType() == typeof(Celular))
                    {
                        precioTotal += (Celular)item;
                    }
                }
            }
            return precioTotal;
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            bool rta = false;
            if(d is not null && p is not null)
            {
                foreach (Producto item in d.productos)
                {
                    if (item.Equals(p))
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static Deposito operator +(Deposito d, Producto p)
        {
            if(d.capacidad > d.productos.Count)
            {
                if(d != p)
                {
                    d.productos.Add(p);
                }
                else
                {
                    Console.WriteLine("No se agregó. Ya estaba el producto!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay lugar!!!");
            }
            return d;
        }
    }
}
