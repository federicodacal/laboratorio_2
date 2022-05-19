using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeIntereses;

        public PrestamoPesos(float monto, DateTime vencimiento, float intereses) 
            :base(monto, vencimiento)
        {
            this.porcentajeIntereses = intereses;
        }

        public PrestamoPesos(Prestamo prestamo, float intereses)
            :this(prestamo.Monto, prestamo.Vencimiento, intereses)
        {

        }

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        private float CalcularInteres()
        {
            return this.Monto + (float)(this.Monto * this.porcentajeIntereses);
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = (int)(nuevoVencimiento - this.Vencimiento).TotalDays;
            this.monto += dias * (this.Monto * 0.0025F);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Porcentaje Intereses: {this.porcentajeIntereses}%");
            sb.AppendLine($"Intereses: ${this.Interes}");

            return sb.ToString();
        }

    }
}
