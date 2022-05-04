using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }

        public override double CalcularPerimetro()
        {
            return (this.longitudAltura + this.longitudBase) * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.longitudAltura * this.longitudBase;
        }

        public override string Dibujar()
        {
            return "Dibujando rectángulo";
        }
    }
}
