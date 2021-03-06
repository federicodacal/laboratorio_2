using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bateria : Instrumento
    {
        private int cuerpos;

        public Bateria(int codigo, string marca, EClasificacion clasificacion, int cuerpos)
            :base(codigo, marca, clasificacion)
        {
            this.cuerpos = cuerpos;
        }

        protected override string Mostrar()
        { 
            return base.Mostrar() + $"\nCuerpos: {this.cuerpos}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        /*
        public override bool Equals(object obj)
        {
            Bateria unaBateria = obj as Bateria;
            return unaBateria is not null && this == unaBateria;
        }
        */
    }
}
