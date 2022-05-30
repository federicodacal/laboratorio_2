using System;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text);
            }
        }

        public static string Leer(string path)
        {
            string texto = String.Empty;

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    texto = sr.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }

            return texto;
        }
    }
}
