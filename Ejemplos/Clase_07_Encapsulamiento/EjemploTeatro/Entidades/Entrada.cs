using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrada
    {
        private string nombreObra;
        private DateTime fechaFuncion;
        private int codigoTicket;
        private static int ultimoCodigo;

        static Entrada()
        {
            Entrada.ultimoCodigo = 100;
        }

        public Entrada(string nombreObra, DateTime fechaFuncion)
        {
            this.nombreObra = nombreObra;
            this.fechaFuncion = fechaFuncion;
            this.codigoTicket = Entrada.ultimoCodigo++;
        }

        public string NombreObra
        {
            get { return this.nombreObra; }
        }

        public string Mostrar()
        {
            return $"{this.nombreObra} | Ticket: {this.codigoTicket} | Funcion: {this.fechaFuncion.ToShortDateString()}";
        }
    }
}
