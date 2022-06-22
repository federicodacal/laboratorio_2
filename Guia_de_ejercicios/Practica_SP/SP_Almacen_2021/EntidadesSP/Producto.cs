using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear, en un proyecto de tipo class library (EntidadesSP), las siguientes clases:
///Producto:
///atributos protegidos: marca:string, tipo:string, codigo:int, precio:double 
///propiedes públicas de lectura y escritura para todos sus atributos.
///contructor con 4 parámetros.
///Sobrescritura del método ToString, mostrando todos sus atributos.

namespace EntidadesSP
{
    public class Producto
    {
        protected string marca;
        protected string tipo;
        protected int codigo;
        protected double precio;   
        
        public Producto()
        {

        }

        public Producto(string marca, string tipo, int codigo, double precio)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.codigo = codigo;
            this.precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return $"Codigo: {this.Codigo} - Marca: {this.Marca} - Tipo: {this.Tipo} - Precio ${this.Precio}";
        }

    }
}
