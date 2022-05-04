using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g = new Grupo("Río");

            Perro p1 = new Perro("Moro","Pitbull");
            Perro p2 = new Perro("Julio", "Cruza", 13, false);
            Perro p3 = new Perro("Ramon", "Salchica", 2, true);
            Gato g1 = new Gato("Jose", "Angora");
            Gato g2 = new Gato("Hernán", "Cruza");
            Gato g3 = new Gato("Fer", "Siames");

            g += p1;
            g += p2;
            g += p3;
            g += g1;
            g += g2;
            g += g3;

            Console.WriteLine(g);
            Console.WriteLine("<------------------------------------------------------>");

            g += p1;
            g += g3;
            g -= g2;
            g -= p2;

            Console.WriteLine(g);
        }
    }
}
