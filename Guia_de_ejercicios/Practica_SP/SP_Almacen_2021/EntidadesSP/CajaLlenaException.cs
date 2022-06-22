using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public class CajaLlenaException : Exception
    {

        public CajaLlenaException(string message) : base(message)
        {
        }

        public CajaLlenaException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
