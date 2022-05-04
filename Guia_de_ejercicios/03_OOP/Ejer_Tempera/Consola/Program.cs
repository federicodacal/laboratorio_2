using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera t4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Temperita", 50);
            Tempera t6 = new Tempera(ConsoleColor.Blue, "Alba", 15);

            /*
            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine(Tempera.Mostrar(t2));
            Console.WriteLine(Tempera.Mostrar(t3));
            Console.WriteLine(Tempera.Mostrar(t4));
            Console.WriteLine(Tempera.Mostrar(t5));

            Console.WriteLine("<-------------------------------------------------->");

            Console.WriteLine(t1==t2);
            Console.WriteLine(t1==t3);
            Console.WriteLine(t1==t4);
            Console.WriteLine(t1==null);
            Console.WriteLine(null==t1);

            Console.WriteLine("<-------------------------------------------------->");

            Tempera sumaTemp = t1 + t2;
            if(sumaTemp is not null)
            {
                Console.WriteLine(Tempera.Mostrar(sumaTemp));
            }
            else
            {
                Console.WriteLine("No se sumaron");
            }

            sumaTemp = t1 + t3;
            if (sumaTemp is not null)
            {
                Console.WriteLine(Tempera.Mostrar(sumaTemp));
            }
            else
            {
                Console.WriteLine("No se sumaron");
            }

            sumaTemp = t1 + null;
            if (sumaTemp is not null)
            {
                
            }
            else
            {
                Console.WriteLine("No se sumaron");
            }

            Console.WriteLine();

            t1 += 20;
            Console.WriteLine(Tempera.Mostrar(t1));

            t2 += 30;
            Console.WriteLine(Tempera.Mostrar(t2));

            Console.WriteLine();
            Console.WriteLine("<---------------------------------------------->");
            Console.WriteLine();
            */

            Paleta paleta = 3;
            Console.WriteLine((string)paleta);
            Console.WriteLine();

            Console.WriteLine(paleta == t1);
            paleta += t1;
            Console.WriteLine(paleta == t1);
            Console.WriteLine();

            paleta += t2;
            paleta += t3;
            Console.WriteLine((string)paleta);
            paleta += t4;
            paleta += t5;
            paleta += t1;
            Console.WriteLine((string)paleta);
            paleta += t6;
            Console.WriteLine((string)paleta);
            Console.WriteLine("<---------------------------------------------------->");
            
            Console.WriteLine();
            paleta -= t1;
            paleta -= t1;
            paleta -= t6;
            paleta -= t5;
            Console.WriteLine((string)paleta);

            Paleta otraPaleta = 2;
            otraPaleta += t5;
            otraPaleta += t4;
            otraPaleta += t3;
            Console.WriteLine("<---------------------------------------------------->");
            Console.WriteLine((string)otraPaleta);
            Console.WriteLine();
            paleta += otraPaleta;
            Console.WriteLine((string)paleta);
            Console.WriteLine();
            

        }
    }
}
