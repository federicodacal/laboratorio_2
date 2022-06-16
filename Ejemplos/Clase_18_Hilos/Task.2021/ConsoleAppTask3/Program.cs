using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() => Program.MetodoTareaParam(5, "Hola Mundo"));

            Console.ReadLine();
        }

        public static void MetodoTareaParam(int param1, string param2)
        {
            Console.WriteLine("Inicio código en la tarea / hilo / subproceso secundario (param1: {0})", param1);

            Thread.Sleep(param1 * 1000);

            Console.WriteLine("Finalizo el código en la tarea / hilo / subproceso secundario (param2: {0})", param2);
        }

    }
}
