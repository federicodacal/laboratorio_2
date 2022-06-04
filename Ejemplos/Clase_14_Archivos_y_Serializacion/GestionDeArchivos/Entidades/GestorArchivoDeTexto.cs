using System;
using System.IO;

namespace Entidades
{
    public class GestorArchivoDeTexto : IArchivo<string> 
    {
        private static string rutaBase;

        static GestorArchivoDeTexto()
        {
            GestorArchivoDeTexto.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public bool Escribir(string path, string data, bool append)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(GestorArchivoDeTexto.rutaBase, $"{path}.txt"), append))
                {
                    sw.WriteLine(data);
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return rta;
        }     

        public string Leer(string path)
        {
            string data = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(GestorArchivoDeTexto.rutaBase, $"{path}.txt")))
                {
                    data = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return data;
        }

    }
}
