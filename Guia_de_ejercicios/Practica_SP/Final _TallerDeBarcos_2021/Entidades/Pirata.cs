using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pirata : Barco
    {
        private static Random random;

        static Pirata()
        {
            random = new Random();
        }

        public Pirata()
        {

        }

        public Pirata(string nombre, EOperacion operacion)
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
                    this.tripulacion = random.Next(10, 30);
                    return this.tripulacion;
                }
            }
        }

        public override void CalcularCosto()
        {
            this.costo = random.Next(2000, 12000);
        }
    }
}
