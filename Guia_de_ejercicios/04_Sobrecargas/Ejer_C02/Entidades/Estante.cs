using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");
            if(e.GetProductos() is not null && e.GetProductos().Length > 0)
            {
                sb.AppendLine("Listas de productos: ");
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if(e.GetProductos()[i] is not null)
                    {
                        sb.AppendLine(Producto.MostrarProducto(e.GetProductos()[i]));
                    }
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool rta = false;
            if(e is not null && p is not null && e.GetProductos() is not null)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if(p == e.GetProductos()[i])
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool rta = false;
            if(e is not null && p is not null)
            {
                int indice = Estante.BuscarIndiceLibre(e);
                if(indice != -1 && e != p)
                {
                    e.GetProductos().SetValue(p, indice);
                    rta = true;
                }
            }
            return rta;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                int indice = Array.IndexOf(e.GetProductos(), p);
                if(indice != -1)
                {
                    e.GetProductos()[indice] = null;
                }
            }
            return e;
        }

        public static int BuscarIndiceLibre(Estante e)
        {
            int index = -1;
            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                if(e.GetProductos()[i] is null)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

    }
}
