using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private Colores color;
        private short cilindrada;
        private short cantidadMarchas;

        public Moto(short cantidadRuedas, Colores color, short cilindrada, short cantidadMarchas)
            :base(cantidadRuedas, color, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
        }

        public string Mostrar()
        {
            return base.Mostrar() + $" Cilindrada: {this.cilindrada}";
        }
 
    }
}
