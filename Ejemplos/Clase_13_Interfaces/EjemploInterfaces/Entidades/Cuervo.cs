using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuervo : AnimalVolador, IMensaje, IEncriptado
    {
        public Cuervo(float peso) 
            :base(peso)
        {

        }

        public string Destino
        {
            get { return "Base secreta..."; }
        }

        public string EnviarMensaje()
        {
            return "Cuervo...";
        }

        string IEncriptado.EnviarMensaje()
        {
            return "Mensaje secreto...";
        }
        
    }
}
