using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class XmlSerializationException : Exception
    {
        public XmlSerializationException(string message) 
            :base(message)
        {

        }

        public XmlSerializationException(string message, Exception innerException) 
            :base(message, innerException)
        {

        }

    }
}
