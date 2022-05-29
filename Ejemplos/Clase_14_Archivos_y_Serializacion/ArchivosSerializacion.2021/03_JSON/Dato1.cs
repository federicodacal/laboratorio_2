using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Dato1
    {
        public string cadena;
        protected int entero;
        private bool booleano;

        public string Cadena
        {
            get { return this.cadena; }
            set { this.cadena = value; }
        }
        public Int32 Entero
        {
            get { return this.entero; }
            set { this.entero = value; }
        }
        public Boolean Booleano
        {
            get { return this.booleano; }
            set { this.booleano = value; }
        }
        public Dato1()
        {
            this.cadena = "valor inicial";
            this.entero = 1;
            this.booleano = true;
        }

        public override string ToString()
        {
            return $"cadena: {this.cadena} - entero: {this.entero} - booleano: {this.booleano}";
        }
    }
}
