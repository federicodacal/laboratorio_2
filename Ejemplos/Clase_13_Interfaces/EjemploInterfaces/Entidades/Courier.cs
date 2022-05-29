using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Courier : Persona, IMensaje
    {
        public decimal sueldo;
        public Courier(string nombre, string apellido, string dni, decimal sueldo)
            :base(nombre, apellido, dni)
        {
            this.sueldo = sueldo;
        }

        public string Correr()
        {
            return "Estoy corriendo...";
        }

        public string EnviarMensaje()
        {
            return "Completar la ficha de envío";
        }
    }
}
