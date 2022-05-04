using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EPelaje { SinPelo, Corto, Mediano, Largo }
    public class Mamifero : Animal
    {
        private EPelaje pelaje;

        public Mamifero(string nombre, float peso, EPelaje pelaje)
            :base(nombre, peso)
        {
            this.pelaje = pelaje;
        }

        public decimal PrecioCortePelo
        {
            get
            {
                decimal precio = 0;
                switch (this.pelaje)
                {
                    case EPelaje.SinPelo:
                        precio = 0;
                        break;
                    case EPelaje.Corto:
                        precio = 150;
                        break;
                    case EPelaje.Mediano:
                        precio = 250;
                        break;
                    case EPelaje.Largo:
                        precio = 500;
                        break;
                }
                return precio;
            }
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $"Precio Corte: {this.PrecioCortePelo}";
        }

        public override string Alimentarse()
        {
            return "Me alimento...";
        }
    }
}
