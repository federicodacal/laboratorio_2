using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {

        private DateTime fechaIngreso;
        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        { 

        }

        public Profesor(string nombre, string apellido, string documento, DateTime ingreso)
            :this(nombre, apellido, documento)
        {
            this.fechaIngreso = ingreso;
        }

        public int Antiguedad
        {
            get { return (int)(DateTime.Today - this.fechaIngreso).TotalDays; }
        }

        protected override bool ValidarDocumentracion(string doc)
        {
            bool rta = false;
            if(doc is not null)
            {
                if(doc.Trim().Length == 8)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ExponerDatos());
            sb.AppendLine($"Antiguedad: {this.Antiguedad} dias");

            return sb.ToString();
        }
    }
}
