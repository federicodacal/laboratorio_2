using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Marina : Barco
    {
        private static Random random;

        static Marina()
        {
            random = new Random();
        }

        public Marina()
        {

        }

        public Marina(string nombre, EOperacion operacion)
            :base(nombre, operacion)
        {

        }

        public override int Tripulacion
        {
            get
            {
                if(this.tripulacion > 0)
                {
                    return this.tripulacion;
                }
                else
                {
                    this.tripulacion = random.Next(30, 60);
                    return this.tripulacion;
                }
            }
        }

        public override void CalcularCosto()
        {
            this.costo = random.Next(5000, 25000);
        }
    }
}
