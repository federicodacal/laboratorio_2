using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado (5 longitud lado): " + CalculadoraDeAreas.CalcularAreaCuadrado(5));
            Console.WriteLine();

            Console.WriteLine("Area de un triangulo (2 base, 3 altura): " + CalculadoraDeAreas.CalcularAreaTriangulo(2,3));
            Console.WriteLine();

            Console.WriteLine("Area de un circulo (3 radio): " + CalculadoraDeAreas.CalcularAreaCirculo(3));
            Console.WriteLine();
        }
    }
}
