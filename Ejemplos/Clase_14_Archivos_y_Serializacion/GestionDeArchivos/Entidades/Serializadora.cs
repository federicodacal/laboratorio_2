using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora<T>
        where T : class, new()
    {
        private static string rutaBase;

        static Serializadora()
        {
            DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos_Serializados"));
            Serializadora<T>.rutaBase = info.FullName;
        }

        public static void Serializar_StreamWriter(string nombreArchivo, T objeto)
        {
            using (StreamWriter sw = new StreamWriter(@$"{Serializadora<T>.rutaBase}\{nombreArchivo}"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                xs.Serialize(sw, objeto);
            }
        }

        public static void Serializar_XmlTextWriter(string nombreArchivo, T elemento)
        {
            using (XmlTextWriter tw = new XmlTextWriter(@$"{Serializadora<T>.rutaBase}\{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                tw.Formatting = Formatting.Indented;

                xs.Serialize(tw, elemento);
            }
        }

        public static T Deserializar_StreamReader(string nombreArchivo)
        {
            using (StreamReader sr = new StreamReader(@$"{Serializadora<T>.rutaBase}\{nombreArchivo}"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                T objeto = xs.Deserialize(sr) as T;

                return objeto;
            }
        }

        public static T Deserializar_TextReader(string nombreArchivo)
        {
            using (XmlTextReader tr = new XmlTextReader(@$"{Serializadora<T>.rutaBase}\{nombreArchivo}"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                T objeto = xs.Deserialize(tr) as T;

                return objeto;
            }
        }

        public static void Serializar_JSON(string nombreArchivo, T objeto)
        {
            using (StreamWriter sw = new StreamWriter(@$"{Serializadora<T>.rutaBase}\{nombreArchivo}"))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                string ser = JsonSerializer.Serialize(objeto, objeto.GetType(), options);
                sw.WriteLine(ser);
            }
        }

        public static T Deserializar_JSON(string nombreArchivo)
        {
            using (StreamReader sr = new StreamReader(@$"{Serializadora<T>.rutaBase}\{nombreArchivo}"))
            {
                string json = sr.ReadToEnd();

                T objeto = JsonSerializer.Deserialize<T>(json);

                return objeto;
            }
        }
    }
}
