using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir = 's';
            int x;
            int y;
            float resultado;
            char operador;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el primer operando: ");
                while (!(int.TryParse(Console.ReadLine(), out x)))
                {
                    Console.WriteLine("Dato ingresado no valido. Reingrese operando: ");
                }

                Console.WriteLine("Ingrese la operacion '+' '-' '/' '*': ");
                operador = Console.ReadKey().KeyChar;
                while (!(Calculadora.ValidarOperador(operador)))
                {
                    Console.WriteLine("Dato ingresado no valido. Reingrese la operacion: ");
                }

                Console.WriteLine("\nIngrese el segundo operando: ");
                while (!(int.TryParse(Console.ReadLine(), out y)) || (!Calculadora.ValidarOperando(y) && operador == '/'))
                {
                    Console.WriteLine("Dato ingresado no valido. Reingrese operando: ");
                }


                resultado = Calculadora.Calcular(x, y, operador);
                Console.WriteLine("\n**************************************************\n");
                Console.WriteLine($"El resultado de {x} {operador} {y} es: {resultado}");

                Console.WriteLine("¿Desea continuar? s/n");
                Char.ToLower(seguir);
                seguir = Console.ReadKey().KeyChar;

            } while (seguir != 'n');
        }
    }
}
