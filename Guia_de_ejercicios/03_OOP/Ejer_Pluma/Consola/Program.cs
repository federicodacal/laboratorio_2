using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta t1 = new Tinta();
            Tinta t2 = new Tinta();
            Tinta t3 = new Tinta(ConsoleColor.DarkRed, ETipoTinta.ConBrillito);
            Pluma p1 = new Pluma(t1);
            Pluma p2 = new Pluma(t3);
            Pluma p3 = new Pluma();
            Pluma p4 = new Pluma("Faber",20);

            Console.WriteLine((string)t1);
            Console.WriteLine();
            Console.WriteLine(Tinta.Mostrar(t3));
            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
            Console.WriteLine();
            Console.WriteLine(p3);
            Console.WriteLine();
            Console.WriteLine(p4);

            Console.WriteLine("<---------------------------------------------------->");
            Console.WriteLine();

            Console.WriteLine(t1==t2);
            Console.WriteLine(t1!=t2);
            Console.WriteLine(t1==t3);
            Console.WriteLine();
            Console.WriteLine(p1==t1);
            Console.WriteLine(p1==t2);
            Console.WriteLine(p1==t3);

            Console.WriteLine();
            Console.WriteLine("<---------------------------------------------------->");
            Console.WriteLine();

            if(p1+t1)
            {
                Console.WriteLine("Se agregó tinta");
                Console.WriteLine(p1);
            }

            if (p1 + t3)
            {
                Console.WriteLine("Se agregó tinta");
                Console.WriteLine(p1);
            }
            else
            {
                Console.WriteLine("No se agregó tinta");
                Console.WriteLine(p1);
            }

            if(p2+t3)
            {
                Console.WriteLine("Se agregó tinta");
                Console.WriteLine(p2);
            }

            if (p2-t3)
            {
                Console.WriteLine("Se quitó tinta");
                Console.WriteLine(p2);
            }




        }
    }
}
