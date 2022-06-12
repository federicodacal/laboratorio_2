using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FallaLogException : Exception
    {

        public FallaLogException(string message):base(message)
        {
        }

        public FallaLogException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
