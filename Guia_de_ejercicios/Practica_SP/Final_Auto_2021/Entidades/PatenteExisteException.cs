using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteExisteException : Exception
    {

        public PatenteExisteException(string message) : base(message)
        {
        }

        public PatenteExisteException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
