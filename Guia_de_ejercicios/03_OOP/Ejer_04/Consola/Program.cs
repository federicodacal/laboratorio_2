using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo = "";
            Boligrafo b1 = new Boligrafo(ConsoleColor.Red);
            Boligrafo b2 = new Boligrafo(ConsoleColor.DarkCyan);
            Boligrafo b3 = new Boligrafo(ConsoleColor.Green, 4);

            Console.WriteLine(b1.Mostrar());
            Console.WriteLine(b2.Mostrar());
            Console.WriteLine(b3.Mostrar());

            if(b1.Pintar(2,out dibujo))
            {
                b1.PintarDibujoEnConsola(dibujo);
            }
            else
            {
                Console.WriteLine("No se pudo pintar");
            }

            if (b2.Pintar(8, out dibujo))
            {
                b2.PintarDibujoEnConsola(dibujo);
            }
            else
            {
                Console.WriteLine("No se pudo pintar");
            }

            if (b3.Pintar(5, out dibujo))
            {
                b3.PintarDibujoEnConsola(dibujo);
            }
            else
            {
                Console.WriteLine("No se pudo pintar");
            }


        }
    }
}
