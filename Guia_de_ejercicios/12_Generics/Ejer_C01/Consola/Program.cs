using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<AutoF1> c = new Competencia<AutoF1>(4, 20);

            AutoF1 a1 = new AutoF1(25, "Fiat");
            AutoF1 a4 = new AutoF1(25, "Fiat");
            AutoF1 a2 = new AutoF1(26, "Alfa Romeo");
            AutoF1 a3 = new AutoF1(27, "Ferrari");
            AutoF1 a5 = new AutoF1(31, "Ferrari");

            _ = c + a1;
            _ = c + a4;
            _ = c + a2;
            _ = c + a3;
            _ = c + a5;

            Console.WriteLine(c.MostrarDatos());
            Console.WriteLine("---------------------------------------------------");

            Competencia<MotoCross> c2 = new Competencia<MotoCross>(4, 20);

            MotoCross m1 = new MotoCross(25, "Motoneta");
            MotoCross m2 = new MotoCross(35, "Motito");
            MotoCross m3 = new MotoCross(26, "Una Moto");


            _ = c2 + m1;
            _ = c2 + m2;
            _ = c2 + m3;

            Console.WriteLine(c2.MostrarDatos());

        }
    }
}
