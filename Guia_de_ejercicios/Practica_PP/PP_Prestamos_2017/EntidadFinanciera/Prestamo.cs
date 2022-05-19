using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }

        public float Monto
        {
            get { return this.monto; }
        }

        public DateTime Vencimiento
        {
            get { return this.vencimiento; }
            set
            {
                if(value < DateTime.Now)
                {
                    this.vencimiento = DateTime.Now;
                }
                else
                {
                    this.vencimiento = value;
                }
            }
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int orden = 0;
            if(p1.Vencimiento > p2.Vencimiento)
            {
                orden = 1;
            }
            else if(p1.Vencimiento < p2.Vencimiento)
            {
                orden = -1;
            }
            return orden;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"Monto: ${this.Monto}");
            sb.AppendLine($"Vencimiento: {this.Vencimiento.ToLongDateString()}");

            return sb.ToString();
        }

    }
}
