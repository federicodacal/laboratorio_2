using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza)
            :base(nombre, raza)
        {

        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool rta = false;
            if(g1 is not null && g2 is not null)
            {
                rta = g1.Nombre == g2.Nombre && g1.Raza == g2.Raza;
            }
            return rta;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            Gato otroGato = obj as Gato;
            return otroGato is not null && this == otroGato;
        }
    }
}
