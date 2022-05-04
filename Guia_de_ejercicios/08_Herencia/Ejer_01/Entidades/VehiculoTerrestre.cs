using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private Colores color;
        private short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }
        public string Mostrar()
        {
            return $"Ruedas: {this.cantidadRuedas} - Marchas: {this.cantidadMarchas} - Color: {this.color}";
        }
    }
}
