using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        public Biografia(string nombre):this(nombre, 0)
        {
        }

        public Biografia(string nombre, int stock):this(nombre, stock, 0)
        {
        }

        public Biografia(string nombre, int stock, float importe):base(nombre, stock, importe)
        {
        }

        public override bool HayStock
        {
            get 
            {
                return this.stock > 0;
            }
        }

        protected override bool EsColor
        {
            get { return false; }
        }

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
