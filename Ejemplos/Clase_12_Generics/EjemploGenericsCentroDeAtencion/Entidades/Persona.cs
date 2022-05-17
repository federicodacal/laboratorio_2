using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} - Apellido: {this.Apellido} - Dni: {this.Dni}";
        }
    }
}
