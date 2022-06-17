using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntidades
{
    #region #3.- Derivar de la Dll externa
    class PersonaExternaConMetodo : Entidades.Externa.Persona
    {
        public PersonaExternaConMetodo(string nombre, string apellido, int edad)
            :base(nombre, apellido, edad) { }

        public string ObtenerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(base.nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(base.apellido);
            sb.Append("Edad: ");
            sb.AppendLine(base.edad.ToString());

            return sb.ToString();
        }

    }
    #endregion
}
