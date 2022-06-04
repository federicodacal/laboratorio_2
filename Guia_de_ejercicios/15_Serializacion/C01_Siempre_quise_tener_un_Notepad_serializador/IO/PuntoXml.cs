using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo, IArchivo<T>
        where T : class
    {
        protected override string Extension
        {
            get { return ".xml"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (this.ValidarExtension(ruta) && this.ValidarSiExisteArchivo(ruta))
            {
                this.Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (this.ValidarExtension(ruta))
            {
                this.Serializar(ruta, contenido);
            }
        }

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, contenido);
            }
        }

        public T Leer(string ruta)
        {
            T contenido = null;

            if (this.ValidarExtension(ruta) && this.ValidarSiExisteArchivo(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    contenido = xs.Deserialize(sr) as T;
                }
            }

            return contenido;
        }
    }
}
