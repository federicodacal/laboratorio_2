using System;

namespace Ejer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            char seguir = 's';

            do
            {
                Console.WriteLine("Ingrese un número: ");
                if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    Console.WriteLine($"Número ingresado: {num} \nCuadrado: {Math.Pow(num,2)} \nCubo: {Math.Pow(num,3)}");
                    Console.WriteLine("\n¿Desea Continuar? s/n");
                    seguir = Convert.ToChar(Console.ReadLine());
                    seguir = Char.ToLower(seguir);
                }
                else
                {
                    Console.WriteLine("Dato incorrecto. Intente nuevamente");
                }

            } while (seguir!='n');
        }
    }
}
