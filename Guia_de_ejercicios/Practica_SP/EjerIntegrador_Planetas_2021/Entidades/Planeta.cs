using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Planeta : ISerializable
    {
        public delegate void DelegadoPlaneta(Planeta sender, double gravedad);

        private int id;
        private string nombre;
        private int satelites;
        private double gravedad;

        public event DelegadoPlaneta MuchaGravedad;

        public Planeta()
        {

        }

        public Planeta(string nombre, int satelites, double gravedad)
        {
            this.nombre = nombre;
            this.satelites = satelites;
            this.gravedad = gravedad;
        }

        public Planeta(int id, string nombre, int satelites, double gravedad)
            :this(nombre, satelites, gravedad)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Satelites { get => satelites; set => satelites = value; }
        public double Gravedad 
        { 
            get => gravedad; 
            set
            {
                if(value > 30)
                {
                    if(this.MuchaGravedad != null)
                    {
                        this.gravedad = value;
                        this.MuchaGravedad.Invoke(this, value);
                    }
                }
                else
                {
                    this.gravedad = value;
                }
            }
        }

        public string Path
        {
            get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "integradorPlanetas"); }
        }

        public string DeserializarXml()
        {
            try
            {
                using (StreamReader sr = new StreamReader(System.IO.Path.Combine(this.Path, "planetaXml.xml")))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Planeta));
                    Planeta objeto = xs.Deserialize(sr) as Planeta;
                    return objeto.ToString();
                }
            }
            catch
            {
                throw;
            }
        }

        public bool SerializarXml()
        {
            bool rta = false;
            try
            {
                if (!Directory.Exists(this.Path))
                {
                    Directory.CreateDirectory(this.Path);
                }

                using (StreamWriter sw = new StreamWriter(System.IO.Path.Combine(this.Path, "planetaXml.xml")))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Planeta));
                    xs.Serialize(sw, this);
                    rta = true;
                }
            }
            catch
            {
                throw;
            }
            return rta;
        }

        public override string ToString()
        {
            return $"PLANETA {this.Nombre} | ID: {this.Id} - Satelites: {this.Satelites} - Gravedad {this.Gravedad}";
        }
    }
}
