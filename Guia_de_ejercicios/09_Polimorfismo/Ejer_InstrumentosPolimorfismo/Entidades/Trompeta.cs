using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trompeta : Instrumento
    {
        private string clave;

        public Trompeta(string marca, int codigo, EClasificacion clasificacion, string clave) 
            :base(codigo,marca,clasificacion)
        {
            this.clave = clave;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + $"\nClave: {this.clave}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        /*
        public override bool Equals(object obj)
        {
            Trompeta unaTrompeta = obj as Trompeta;
            return unaTrompeta is not null && this == unaTrompeta;
        }
        */
    }
}
