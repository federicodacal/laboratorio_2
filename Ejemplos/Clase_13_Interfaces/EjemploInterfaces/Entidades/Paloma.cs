using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paloma : AnimalVolador, IMensaje
    {
        public Paloma(float peso) 
            :base(peso)
        {

        }

        public string Volar()
        {
            return "Estoy volando...";
        }
        public string EnviarMensaje()
        {
            return "Paloma Mensajera";
        }
    }
}
