using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoJson<T> : Archivo, IArchivo<T>
        where T : class
    {
        protected override string Extension
        {
            get { return ".json"; }
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
                string json = JsonSerializer.Serialize(contenido);
                sw.WriteLine(json);
            }
        }

        public T Leer(string ruta)
        {
            T contenido = null;

            if(this.ValidarSiExisteArchivo(ruta) && this.ValidarExtension(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string json = sr.ReadToEnd();
                    contenido = JsonSerializer.Deserialize<T>(json);
                }
            }

            return contenido;
        }
    }
}
