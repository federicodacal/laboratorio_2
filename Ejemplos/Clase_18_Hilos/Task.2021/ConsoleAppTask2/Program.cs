using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(Program.MetodoTarea);

            Console.ReadLine();

            Task t1 = Task.Run(() => {

                Console.WriteLine("Inicio código en la tarea / hilo / subproceso secundario (=>)");

                Thread.Sleep(5000);

                Console.WriteLine("Finalizo el código en la tarea / hilo / subproceso secundario (=>)");

            });

            Console.ReadLine();
        }

        public static void MetodoTarea()
        {
            Console.WriteLine("Inicio código en la tarea / hilo / subproceso secundario");

            Thread.Sleep(5000);

            Console.WriteLine("Finalizo el código en la tarea / hilo / subproceso secundario");
        }
    }
}
