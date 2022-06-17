using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            long numero;

            while (true)
            {
                Console.Write("Ingrese un número: ");
                input = Console.ReadLine();

                if(long.TryParse(input, out numero))
                {
                    int digitos = numero.ContarCantidadDeDigitos();
                    Console.WriteLine($"Numero de {digitos} digitos");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
