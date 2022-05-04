using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Articulo : Publicacion
    {
        private string editorial;

        public Articulo(string editorial, string titulo, string autor, int cantidadPaginas) 
            :base(titulo, autor, cantidadPaginas)
        {
            this.editorial = editorial;
        }

        public string MostrarInformacion()
        {
            return $"Soy un articulo \n{base.MostrarInformacion()} Editorial: {this.editorial}";
        }
    }
}
