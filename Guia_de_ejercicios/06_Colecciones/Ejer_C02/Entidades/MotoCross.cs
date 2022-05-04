using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool rta = false;
            if (m1 is not null && m2 is not null)
            {
                rta = (VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1.cilindrada == m2.cilindrada;
            }
            return rta;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        public string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - Cilindrada: {this.Cilindrada}";
        }
    }
}
