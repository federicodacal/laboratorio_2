using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;

        private static string ruta;

        static Local()
        {
            DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Llamadas_Local"));

            Local.ruta = info.FullName; 
        }

        public Local()
        {

        }

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public float Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        [XmlIgnore]
        public string RutaDeArchivo 
        {
            get
            {
                return Local.ruta;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            bool rta = false;
            string dateTime = DateTime.Now.ToString("HH_mm_ss");

            using (StreamWriter sw = new StreamWriter(Path.Combine(this.RutaDeArchivo, $"local_{dateTime}.xml")))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                serializer.Serialize(sw, this);
            }

            return rta;
        }

        public Local Leer()
        {
            Local contenido = null;

            using (StreamReader sr = new StreamReader(this.RutaDeArchivo))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Local));
                if(sr.GetType() == typeof(Local))
                {
                    contenido = xs.Deserialize(sr) as Local;
                }
                else
                {
                    throw new InvalidCastException("Invalid Cast");
                }
            }

            return contenido;
        }
    }
}
