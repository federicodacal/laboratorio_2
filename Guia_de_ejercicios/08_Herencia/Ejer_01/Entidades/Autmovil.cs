using System;

namespace Entidades
{
    public class Autmovil : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Autmovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            :base(cantidadRuedas, color, cantidadMarchas)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string Mostrar()
        {
            return base.Mostrar() + $" Cantidad Puertas: {this.cantidadPuertas} - Cantidad Pasajeros: {this.cantidadPasajeros}";
        }
    }
}
