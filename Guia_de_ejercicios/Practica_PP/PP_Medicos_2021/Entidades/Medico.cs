using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Personal
    {
        protected Especialidad especialidad;

        public Medico(string apellido, int legajo, DateTime ingreso, Especialidad especialidad)
            :base(apellido, legajo, ingreso)
        {
            this.especialidad = especialidad;
        }

        public Especialidad Especialidad
        {
            get { return this.especialidad; }
        }

        protected override string ArmarInfo()
        {
            return $"{base.ArmarInfo()}, especialiad: {this.Especialidad}";
        }

        public override string ToString()
        {
            return $"{this.ArmarInfo()} - ingreso {this.Ingreso.ToLongTimeString()}";
        }

        public override string Info
        {
            get { return this.ToString(); }
        }

    }
}
