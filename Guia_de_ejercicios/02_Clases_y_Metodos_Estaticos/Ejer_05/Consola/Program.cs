using System;
using System.Text;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un número: ");

            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Dato incorrecto. Reingrese el número: ");
            }

            Console.WriteLine("\n*******************************************\n");

            Console.WriteLine(Program.MostrarTablaDeMultiplicar(num)); 

        }

        public static string MostrarTablaDeMultiplicar(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del número {numero}: ");
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero*i}");
            }
            return sb.ToString();
        }
    }
}
