using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        protected Autor autor;
        protected int cantidadPaginas;
        protected static Random generadorPaginas;
        protected float precio;
        protected string titulo;

        static Libro()
        {
            Libro.generadorPaginas = new Random();
        }

        public Libro(string titulo, string apellido, string nombre, float precio)
            :this(precio, titulo, new Autor(nombre, apellido))
        {

        }

        public Libro(float precio, string titulo, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor;
        }

        public int CantidadDePaginas
        {
            get 
            {
                if(this.cantidadPaginas == 0)
                {
                    this.cantidadPaginas = Libro.generadorPaginas.Next(10, 570);
                }
                return this.cantidadPaginas;
            }
        }

        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"AUTOR: ");
            sb.AppendLine(l.autor);
            sb.AppendLine($"TITULO: {l.titulo}");
            sb.AppendLine($"CANTIDAD DE PÁGINAS: {l.CantidadDePaginas}");
            sb.AppendLine($"PRECIO: {l.precio}");

            return sb.ToString();
        }

        public static explicit operator String(Libro l)
        {
            return Libro.Mostrar(l);
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool rta = false;
            if(a is not null && b is not null)
            {
                rta = a.titulo == b.titulo && a.autor == b.autor;
            }
            return rta;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}
