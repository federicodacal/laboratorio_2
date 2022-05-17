using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VinotecaLlenaException : Exception
    {
        public VinotecaLlenaException(string message):base(message)
        {

        }
    }
}
