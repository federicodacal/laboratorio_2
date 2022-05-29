using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Dato5
    {
        private string cadena;
        private DateTime fecha;
        private decimal numerico;

        public string Cadena
        {
            get
            {
                return this.cadena;
            }
            set
            {
                this.cadena = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public decimal Numerico
        {
            get
            {
                return this.numerico;
            }
            set
            {
                this.numerico = value;
            }
        }

        public Dato5(string cadena, DateTime fecha, decimal numerico)
        {
            this.cadena = cadena;
            this.fecha = fecha;
            this.numerico = numerico;
        }

        public override string ToString()
        {
            return $"cadena: {this.cadena} - fecha: {this.fecha.ToLongDateString()} - numérico: {this.numerico}";
        }
    }
}
