using System;

///Articulo:
///atributos privados: marca : string, codigo : int, precio : double 
///propiedes públicas de lectura y escritura para todos sus atributos.
///contructor con 3 parámetros.
///Sobrescritura del método ToString, mostrando todos sus atributos.

namespace EntidadesSP
{
    public class Articulo
    {
        private string marca;
        private int codigo;
        private double precio;

        public Articulo()
        {

        }

        public Articulo(string marca, int codigo, double precio)
        {
            this.marca = marca;
            this.codigo = codigo;
            this.precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return $"Marca: {this.Marca} - Codigo: {this.Codigo} - ${this.Precio}";
        }
    }
}
