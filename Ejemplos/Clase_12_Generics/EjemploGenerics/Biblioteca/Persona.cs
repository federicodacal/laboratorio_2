using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private string dni;

        public Persona(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public override string ToString()
        {
            return $"{this.nombre}, DNI: {this.dni}";
        }
    }
}
