using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("Juan", 5000);
            Console.WriteLine(c.Mostrar());

            c.Ingresar(500);
            Console.WriteLine(c.Mostrar());
            c.Ingresar(-500);
            Console.WriteLine(c.Mostrar());
            c.Retirar(400);
            Console.WriteLine(c.Mostrar());
            c.Retirar(1400);
            Console.WriteLine(c.Mostrar());
            c.Retirar(2800);
            Console.WriteLine(c.Mostrar());
        }
    }
}
