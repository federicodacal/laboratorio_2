using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza)
            :this(nombre, raza, 0, false)
        {

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            :base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public bool EsAlfa
        {
            get { return this.esAlfa; }
            set { this.esAlfa = value; }
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.DatosCompletos());

            if(this.EsAlfa)
            {
                sb.Append(", alfa de la manada");
            }
            sb.Append($", edad {this.Edad}");

            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool rta = false;
            if(p1 is not null && p2 is not null)
            {
                rta = p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.Edad == p2.Edad;
            }
            return rta;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            Perro otroPerro = obj as Perro;
            return otroPerro is not null && this == otroPerro;
        }
    }
}
