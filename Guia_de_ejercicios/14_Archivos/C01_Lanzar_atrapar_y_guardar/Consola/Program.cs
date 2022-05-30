using System;
using System.IO;
using Entidades;
using IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = String.Empty; 

            OtraClase o = new OtraClase();
            try
            {
                o.InstanciarMiClase();
            }
            catch (Exception e)
            {
                //Console.WriteLine($"{e.Message}\n\n {e.StackTrace}");
                fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), DateTime.Now.ToString("yyyyMMdd-hhmm") + ".txt");

                ArchivoTexto.Guardar(fileName, $"{e.Message}{Environment.NewLine}{e.StackTrace}");
            }

            try
            {
                string texto = ArchivoTexto.Leer(fileName);
                Console.WriteLine(texto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
