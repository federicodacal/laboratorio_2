using System;
using System.Threading.Tasks;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea1 = new Task(() => 
            {
                Console.WriteLine("Primera tarea iniciada");
                Thread.Sleep(5000);
                Console.WriteLine("Primera tarea finalizada");
            });

            tarea1.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Segunda tarea iniciada");
            Thread.Sleep(1000);
            Console.WriteLine("Segunda tarea finalizada");

            Thread.Sleep(1000);
            Console.WriteLine("Tercera tarea iniciada");
            Thread.Sleep(1000);
            Console.WriteLine("Tercera tarea finalizada");

            Thread.Sleep(3000);
        }
    }
}
