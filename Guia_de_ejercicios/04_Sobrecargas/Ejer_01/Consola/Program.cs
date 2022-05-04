using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(5);
            Sumador s3 = new Sumador(6);

            Console.WriteLine(s1.GetCantidadSumas());
            Console.WriteLine(s2.GetCantidadSumas());
            Console.WriteLine();

            Console.WriteLine(s1.Sumar(1, 3));
            Console.WriteLine(s1.Sumar(4, 5));
            Console.WriteLine(s1.Sumar("Sobre","Carga"));
            Console.WriteLine(s2.Sumar(5 ,5));
            Console.WriteLine();

            Console.WriteLine(s1.GetCantidadSumas());
            Console.WriteLine(s2.GetCantidadSumas());
            Console.WriteLine();

            Console.WriteLine("Con explicit");
            Console.WriteLine((int)s1);
            Console.WriteLine((int)s2);
            Console.WriteLine();

            Console.WriteLine("Sobrecarga operador +");
            long resultado = s1 + s2;
            Console.WriteLine(resultado);
            Console.WriteLine();

            Console.WriteLine("Sobrecarga operador |");
            Console.WriteLine(s1|s2);
            Console.WriteLine(s2|s3);

        }
    }
}
