using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(MiMetodo);

            Task.Run( ()=> MetodoConArgumentos("cadena") );

            Task t3 = Task.Run( ()=> {
                Thread.Sleep(2000);
                Console.WriteLine("Hilo anonimo - TASK:" + Task.CurrentId + " - Thread:" + Thread.CurrentThread.ManagedThreadId);

            } );

            Task t4 = Task.Run(MiMetodo);

            t.Start();
            //t2.Start();
            //t3.Start();

            //Task.WaitAll(t, t2, t3);
            //t4.Start();

            Thread.Sleep(3000);

            Console.WriteLine("Hilo principal - Thread:" + Thread.CurrentThread.ManagedThreadId);

            Console.ReadKey();
        }
        public static void MiMetodo()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hilo secundario - TASK:" + Task.CurrentId+" - Thread:"+Thread.CurrentThread.ManagedThreadId);
        }

        public static void MetodoConArgumentos(string cadena)
        {
            Thread.Sleep(5000);
            Console.WriteLine(cadena);
        }

    }

}
