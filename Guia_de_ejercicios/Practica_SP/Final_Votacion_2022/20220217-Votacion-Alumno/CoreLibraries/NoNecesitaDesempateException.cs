using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public class NoNecesitaDesempateException : Exception
    {
        public NoNecesitaDesempateException():base("Votación no empatada")
        {

        }
    }
}
