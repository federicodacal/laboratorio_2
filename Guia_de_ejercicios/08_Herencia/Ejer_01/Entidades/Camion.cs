using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            :base(cantidadRuedas, color, cantidadMarchas)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.pesoCarga = pesoCarga;
        }

        public string Mostrar()
        {
            return base.Mostrar() + $" Cantidad Puertas: {this.cantidadPuertas} - Peso Carga: {this.pesoCarga}";
        }
    }
}
