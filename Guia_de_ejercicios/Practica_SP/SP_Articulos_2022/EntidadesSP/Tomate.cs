using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

///Tomate->hereda de Articulo 
///atributo público: tipo : string
///ToString():string (polimorfismo; reutilizar código) (mostrar TODOS los valores).

///Implementar ISerializa e IDeserializa en Tomate y Pintura
///En la clase Tomate, implementar:
///implícitamente: PathXml, Xml() y Json(out T)
///explícitamente: PathJson, Xml(out T) y Json()


namespace EntidadesSP
{
    public class Tomate : Articulo, ISerializa, IDeserializa<Tomate>
    {
        private string tipo;

        public Tomate()
        {

        }

        public Tomate(string tipo, string marca, int codigo, double precio)
            :base(marca, codigo, precio)
        {
            this.tipo = tipo;
        }

        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return $"Tipo {this.Tipo} - {base.ToString()}";
        }

        ///implícitamente: PathXml, Xml() y Json(out T)
        ///explícitamente: PathJson, Xml(out T) y Json()

        public string PathXml
        { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dacal.federico.tomate.xml"); } }

        string ISerializa.PathJson
        { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dacal.federico.tomate.json"); } }

        public bool Xml()
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(this.PathXml))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Tomate));
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

        public bool Json(out Tomate tomate)
        {
            bool rta = false;
            tomate = null;
            try
            {
                using (StreamWriter sw = new StreamWriter(((ISerializa)this).PathJson))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string ser = JsonSerializer.Serialize(tomate, tomate.GetType(), options);
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

        bool ISerializa.Json()
        {
            bool rta = false;
            try
            {
                using (StreamReader sr = new StreamReader(((ISerializa)this).PathJson))
                {
                    string json = sr.ReadToEnd();
                    Tomate tomate = JsonSerializer.Deserialize<Tomate>(json);
                    rta = true;
                }
                return rta;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema al deserializar json: {ex.Message}");
            }
        }

        bool IDeserializa<Tomate>.Xml(out Tomate tomate)
        {
            bool rta = false;
            tomate = null;
            try
            {
                using (StreamReader sr = new StreamReader(this.PathXml))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Tomate));
                    tomate = xs.Deserialize(sr) as Tomate;
                    rta = true;
                }
                return rta;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema al deserializar xml: {ex.Message}");
            }
        }
       
    }
}
