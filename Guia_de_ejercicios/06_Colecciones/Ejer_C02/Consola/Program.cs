using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(3, 5);

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
            Console.WriteLine("---------------------");
            Console.WriteLine(a5.MostrarDatos());

        }
    }
}
