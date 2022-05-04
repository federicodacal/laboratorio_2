using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre)
            :base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            :this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha Nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico t1, DirectorTecnico t2)
        {
            bool rta = false;
            if(t1 is not null & t2 is not null)
            {
                rta = t1.Nombre == t2.Nombre && t1.fechaNacimiento == t2.fechaNacimiento;
            }
            return rta;
        }

        public static bool operator !=(DirectorTecnico t1, DirectorTecnico t2)
        {
            return !(t1 == t2);
        }

    }
}
