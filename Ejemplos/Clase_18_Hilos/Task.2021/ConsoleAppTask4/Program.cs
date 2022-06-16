using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;

            Task t = Task.Run(() => Program.MetodoTareaLoop(ct));

            //cts.Cancel();

            Console.ReadLine();

            Task t1 = Task.Run(() => Program.MetodoTareaLoopParam(ct, 500, "hola"));
            
            Console.ReadLine();

            // Cancelar la tarea
            cts.Cancel();

            Console.ReadLine();
        }

        public static void MetodoTareaLoop(CancellationToken ct)
        {
            Console.WriteLine("Inicio código en la tarea / hilo / subproceso secundario infinito");
            do
            {
                if (ct.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelo el código en la tarea / hilo / subproceso secundario infinito");
                    return;
                }

            } while (true);
            
        }

        public static void MetodoTareaLoopParam(CancellationToken ct, int param1, string param2)
        {
            Console.WriteLine("Inicio código en la tarea / hilo / subproceso secundario infinito (param1: {0})", param1);

            do
            {
                if (ct.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelo el código en la tarea / hilo / subproceso secundario infinito (param2: {0})", param2);
                    return;
                }

            } while (true);

        }
    }
}
