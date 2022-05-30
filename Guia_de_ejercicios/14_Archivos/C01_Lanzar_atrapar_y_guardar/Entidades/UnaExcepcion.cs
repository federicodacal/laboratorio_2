using System;
using System.Runtime.Serialization;

namespace Entidades
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message):base(message)
        {
        }

        public UnaExcepcion(string message, Exception innerException):base(message, innerException)
        {
        }
    }
}
