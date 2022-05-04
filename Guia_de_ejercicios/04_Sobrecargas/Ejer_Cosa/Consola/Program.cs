using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa = new Cosa();

            cosa.EstablecerValor(20);
            cosa.EstablecerValor("Hola");
            cosa.EstablecerValor(new DateTime(1999,10,15));

            Console.WriteLine(Cosa.Mostrar(cosa));
            Console.WriteLine();

            Cosa c1 = new Cosa();
            Cosa c2 = new Cosa(15, "Chau");
            Cosa c3 = new Cosa("cadena");
            Cosa c4 = new Cosa(new DateTime(2015,8,25), 200, "Mi mensaje");

            Console.WriteLine(Cosa.Mostrar(c1));
            Console.WriteLine();
            Console.WriteLine(Cosa.Mostrar(c2));
            Console.WriteLine();
            Console.WriteLine(Cosa.Mostrar(c3));
            Console.WriteLine();
            Console.WriteLine(Cosa.Mostrar(c4));
            Console.WriteLine();

        }
    }
}
