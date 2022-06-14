using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private long dni;

        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string MostrarPersona()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre:");
            sb.AppendLine(this.nombre);
            sb.AppendFormat("Apellido: {0}", this.apellido);
            sb.AppendLine();
            sb.AppendFormat("Dni: {0:#,###}", this.dni);
            sb.AppendLine();

            return sb.ToString();
        }

    }
}
