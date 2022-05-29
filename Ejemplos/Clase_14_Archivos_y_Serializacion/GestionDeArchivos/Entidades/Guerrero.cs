using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guerrero : Personaje
    {
        private int fuerza;
        public Guerrero()
        {

        }

        public Guerrero(int puntosDeVida, string nombre, int fuerza) 
            :base(puntosDeVida, nombre)
        {
            this.fuerza = fuerza;
        }

        public int Fuerza { get => fuerza; set => fuerza = value; }

        public override string ToString()
        {
            return $"{base.ToString()} | Fuerza: {this.Fuerza}";
        }
    }
}
