using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase miClase = new MiClase("Hola");

            Console.WriteLine(miClase.Mensaje);

            Console.ReadKey();

            try
            {
                miClase.Mensaje = "      ";
            }
            catch(MensajeInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(miClase.Mensaje);
            Console.WriteLine();
            Console.WriteLine("<----------------------------------------->");
            Console.WriteLine();

            Console.ReadKey();

            try
            {
                ClaseEstatica.MiMetodoEstatico("     ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Mensaje de la InnerException: {ex.InnerException.Message}.");
                Console.WriteLine($"StackTrace: \n{ex.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine("<----------------------------------------->");
            Console.WriteLine();

            Console.ReadKey();

            try
            {
                ClaseEstatica.MiOtroMetodoEstatico("     ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Exception inner = ex.InnerException;
                while(inner is not null)
                {
                    Console.WriteLine(inner.Message);
                    inner = inner.InnerException; // Voy recorriendo las inner
                }
            }

        }
    }
}
