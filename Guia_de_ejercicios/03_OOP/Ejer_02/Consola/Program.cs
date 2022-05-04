using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe", new DateTime(2000, 10, 1), "33555444");
            Persona persona2 = new Persona("Juan", new DateTime(2004, 12, 2), "38388388");
            Persona persona3 = new Persona("Ana", new DateTime(1990, 11, 20), "36000444");
            Persona persona4 = new Persona("Juana", new DateTime(1998, 4, 15), "37777444");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona4.Mostrar());
            Console.WriteLine();
        }
    }
}
