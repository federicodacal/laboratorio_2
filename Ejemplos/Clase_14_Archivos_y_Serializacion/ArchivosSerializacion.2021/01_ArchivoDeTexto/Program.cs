using System;
using System.IO;

namespace _01_ArchivoDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Escritura de archivo

            string rutaDirectorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Prueba");

            string ruta = Path.Combine(rutaDirectorio, "Test.txt");

            try
            {
                if(!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }
                // Abro un archivo
                StreamWriter sw = new StreamWriter(ruta);
                // Escribo
                sw.WriteLine("Hola mundo!!!");
                // Cierro el archivo
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Escritura de archivo con bloque using

            try
            {
                //El bloque using asegura que el objeto invocará al método Dispose()
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.Write("Este es el ");
                    sw.WriteLine("encabezado para el archivo.");
                    sw.WriteLine("-----------------------------");

                    // Objetos arbitrarios tambien pueden ser escritos en el archivo.
                    sw.Write("LA FECHA ES: ");
                    sw.WriteLine(DateTime.Now);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Lectura de archivo

            try
            {
                // Crea una instancia de StreamReader para leer desde el archivo.
                using (StreamReader sr = new StreamReader(ruta))
                {
                    String linea;

                    // Lee y muestra líneas desde el comienzo del archivo 
                    // hasta el fin del mismo.
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Escritura con encoding y append

            // Encoding UTF 8
            System.Text.Encoding miCodificacion = System.Text.Encoding.UTF8;

            try
            {
                //Al colocar el parámetro append en false, se sobrescribe.
                //El "@" por fuera de las comillas nos permite no tener que usar "\\" (doble barra)
                // @"C:\Users\User\Desktop\Prueba"
                using (StreamWriter sw = new StreamWriter(ruta, false, miCodificacion))
                {
                    sw.WriteLine("-----------------------------");
                    sw.WriteLine("ARCHIVO SOBRESCRITO....");
                    sw.WriteLine("-----------------------------");
                }

                //Al colocar el parámetro append en true, agrego datos.
                using (StreamWriter sw = new StreamWriter(ruta, true, miCodificacion))
                {
                    sw.WriteLine("Línea agregada al archivo original...");
                }

                //con ReadToEnd, se lee el archivo completo
                using (StreamReader sr = new StreamReader(ruta, miCodificacion))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine("Línea agregada al archivo original...");
                }

                //con Read, se lee un sólo caracter
                using (StreamReader sr = new StreamReader(ruta))
                {
                    Console.WriteLine(sr.Read()); // Muestra codigo ASCII
                    Console.WriteLine(sr.Read()); // Muestra codigo ASCII
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            #endregion

            #region Métodos de la clase File

            try
            {
                string nuevaRutaDirectorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Prueba2");

                string nuevaRutaArchivo = Path.Combine(nuevaRutaDirectorio, "Test.txt");

                if (!File.Exists(nuevaRutaArchivo))
                {
                    if (!Directory.Exists(nuevaRutaDirectorio))
                    {
                        Directory.CreateDirectory(nuevaRutaDirectorio);
                    }
                    File.Copy(ruta, nuevaRutaArchivo);
                }
                else // Si existe, lo borro.
                {
                    File.Delete(ruta);
                }

                using (StreamReader sr = new StreamReader(nuevaRutaArchivo))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            #region Ejemplo

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                using (StreamWriter sw = new StreamWriter(escritorio + @"\miArchivo.txt", true))
                {
                    sw.WriteLine("Línea agregada al archivo...");
                }

                using (StreamReader sr = new StreamReader(escritorio + @"\miArchivo.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #endregion

        }
    }
}
