using System;
using System.Collections.Generic;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Publicacion publicacion = new Publicacion("Batman","Bob Kane", 60);
            Libro libro = new Libro("Los cuentos de la selva", "Horacio Quiroga", 120, 551110);

            Console.WriteLine(publicacion.MostrarInformacion());
            Console.WriteLine();
            Console.WriteLine(libro.MostrarInformacion());
            Console.WriteLine();

            Publicacion libro2 = new Libro("El señor de los Anillos", "JRR Tolkien", 300, 662225);
            Publicacion articulo = new Articulo("UTN-FRA", "Herencia en C#", "Esteban", 12);

            List<Publicacion> lista = new List<Publicacion>();
            lista.Add(publicacion);
            lista.Add(libro);
            lista.Add(libro2);
            lista.Add(articulo);

            Console.WriteLine("<------------------------------------------------>");
            Console.WriteLine();

            foreach (Publicacion item in lista)
            {
                Console.WriteLine(item.MostrarInformacion());
            }
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------>");
            Console.WriteLine();

            foreach (Publicacion item in lista)
            {
                if(item is Libro)
                {
                    Console.WriteLine(((Libro)item).MostrarInformacion());
                }
                else if(item is Articulo)
                {
                    Console.WriteLine(((Articulo)item).MostrarInformacion());
                }
                else
                {
                    Console.WriteLine(item.MostrarInformacion());
                }
                Console.WriteLine("***********************");
            }
        }
    }
}
