using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BarcoRepetidoException : Exception
    {
        public BarcoRepetidoException(string message) : base(message)
        {
        }

        public BarcoRepetidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
