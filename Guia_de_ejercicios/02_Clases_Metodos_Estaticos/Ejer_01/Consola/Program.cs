using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cantNums = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int suma = 0;
            float promedio;

            Console.WriteLine("Ingrese 10 numeros enteros: ");

            do
            {
                Console.WriteLine($"#{cantNums + 1}: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if(Validador.Validar(num,-100,100))
                    {
                        suma += num;
                        cantNums++;
                        if(num < min)
                        {
                            min = num;
                        }
                        if(num > max)
                        {
                            max = num;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El valor debe estar dentro del rango -100 a 100");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Reingrese dato.");
                }
            } while (cantNums < 10);

            Console.WriteLine("************************************************");

            promedio = (float)suma / cantNums;

            Console.WriteLine($"El valor máximo es {max} \nEl valor mínimo es {min} \nEl promedio es {promedio}");
        }
    }
}
