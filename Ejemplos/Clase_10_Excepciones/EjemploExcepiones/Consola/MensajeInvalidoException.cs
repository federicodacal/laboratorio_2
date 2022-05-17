using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class MensajeInvalidoException : Exception
    {
        public MensajeInvalidoException(string mensaje):base(mensaje)
        {

        }

        public MensajeInvalidoException(string mensaje, Exception innerException):base(mensaje, innerException)
        {

        }

    }
}
