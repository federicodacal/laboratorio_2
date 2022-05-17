using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Nombre { get; set; }
        public float Peso { get; set; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} - Especie: {this.Especie} - Raza: {this.Raza} - Peso {this.Peso}kgs";
        }
    }
}
