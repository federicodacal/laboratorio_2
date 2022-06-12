using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        private static string ruta;

        static Provincial()
        {
            DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Llamadas_Provincial"));

            Provincial.ruta = info.FullName;
        }

        public Provincial()
        {

        }

        public Provincial(Franja franja, Llamada llamada)
            :this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja franja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = franja;
        }

        public Franja FranjaHoraria
        {
            get { return this.franjaHoraria; }
            set { this.franjaHoraria = value; }
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
                return Provincial.ruta;
            }
            set
            {
                throw new NotImplementedException();
            }

        }

        private float CalcularCosto()
        {
            float costo = -1;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                costo = this.Duracion * 0.99F;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                costo = this.Duracion * 1.25F;
            }
            else if (this.franjaHoraria == Franja.Franja_3)
            {
                costo = this.Duracion * 0.66F;
            }
            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            bool rta = false;
            string dateTime = DateTime.Now.ToString("HH_mm_ss");

            using (StreamWriter sw = new StreamWriter(Path.Combine(this.RutaDeArchivo, $"provincial_{dateTime}.xml")))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                serializer.Serialize(sw, this);
            }

            return rta;
        }

        public Provincial Leer()
        {
            Provincial contenido = null;

            using (StreamReader sr = new StreamReader(this.RutaDeArchivo))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Provincial));
                if (sr.GetType() == typeof(Provincial))
                {
                    contenido = xs.Deserialize(sr) as Provincial;
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
