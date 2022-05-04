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

        public string MostrarTrompeta()
        {
            return base.Mostrar() + $"\nClave: {this.clave}";
        }
    }
}
