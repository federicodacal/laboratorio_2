using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia cm = new Competencia(3, 4, Competencia.TipoCompetencia.MotoCross);
            Competencia ca = new Competencia(2, 3, Competencia.TipoCompetencia.F1);

            MotoCross m1 = new MotoCross(10, "Motoneta", 5);
            MotoCross m2 = new MotoCross(10, "Motoneta", 10);
            MotoCross m3 = new MotoCross(10, "Motoneta", 10);

            Console.WriteLine(m1==m2);
            Console.WriteLine(m1==m3);
            Console.WriteLine(m2==m3);
            Console.WriteLine();

            AutoF1 a1 = new AutoF1(20, "Fiat", 5);
            AutoF1 a2 = new AutoF1(10, "Fiat", 5);
            AutoF1 a3 = new AutoF1(20, "Fiat", 5);

            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 == a3);
            Console.WriteLine(a2 == a3);
            Console.WriteLine();

            _ = cm + a1;
            _ = cm + m1;
            _ = cm + m2;
            _ = cm + m3;

            _ = ca + m1;
            _ = ca + a1;
            _ = ca + a2;
            _ = ca + a3;

            Console.WriteLine(cm.MostrarDatos());
            Console.WriteLine("<------------------------------------------------------>");
            Console.WriteLine(ca.MostrarDatos());

        }
    }
}
