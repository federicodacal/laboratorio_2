using System;

namespace Ejer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int num;
            int max = int.MinValue;
            int min = int.MaxValue;
            int acum = 0;
            float promedio;

            do
            {
                Console.WriteLine($"Ingrese el número #{cont+1}");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Numero ingresado: {num}\n");
                    if(num > max)
                    {
                        max = num;
                    }
                    if(num < min)
                    {
                        min = num;
                    }
                    cont++;
                    acum += num;
                }
                else
                {
                    Console.WriteLine("El dato ingresado no es correcto. Intente nuevamente");
                }

            } while (cont != 5);

            promedio = (float)acum / cont;

            Console.WriteLine($"\nEl valor minimo es {min} y el maximo es {max}. El promedio es {promedio}");
        }
    }
}
