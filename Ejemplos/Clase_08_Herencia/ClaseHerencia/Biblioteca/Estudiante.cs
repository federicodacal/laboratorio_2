using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante : Persona
    {
        public int legajo;
        public List<string> materias;

        public Estudiante(Persona persona, int legajo)
            :base(persona.Nombre,persona.Apellido,persona.Dni)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }

        public Estudiante(string nombre, string apellido, long dni, int legajo, List<string> materias)
            :this(new Persona(nombre,apellido,dni), legajo)
        {
            this.materias = materias;
        }

        public string Estudiar()
        {
            return "Estoy estudiando...";
        }

        public string MostrarEstudiante()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarPersona()} \nLegajo: {this.legajo}");
            if(this.materias.Count > 0)
            {
                sb.AppendLine("Materias: ");
                foreach (string item in this.materias)
                {
                    sb.AppendLine(item);
                }
            }
            else
            {
                    sb.AppendLine("No se encuentra cursando");
            }
            return sb.ToString();
        }
    }
}
