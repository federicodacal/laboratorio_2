using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class BaseDeDatosException : Exception
    {
        public BaseDeDatosException(string message) : base(message)
        {
        }

        public BaseDeDatosException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
