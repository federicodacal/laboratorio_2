using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Parte 1: \n");

            Sello.mensaje = "Hola Mundo";

            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine();

            Console.WriteLine("Parte 2: \n");

            Sello.mensaje = "Hola Mundo C#";

            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.White;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.Blue;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.DarkGray;
            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine();

            Console.WriteLine("Parte 3: \n");

            Sello.mensaje = "     ";
            Console.WriteLine(Sello.Imprimir());
            Sello.ImprimirEnColor();
            Sello.mensaje = "  HOLA MUNDO!!!   ";
            Console.WriteLine(Sello.Imprimir());

        }
    }
}
