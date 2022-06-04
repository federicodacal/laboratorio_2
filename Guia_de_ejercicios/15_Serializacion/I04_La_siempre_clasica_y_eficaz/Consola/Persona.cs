using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Consola
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        
        public static string Ruta
        {
            get
            {
                DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "serializacion"));

                return info.FullName;
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void GuardarXml(Persona p)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Persona.Ruta, "personaXml.xml")))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Persona));

                xs.Serialize(sw, p);
            }
        }

        public static Persona LeerXml(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Persona));

                Persona p = xs.Deserialize(sr) as Persona;

                return p;
            }
        }

        public static void GuardarJson(Persona p)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Persona.Ruta, "personaJson.json")))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                string ser = JsonSerializer.Serialize(p, options);
                sw.WriteLine(ser);
            }
        }

        public static Persona LeerJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();

                Persona p = JsonSerializer.Deserialize<Persona>(json);

                return p;
            }
        }

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }
    }
}
