using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periocidadDePagos;
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periocidadDePagos) 
            :base(monto, vencimiento)
        {
            this.periocidadDePagos = periocidadDePagos;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periocidad)
            :this(prestamo.Monto, prestamo.Vencimiento, periocidad)
        {

        }

        public PeriodicidadDePagos Periocidad
        {
            get { return this.periocidadDePagos; }
        }

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        private float CalcularInteres()
        {
            float porcentajeIntereses=0;

            if(this.Periocidad == PeriodicidadDePagos.Mensual)
            {
                porcentajeIntereses = this.Monto + (float)(this.Monto * 0.25);
            }
            else if (this.Periocidad == PeriodicidadDePagos.Bimestral)
            {
                porcentajeIntereses = this.Monto + (float)(this.Monto * 0.35);
            }
            else if (this.Periocidad == PeriodicidadDePagos.Trimestral)
            {
                porcentajeIntereses = this.Monto + (float)(this.Monto * 0.40);
            }
            return porcentajeIntereses;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = (int)(nuevoVencimiento - this.Vencimiento).TotalDays;
            this.monto += dias * 2.5F;
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Periocidad Pagos: {this.Periocidad}");
            sb.AppendLine($"Intereses: ${this.Interes}");

            return sb.ToString();
        }
    }
}
