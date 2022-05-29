using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class AnimalVolador
    {
        protected float peso;

        public AnimalVolador(float peso)
        {
            this.peso = peso;
        }
    }
}
