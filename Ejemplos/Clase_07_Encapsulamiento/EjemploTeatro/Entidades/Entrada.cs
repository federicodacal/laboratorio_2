using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrada
    {
        private Funcion funcion;
        private int codigoTicket;
        private static int ultimoCodigo;
        private Espectador espectador;

        static Entrada()
        {
            Entrada.ultimoCodigo = 100;
        }

        public Entrada(Funcion funcion, Espectador espectador)
        {
            this.funcion = funcion;
            this.espectador = espectador;
            this.codigoTicket = Entrada.ultimoCodigo++;
        }

        public string Mostrar()
        {
            return $"{this.funcion} | Ticket: {this.codigoTicket} | Funcion: {this.funcion.Fecha.ToShortDateString()}";
        }

    }
}
