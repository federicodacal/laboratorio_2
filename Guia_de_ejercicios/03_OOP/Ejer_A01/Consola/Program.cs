using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor c1 = new Conductor("Pepe");
            Conductor c2 = new Conductor("Pablo");
            Conductor c3 = new Conductor("Pipo");

            Empresa e = new Empresa("Scania", 3);
            Empresa e2 = new Empresa("Iveco", 2);

            c1.SetKmsPorDia(1, 200);
            c1.SetKmsPorDia(2, 0);
            c1.SetKmsPorDia(3, 100);
            c1.SetKmsPorDia(4, 400);
            c1.SetKmsPorDia(5, 300);
            c1.SetKmsPorDia(6, 0);
            c1.SetKmsPorDia(7, 200);

            Console.WriteLine(c1.Mostrar());
            Console.WriteLine();

            c2.SetKmsPorDia(1, 500);
            //c2.SetKmsPorDia(2, 0);
            //c2.SetKmsPorDia(3, 0);
            c2.SetKmsPorDia(4, 500);
            c2.SetKmsPorDia(5, 500);
            c2.SetKmsPorDia(6, 0);
            c2.SetKmsPorDia(7, 200);

            Console.WriteLine(c2.Mostrar());
            Console.WriteLine();

            //c3.SetKmsPorDia(1, 0);
            //c3.SetKmsPorDia(2, 0);
            //c3.SetKmsPorDia(3, 0);
            //c3.SetKmsPorDia(4, 0);
            c3.SetKmsPorDia(5, 600);
            c3.SetKmsPorDia(6, 600);
            c3.SetKmsPorDia(7, 300);

            Console.WriteLine(c3.Mostrar());
            Console.WriteLine();

            if (e.AgregarConductor(c1))
            {
                Console.WriteLine("OK");
            }

            if (e.AgregarConductor(c2))
            {
                Console.WriteLine("OK");
            }

            if (e.AgregarConductor(c3))
            {
                Console.WriteLine("OK");
            }

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine(e2.MostrarConductores());
            Console.WriteLine();
            Console.WriteLine(e.MostrarConductores());
            Console.WriteLine();

            Console.WriteLine("Mas recorrio en la semana:");
            Console.WriteLine(e.GetConductorMasKmsRecorridosSemana().Mostrar()); 
        }
    }
}
