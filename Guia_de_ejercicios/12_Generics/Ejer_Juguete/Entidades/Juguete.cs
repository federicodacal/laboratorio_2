using System;

namespace Entidades
{
    public class Juguete
    {
        private string marca;
        private double precio;

        public Juguete(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        private string Mostrar()
        {
            return $"Juguete: {this.marca} ${String.Format("{0:0.00}", this.precio)}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
