using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {               
                Console.WriteLine("<---------------------ARCHIVOS------------------------------>");
                Console.WriteLine();
               
                GestorArchivoDeTexto gestor = new GestorArchivoDeTexto();

                gestor.Escribir("prueba1", "Mensaje Prueba 5", false);
                gestor.Escribir("prueba1", "Mensaje Prueba 6", true);

                Console.WriteLine("Ingresar mensaje");
                string mensaje = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de archivo txt");
                string archivo = Console.ReadLine();

                gestor.Escribir(archivo, mensaje, false);
                gestor.Escribir(archivo, "Otro Mensaje", true);

                Console.WriteLine();
                Console.WriteLine(gestor.Leer("prueba1"));
                Console.WriteLine();
                Console.WriteLine(gestor.Leer(archivo));            

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
