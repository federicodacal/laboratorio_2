using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoLocoForm
{
    public static class Archivador
    {
        public static void SaveTxt(string path, string fileName, string text, bool append)
        {
            if (!Directory.Exists(path))
            {
                throw new Exception($"No se encontró el Directorio {path}");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, $"{fileName}.txt"), append))
                {
                    sw.WriteLine(text);
                }
            }
        }

        public static string ReadTxt(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"No se encontró el archivo en la ruta {path}");
            }
            else
            {
                string data = String.Empty;

                using (StreamReader sr = new StreamReader(path))
                {
                    data = sr.ReadToEnd();
                }

                return data;
            }
        }
    }
}
