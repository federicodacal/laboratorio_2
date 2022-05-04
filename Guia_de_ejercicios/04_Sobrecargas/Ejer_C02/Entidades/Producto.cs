using System;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"Producto: {p.GetMarca()} | Precio: ${p.GetPrecio()} | Codigo de Barra: {(string)p}";
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool rta = false;
            if (p1 is not null && p2 is not null)
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool rta = false;
            if(p is not null)
            {
                if((string)p == marca)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

     }
}
