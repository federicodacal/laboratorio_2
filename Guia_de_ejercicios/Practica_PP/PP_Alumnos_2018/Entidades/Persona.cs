using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Documento
        {
            get { return this.documento; }
            set 
            {
                if (this.ValidarDocumentracion(value))
                {
                    this.documento = value; 
                }
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"Nombre y Apellido: {this.Nombre} {this.Apellido}");
            sb.AppendLine($"Documento: {this.Documento}");

            return sb.ToString();
        }

        protected abstract bool ValidarDocumentracion(string doc);
    }
}
