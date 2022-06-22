using System;
using System.IO;
using System.Xml.Serialization;

///El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado con su apellido.nombre.zapato.xml
///Ejemplo: Alumno Juan Pérez -> perez.juan.zapato.xml
///Adaptar las clases que crea conveniente.

namespace EntidadesSP
{
    public class Zapato : Producto, ISerializa, IDeserializa
    {

        public Zapato()
        {

        }

        public Zapato(string marca, string tipo, int codigo, double precio) 
            :base(marca, tipo, codigo, precio)
        {
        }

        public string Path { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "zapato.xml"); } }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Xml()
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(this.Path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Zapato));
                    xs.Serialize(sw, this);
                    rta = true;
                }
                return rta;
            }
            catch
            {
                throw;
            }
        }

        bool IDeserializa.Xml(out Zapato zapato)
        {
            bool rta = false;
            try
            {
                using (StreamReader sr = new StreamReader(this.Path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Zapato));
                    zapato = xs.Deserialize(sr) as Zapato;
                    rta = true;
                }
                return rta;
            }
            catch
            {
                throw;
            }

        }
    }
}
