using System;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Program.EscribirArchivoTextoConStreamWriterConFinally();
                //Program.LeerArchivoConStreamReaderConFinally();
                //Program.EscribirArchivoConStreamWriterConUsing();
                //Program.LeerArchivoConStreamReaderConUsing();
                //Program.EscribirArchivoTextoConFile();
                Program.LeerArchivoTextoConFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void EscribirArchivoTextoConStreamWriterConFinally()
        {
            StreamWriter sw = null;
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Archivos");

                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                ruta = Path.Combine(ruta, "HolaMundo.txt");
                sw = new StreamWriter(ruta);

                sw.WriteLine("Hola!");
                sw.Write("Chau!");
            }
            finally
            {
                if(sw is not null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        static void LeerArchivoConStreamReaderConFinally()
        {
            StreamReader sr = null;
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Archivos", "HolaMundo.txt");

                sr = new StreamReader(ruta);
                string texto = sr.ReadToEnd();

                Console.WriteLine("Con ReadToEnd");
                Console.WriteLine(texto);
                Console.WriteLine();

                sr = new StreamReader(ruta);
                Console.WriteLine("Con ReadLine");
                while (!sr.EndOfStream)
                {
                    string lineaDeTexto = sr.ReadLine();
                    Console.WriteLine(lineaDeTexto);
                }

            }
            finally
            {
                if (sr is not null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }

        static void EscribirArchivoConStreamWriterConUsing()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Archivos");

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            ruta = Path.Combine(ruta, "HolaMundo.txt");

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Laboratorio II");
                sw.WriteLine("Mundo");
                sw.Write("2do Cuatrimestre");
            }
        }

        static void LeerArchivoConStreamReaderConUsing()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Archivos", "HolaMundo.txt");

            using (StreamReader sr = new StreamReader(ruta))
            {
                string texto = sr.ReadToEnd();
                Console.WriteLine(texto);        
            }
        }

        static void EscribirArchivoTextoConFile()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Archivos", "HolaMundo.txt");

            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }

            File.WriteAllText(ruta, "Hola a todo el Mundo!");
            File.AppendAllText(ruta, $"{Environment.NewLine}C#");
        }

        static void LeerArchivoTextoConFile()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Archivos", "HolaMundo.txt");

            if (File.Exists(ruta))
            {
                string texto = File.ReadAllText(ruta);
                Console.WriteLine(texto);
            }
        }
    }
}
