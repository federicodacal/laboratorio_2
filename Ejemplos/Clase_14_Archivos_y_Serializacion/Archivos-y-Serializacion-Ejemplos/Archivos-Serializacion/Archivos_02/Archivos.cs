using System;
using System.Collections.Generic;
using System.IO;

namespace Archivos_02
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
            string nombreArchivo = path + "Archivos_02_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                datos += $"\nEjemplo numero 2 \n{DateTime.Now}\n\n";
                File.WriteAllText(nombreArchivo, datos);
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
                        if (item.Contains("Archivos_02"))
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
                                informacionRecuperada += File.ReadAllText(item);
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
