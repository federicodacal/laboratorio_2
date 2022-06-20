using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : ISerializableJson
    {
        private int id;
        private string nombre;
        private int edad;

        public Usuario()
        {

        }

        public Usuario(int id, string nombre, int edad):this(nombre, edad)
        {
            this.id = id;
        }

        public Usuario(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public bool Serializar(string path)
        {
            bool rta = true;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = Path.Combine(path, $"{DateTime.Now.ToString("HH_mm_ss")}.json");
                using (StreamWriter sw = new StreamWriter(path))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string ser = JsonSerializer.Serialize(this, this.GetType(), options);
                    sw.WriteLine(ser);
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un problema realizando la serialización json", e);
            }
            return rta;
        }

        public bool Deserializar(string path, out Usuario objeto)
        {
            bool rta = false;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    objeto = JsonSerializer.Deserialize<Usuario>(json);
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Hubo un problema realizando la deserialización json {e.Message}", e);
            }
            return rta;
        }

        public override string ToString()
        {
            return $"{this.Id} | {this.Nombre} tiene {this.Edad}";
        }

    }
}
