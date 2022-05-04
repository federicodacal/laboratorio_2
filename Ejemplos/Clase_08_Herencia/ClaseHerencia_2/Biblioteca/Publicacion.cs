using System;

namespace Biblioteca
{
    public class Publicacion
    {
        private string titulo;
        private int cantidadPaginas;
        private string autor;

        public Publicacion(string titulo, string autor, int cantidadPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.cantidadPaginas = cantidadPaginas;
        }

        public string Titulo
        {
            get { return this.titulo; }
        }

        public string Autor
        {
            get { return this.autor; }
        }

        public int CantidadPaginas
        {
            get { return this.cantidadPaginas; }
            set { this.cantidadPaginas = value; }
        }

        public string MostrarInformacion()
        {
            return $"Tipo: {this.GetType().Name} \nTitulo: {this.Titulo}, Autor: {this.Autor}, {this.CantidadPaginas} páginas";
        }
    }
}
