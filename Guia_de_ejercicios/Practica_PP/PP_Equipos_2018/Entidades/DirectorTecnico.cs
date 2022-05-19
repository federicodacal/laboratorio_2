using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int aniosExp;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int aniosExp) 
            :base(nombre, apellido, edad, dni)
        {
            this.aniosExp = aniosExp;
        }

        public int AniosExp
        {
            get { return this.aniosExp; }
        }

        public override bool ValidarAptitud()
        {
            return this.Edad < 65 && this.AniosExp >= 2;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Experiencia: {this.AniosExp} años");

            return sb.ToString();
        }
    }
}
