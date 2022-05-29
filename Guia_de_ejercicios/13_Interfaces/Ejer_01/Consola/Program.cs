using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();
            Console.WriteLine();

            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            try
            {
                cartucheraMultiuso.RecorrerElementos();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(cartucheraMultiuso);
            }

            Console.WriteLine();

            try
            {
                cartucheraMultiuso.RecorrerElementos();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(cartucheraMultiuso);
            }
        }
    }
}
