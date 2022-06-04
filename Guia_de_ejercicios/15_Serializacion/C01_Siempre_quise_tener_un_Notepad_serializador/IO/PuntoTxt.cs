using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (this.ValidarExtension(ruta) && this.ValidarSiExisteArchivo(ruta))
            {
                this.Escribir(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (this.ValidarExtension(ruta))
            {
                this.Escribir(ruta, contenido);
            }
        }

        private void Escribir(string ruta, string contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine(contenido);
            }
        }

        public string Leer(string ruta)
        {
            string contenido = String.Empty;

            if (this.ValidarExtension(ruta) && this.ValidarSiExisteArchivo(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenido = sr.ReadToEnd();
                }
            }

            return contenido;
        }
    }
}
