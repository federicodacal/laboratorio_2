using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseEventoEventArgs : EventArgs
    {
        public int numero { get; set; }
        public string cadena {get; set;}
        public DateTime fecha { get; set; }
    }
}
