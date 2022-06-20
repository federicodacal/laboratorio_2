using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public delegate void DelegadoToString(ClaseEvento sender, ClaseEventoEventArgs e);

    public class ClaseEvento
    {
        private int numero;
        private string cadena;

        public event DelegadoToString EventoToString;

        public ClaseEvento(int numero, string cadena)
        {
            this.numero = numero;
            this.cadena = cadena;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Cadena { get => cadena; set => cadena = value; }

        public override string ToString()
        {
            if(this.EventoToString is not null)
            {
                ClaseEventoEventArgs e = new ClaseEventoEventArgs();

                e.numero = this.Numero;
                e.cadena = this.cadena;
                e.fecha = DateTime.Now;

                this.EventoToString.Invoke(this, e);
            }
            return $"{this.Numero}, {this.Cadena}";
        }
    }
}
