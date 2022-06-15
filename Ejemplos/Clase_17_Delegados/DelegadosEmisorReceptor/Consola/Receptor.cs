using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Receptor
    {
        private string nombre;

        public Receptor(string nombre)
        {
            this.nombre = nombre;
        }

        public void RecibirNotificacion()
        {
            Console.WriteLine($"{this.nombre}, recibí una notificación a las {DateTime.Now.ToLongTimeString()}");
        }
    }
}
