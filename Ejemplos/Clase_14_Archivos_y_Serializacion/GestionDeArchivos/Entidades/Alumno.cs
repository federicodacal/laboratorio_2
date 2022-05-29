using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private List<string> materias;

        public Alumno()
        {

        }

        public Alumno(string nombre, DateTime fechaNacimiento) 
            :base(nombre, fechaNacimiento)
        {
            this.materias = new List<string>();
        }

        public List<string> Materias { get => this.materias; set => this.materias = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Lista Materias: ");
            foreach (string item in this.Materias)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
