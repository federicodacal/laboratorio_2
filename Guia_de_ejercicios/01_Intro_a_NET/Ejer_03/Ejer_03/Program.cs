using System;

namespace Ejer_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int contDiv;
            string seguir = "";

            do
            {
                Console.WriteLine("Ingrese un número");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Primos: ");
                    for (int i = 1; i <= num; i++)
                    {
                        contDiv = 0;
                        for (int j = 1; j<=i; j++)
                        {
                            if(i%j == 0)
                            {
                                contDiv++;
                            }
                        }
                        if (contDiv == 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine($"Ingrese \"salir\" en caso que no desee continuar");
                    seguir = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Dato incorrecto. Intente nuevamente");
                }
            } while (seguir != "salir");
        }
    }
}
