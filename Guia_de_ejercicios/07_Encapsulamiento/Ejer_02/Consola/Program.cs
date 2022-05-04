using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Frodo";
            libro[1] = "Samwise";
            libro[2] = "Gandalf";
            for (int i = 0; i < libro.CantidadPaginas; i++)
            {
                Console.WriteLine(libro[i]);
            }

            Console.WriteLine("-----------------------------------");

            libro[2] = "Gimli";
            libro[3] = "Legolas";
            libro[6] = "Aragorn";
            libro[-1] = "Sauron";
            for (int i = 0; i < libro.CantidadPaginas; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
