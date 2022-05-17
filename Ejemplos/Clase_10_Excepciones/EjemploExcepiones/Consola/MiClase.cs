using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class MiClase
    {
        private string mensaje;

        public MiClase(string mensaje)
        {
            this.Mensaje = mensaje;
        }

        public string Mensaje
        {
            get { return this.mensaje; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new MensajeInvalidoException("El nombre no puede ser sólo espacios.");
                }

                this.mensaje = value;
            }
        }
    }
}
