using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

///Pintura-> hereda de Articulo
///atributo protegido: color : string
///propiedad pública de lectura y escritura
///ToString():string (polimorfismo; reutilizar código) (mostrar TODOS los valores).

///En la clase Pintura, implementar:
///implícitamente: PathJson, Xml(out T) y Json()
///explícitamente: PathXml, Xml() y Json(out T)
///El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado con: apellido.nombre.tomate.xml
///Ejemplo: Alumno Juan Pérez -> perez.juan.tomate.xml
///El archivo .json guardarlo en la carpeta 'Mis documentos' del cliente, con el nombre formado con: apellido.nombre.pintura.json
///Ejemplo: Alumno Juan Pérez -> perez.juan.pintura.json


namespace EntidadesSP
{
    public class Pintura : Articulo, ISerializa, IDeserializa<Pintura>
    {        
        protected string color;

        public Pintura()
        {

        }

        public Pintura(string color,  string marca, int codigo, double precio)
            :base(marca, codigo, precio)
        {
            this.color = color;
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            return $"Color {this.Color} - {base.ToString()}";
        }

        [JsonIgnore]
        public string PathJson
        { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dacal.federico.pintura.json"); } }

        string ISerializa.PathXml
        { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dacal.federico.pintura.xml"); } }

        bool IDeserializa<Pintura>.Json(out Pintura pintura)
        {
            bool rta = false;
            pintura = null;
            try
            {
                using (StreamReader sr = new StreamReader(this.PathJson))
                {
                    string json = sr.ReadToEnd();
                    pintura = JsonSerializer.Deserialize<Pintura>(json);
                    rta = true;
                }
                return rta;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema al deserializar json: {ex.Message}");
            }
        }

        bool ISerializa.Xml()
        {
            bool rta = false;
            try
            {

                using (StreamWriter sw = new StreamWriter(((ISerializa)this).PathXml))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Pintura));
                    xs.Serialize(sw, this);
                    rta = true;
                }
                return rta;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema al serializar xml: {ex.Message}");
            }
        }

        public bool Xml(out Pintura pintura)
        {
            bool rta = false;
            pintura = null;
            try
            {
                using (StreamReader sr = new StreamReader(((ISerializa)this).PathXml))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Pintura));
                    pintura = xs.Deserialize(sr) as Pintura;
                    rta = true;
                }
                return rta;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema al deserializar xml: {ex.Message}");
            }
        }

        public bool Json()
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(this.PathJson))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string ser = JsonSerializer.Serialize(this, this.GetType(), options);
                    sw.WriteLine(ser);
                    rta = true;
                }
                return rta;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema al serializar json: {ex.Message}");
            }
        }
    }
}
