using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedicoEgresado : Medico
    {

        protected DateTime horarioSalida;

        public MedicoEgresado(Medico medico)
            :base(medico.Apellido, medico.Legajo, medico.Ingreso, medico.Especialidad)
        {
            this.horarioSalida = DateTime.Now;
        }

        public double Jornal
        {
            get { return this.CalcularJornal(); }
        }

        public DateTime Egreso
        {
            get { return this.horarioSalida; }
        }

        public override string Info
        {
            get { return this.ToString(); }
        }

        private double CalcularJornal()
        {
            double jornal = 0;
            TimeSpan diferencia = this.Egreso - this.Ingreso;
            double horas = diferencia.TotalHours;

            if (this.Especialidad == Especialidad.Cirujano)
            {
                jornal = horas * 90;
            }
            else if(this.Especialidad == Especialidad.Clinico)
            {
                jornal = horas * 70;
            }
            else if(this.Especialidad == Especialidad.Pediatra)
            {
                jornal = horas * 40;
            }
            return jornal;
        }

        protected override string ArmarInfo()
        {
            return $"DOCTOR - {base.ArmarInfo()} - JORNAL: ${String.Format("{0:00.0}",this.Jornal)}";
        }

        public override string ToString()
        {
            return $"{this.ArmarInfo()} - ingreso {this.Ingreso.ToLongTimeString()} - egreso {this.Ingreso.ToLongTimeString()}";
        }

    }
}
