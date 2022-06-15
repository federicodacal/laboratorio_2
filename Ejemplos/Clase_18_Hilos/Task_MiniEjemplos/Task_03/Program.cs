using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Task> listaTareas = new List<Task>()
            {
                new Task(Tarea01),
                new Task(Tarea02),
                new Task(Tarea03),
            };

            listaTareas.ForEach((x) => x.Start());

            Thread.Sleep(7000);

            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine();

            List<string> nombres = new List<string>();

            nombres.Add("Pepe");
            nombres.Add("Juana");
            nombres.Add("Martina");
            nombres.Add("Pepita");
            nombres.Add("Pancho");

            nombres.ForEach((nombre) => Console.WriteLine(nombre.ToString()));

            Console.WriteLine();

            List<string> dato = nombres.FindAll(x => x.Length == 6);
            dato.ForEach((nombre) => Console.WriteLine(nombre.ToString()));

            Console.WriteLine();

            bool existe = nombres.Exists(x => x == "Pepe");
            Console.WriteLine(existe);

        }

        public static void Tarea01()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Tarea 1");

        }
        public static void Tarea02()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Tarea 2");

        }
        public static void Tarea03()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Tarea 3");

        }
    }
}
