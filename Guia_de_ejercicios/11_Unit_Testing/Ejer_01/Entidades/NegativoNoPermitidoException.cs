using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException(string message)
            :this(message, null)
        {
        }

        public NegativoNoPermitidoException(string message, Exception innerException) 
            :base(message, innerException)
        {
        }
    }
}
