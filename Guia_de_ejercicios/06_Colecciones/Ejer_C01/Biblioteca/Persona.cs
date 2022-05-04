using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(long dni, string nombre)
            : this(nombre)
        {
            this.dni = dni;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public long Dni
        {
            get { return this.dni; }
            set
            {
                if (value > 0)
                {
                    this.dni = value;
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.dni.ToString());
            return sb.ToString();
        }
    }
}
