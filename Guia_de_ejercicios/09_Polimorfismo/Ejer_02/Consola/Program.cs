using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(4));
            figuras.Add(new Rectangulo(4,8));

            foreach (Figura item in figuras)
            {
                Console.WriteLine($"Tipo {item.GetType()}");
                Console.WriteLine(item.Dibujar());
                Console.WriteLine($"Área: {item.CalcularSuperficie()}");
                Console.WriteLine($"Perímetro: {item.CalcularPerimetro()}"); 
                Console.WriteLine("****************************************");
            }
        }
    }
}
