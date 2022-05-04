using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero l = new Lavadero(30, 65, 15);

            Moto m = new Moto("YYY333", 2, EMarcas.Honda, 34.5F);
            Camion c = new Camion("FFF444", 8, EMarcas.Scania, 200);
            Camion c2 = new Camion("EEE444", 6, EMarcas.Iveco, 500);
            Auto a = new Auto("AAA123", 4, EMarcas.Fiat, 4);
            Auto a2 = new Auto("TTT500", 4, EMarcas.Fiat, 3);

            l += m;
            l += a;
            l += c;
            l += a2;
            l += c2;

            Console.WriteLine(l.Detalle);

            l -= m;
            l -= a;

            Console.WriteLine();
            Console.WriteLine("<--------------------------------------------------->");
            Console.WriteLine(l.Detalle);

        }
    }
}
