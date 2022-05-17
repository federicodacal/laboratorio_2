using System;
using Biblioteca;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<short> listaDeShort = new Lista<short>(3);

            short a = 1;
            short b = 2;
            short c = 3;
            short d = 4;

            listaDeShort.Add(a);
            listaDeShort.Add(b);
            listaDeShort.Add(c);
            listaDeShort.Add(d); // No lo agrega

            Console.WriteLine(listaDeShort.ToString());

            Lista<Persona> listaDePersonas = new Lista<Persona>(2);

            Persona p1 = new Persona("Pepe", "3544321");
            Persona p2 = new Persona("Juan", "4224121");

            listaDePersonas.Add(p1);
            listaDePersonas.Add(p2);

            Console.WriteLine(listaDePersonas.ToString());

            Console.WriteLine($"Lista de short en el indice 1: {listaDeShort.GetElement(1)}");
            Console.WriteLine($"Lista de short en el indice 4: {listaDeShort.GetElement(4)}");
            Console.WriteLine($"Lista de Personas en el indice 0: {listaDePersonas.GetElement(1)}");
            Console.WriteLine($"Lista de Personas en el indice 4: {listaDePersonas.GetElement(4)}"); //null
            Console.WriteLine();

        }
    }
}
