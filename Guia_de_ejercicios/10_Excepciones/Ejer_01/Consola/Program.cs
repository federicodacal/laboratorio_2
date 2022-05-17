using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            OtraClase o = new OtraClase();
            try
            {
                o.InstanciarMiClase();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}\n\n {e.StackTrace}");
            }
        }
    }
}
