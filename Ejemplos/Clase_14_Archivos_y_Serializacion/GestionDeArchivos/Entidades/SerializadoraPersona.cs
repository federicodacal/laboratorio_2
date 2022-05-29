using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Entidades
{
    public class SerializadoraPersona<T>
        where T : Persona
    {
        private static string rutaBase;

        static SerializadoraPersona()
        {
            DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos_Serializados"));
            SerializadoraPersona<T>.rutaBase = info.FullName;
        }

        public static void SerializarPersona_StreamWriter(string nombreArchivo, T persona)
        {
            using (StreamWriter sw = new StreamWriter(@$"{SerializadoraPersona<T>.rutaBase}\{nombreArchivo}"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                xs.Serialize(sw, persona);
            }
        }

        public static void SerializarPersona_XmlTextWriter(string nombreArchivo, T persona)
        {
            using (XmlTextWriter tw = new XmlTextWriter(@$"{SerializadoraPersona<T>.rutaBase}\{nombreArchivo}", Encoding.UTF8)) 
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                tw.Formatting = Formatting.Indented;

                xs.Serialize(tw, persona);
            }
        }

        public static Persona DeserializarPersona_StreamReader(string nombreArchivo)
        {
            Persona persona = null;
            using (StreamReader sr = new StreamReader(@$"{SerializadoraPersona<T>.rutaBase}\{nombreArchivo}"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                persona = xs.Deserialize(sr) as T;
            }
            return persona;
        }

        public static Persona DeserializarPersona_TextReader(string nombreArchivo)
        {
            Persona persona = null;
            using (XmlTextReader tr = new XmlTextReader(@$"{SerializadoraPersona<T>.rutaBase}\{nombreArchivo}"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                persona = xs.Deserialize(tr) as T;
            }
            return persona;
        }

        public static void Serializar_JSON(string nombreArchivo, T persona)
        {
            using (StreamWriter sw = new StreamWriter(@$"{SerializadoraPersona<T>.rutaBase}\{nombreArchivo}"))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                string ser = JsonSerializer.Serialize(persona, options);
                sw.WriteLine(ser);
            }
        }

        public static T Deserializar_JSON(string nombreArchivo)
        {
            T persona = null;
            using (StreamReader sr = new StreamReader(@$"{SerializadoraPersona<T>.rutaBase}\{nombreArchivo}"))
            {
                string json = sr.ReadToEnd();
                persona = JsonSerializer.Deserialize<T>(json);
            }
            return persona;
        }

    }
}
