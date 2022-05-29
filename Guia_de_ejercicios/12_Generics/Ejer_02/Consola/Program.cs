using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

            Factura f1 = new Factura(200);
            Factura f2 = new Factura(205);
            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(500);

            c += f1;
            c += f2;
            c += r1;
            c += r2;

            Console.WriteLine(c.ToString());
        }
    }
}
