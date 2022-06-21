using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Excepciones;

namespace Files
{
    public static class JsonManager<T>
    {
        private static string file;

        static JsonManager()
        {
            JsonManager<T>.file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CentroDeAtencion.json");
        }

        public static void Guardar(T elemento)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(JsonManager<T>.file))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string ser = JsonSerializer.Serialize(elemento, elemento.GetType(), options);
                    sw.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {
                throw new FilesException($"Error al serializar Json {ex.Message}", ex);
            }
        }

        public static void Guardar(string file, T elemento)
        {
            JsonManager<T>.file = file;
            JsonManager<T>.Guardar(elemento);
        }
    }
}
