using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NewsletterEventArgs : EventArgs
    {
        private string contenido;
        public string Contenido { get => contenido; set => contenido = value; }
    }
}
