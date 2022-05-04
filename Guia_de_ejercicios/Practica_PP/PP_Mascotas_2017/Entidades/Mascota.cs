using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Raza
        {
            get { return this.raza; }
        }

        protected abstract string Ficha();
        
        protected virtual string DatosCompletos()
        {
            return String.Format(this.Nombre + " " + this.Raza);
        }
    }
}
