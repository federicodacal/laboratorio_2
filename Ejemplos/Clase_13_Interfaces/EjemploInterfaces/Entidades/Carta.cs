using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carta : Papel, IMensaje
    {
        public string sello;
        public Carta(string tipo, int cantHojas, string sello) 
            :base(tipo, cantHojas)
        {
            this.sello = sello;
        }

        public string AbrirCartar()
        {
            return "Abriendo carta...";
        }

        public string EnviarMensaje()
        {
            return "Esta es la carta";
        }
    }
}
