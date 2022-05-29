using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Dato3
    {
        private string cadena;
        private int entero;
        private bool booleano;

        public string Cadena
        {
            get { return this.cadena; }
        }
        public Int32 Entero
        {
            get { return this.entero; }
        }
        public Boolean Booleano
        {
            get { return this.booleano; }
        }

        public Dato3(string cadena)
        {
            this.cadena = cadena;
            this.entero = 1;
            this.booleano = true;
        }

        public override string ToString()
        {
            return $"cadena: {this.cadena} - entero: {this.entero} - booleano: {this.booleano}";
        }
    }
}
