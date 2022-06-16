using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(Program.MetodoTarea);

            t.Start();

            Console.WriteLine("Continúo con código dentro del hilo principal...");

            Thread.Sleep(500);

            Console.WriteLine("Continúo con más código dentro del hilo principal...");

            Thread.Sleep(500);

            Console.WriteLine("Continúo con mucho más código dentro del hilo principal...");

            t.Wait();

            Thread.Sleep(500);

            Console.WriteLine("Reanudo el código dentro del principal");

            Console.ReadLine();
        }

        public static void MetodoTarea()
        {
            Console.WriteLine($"Inicio código en la tarea / hilo / subproceso secundario / ThreadId:{Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep(5000);

            Console.WriteLine($"Finalizo el código en la tarea / hilo / subproceso secundario / ThreadId:{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
