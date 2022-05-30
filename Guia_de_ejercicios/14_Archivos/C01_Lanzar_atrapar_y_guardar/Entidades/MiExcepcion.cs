using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiExcepcion : Exception
    {

        public MiExcepcion(string message):this(message, null)
        {
        }

        public MiExcepcion(string message, Exception innerException):base(message, innerException)
        {
        }
    }
}
