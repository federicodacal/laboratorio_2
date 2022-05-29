using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private decimal sueldo;
        private List<string> divisiones;

        public Profesor()
        {

        }

        public Profesor(string nombre, DateTime fechaNacimiento, decimal sueldo):base(nombre, fechaNacimiento)
        {
            this.sueldo = sueldo;
            this.divisiones = new List<string>();
        }

        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public List<string> Divisiones { get => divisiones; set => divisiones = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Sueldo: ${this.Sueldo}");
            sb.AppendLine("Lista Divisiones: ");
            foreach (string item in this.Divisiones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
