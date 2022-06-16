using System;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        #region #1.- Propiedades

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Edad { get { return this.edad; } }

        #endregion

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        #region #2.- Método

        public string ObtenerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(this.apellido);
            sb.Append("Edad: ");
            sb.AppendLine(this.edad.ToString());

            return sb.ToString();
        }

        #endregion

    }
}
