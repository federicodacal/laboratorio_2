using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_01
{
    public static class Archivo
    {

        static string path;

        static Archivo()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }

        public static void Escribir(string datos)
        {
            string nombreArchivo = path + "Archivos_01_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {

                    datos += "\nEjemplo numero 1";
                    sw.WriteLine("\n-----------------------------");
                    sw.WriteLine(datos);
                    sw.WriteLine("\nLa fecha es: ");
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine("\n-----------------------------");

                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static string Leer()
        {
            string informacionRecuperada = string.Empty;
            List<string> contenidoArchivos = new List<string>();
            try
            {

                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string item in archivosEnElPath)
                    {
                        if (item.Contains("Archivos_01"))
                        {
                            contenidoArchivos.Add(item);
                        }
                    }

                    if (contenidoArchivos is not null)
                    {

                        foreach (string item in contenidoArchivos)
                        {
                            if (File.Exists(item))
                            {
                                using (StreamReader sr = new StreamReader(item))
                                {
                                    string line;
                                    // Lee y muestra lineas desde el archivo hasta el fin del mismo.

                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        informacionRecuperada += "\n" + line;
                                    }
                                }
                            }                           
                        }                                               
                    }
                }
                return informacionRecuperada;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

    }
}
