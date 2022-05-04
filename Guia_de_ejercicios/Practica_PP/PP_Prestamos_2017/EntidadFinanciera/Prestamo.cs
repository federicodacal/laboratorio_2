using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
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


    }
}
