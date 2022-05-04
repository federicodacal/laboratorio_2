using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro : Publicacion
    {
        private int ISBN;

        public Libro(string titulo, string autor, int cantidadPaginas, int ISBN)
            :base(titulo, autor, cantidadPaginas)
        {
            this.ISBN = ISBN;
        }

        public int ISBNumber
        {
            get { return this.ISBN; }
        }

        public string MostrarInformacion()
        {
            return $"Soy un libro \n{base.MostrarInformacion()} ISBN: {this.ISBNumber}";
        }
    }
}
