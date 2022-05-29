using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Dato4
    {
        public string cadena;
        protected int entero;
        private bool booleano;
        private List<Dato1> datos;

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

        public List<Dato1> Datos
        {
            get { return this.datos; }
            set { this.datos = value; }
        }

        public Dato4()
        {
            this.datos = new List<Dato1>();
            this.cadena = "valor inicial";
            this.entero = 1;
            this.booleano = true;
        }

        public override string ToString()
        {
            string retorno =  $"cadena: {this.cadena} - entero: {this.entero} - booleano: {this.booleano}";
            foreach (Dato1 item in this.datos)
            {
                retorno += $"\n {item}";
            }
            return retorno;
        }
    }
}
