using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<----------------------- PARTE 1 ----------------------->");
            Console.WriteLine();
            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Negro", "BMW");
            Auto a4 = new Auto("Verde", "Ford");
            DepositoDeAutos da = new DepositoDeAutos(3);
            if ((da + a1))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }
            da.Agregar(a2);
            da.Agregar(a3);
            if (!da.Agregar(a4))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(da);
            da.Remover(a2);
            if (!(da - a4))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(da);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("<----------------------- PARTE 2 ----------------------->");
            Console.WriteLine();

            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            DepositoDeCocinas dc = new DepositoDeCocinas(5);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("<----------------------- PARTE 3 ----------------------->");
            Console.WriteLine();

            Cocina co1 = new Cocina(111, 12300, false);
            Cocina co2 = new Cocina(112, 15000, true);
            Cocina co3 = new Cocina(113, 5600, false);
            Auto au1 = new Auto("Rojo", "Ferrari");
            Auto au2 = new Auto("Amarillo", "Porche");
            Auto au3 = new Auto("Negro", "BMW");
            Auto au4 = new Auto("Verde", "Ford");
            Deposito<Cocina> dco = new Deposito<Cocina>(5);
            Deposito<Auto> dau = new Deposito<Auto>(3);
            dco.Agregar(co1);
            dco.Agregar(co2);
            if (!(dco + co3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            if ((dau + au1))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }
            dau.Agregar(au2);
            dau.Agregar(au3);
            if (!dau.Agregar(au4))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dco);
            Console.WriteLine(dau);
            dco.Remover(co2);
            if (!(dco - co2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            dau.Remover(au2);
            if (!(dau - au4))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dco);
            Console.WriteLine(dau);
            Console.ReadLine();

        }
    }
}
