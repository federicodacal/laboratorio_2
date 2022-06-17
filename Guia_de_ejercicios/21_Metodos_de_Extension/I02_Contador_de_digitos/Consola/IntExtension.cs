using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class IntExtension
    {
        public static int ContarCantidadDeDigitos(this Int64 numero)
        {
            return numero.ToString().Length;
        }
    }
}
