using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reptil : Animal
    {
        public Reptil(string nombre, float peso) 
            :base(nombre, peso)
        {

        }

        public override string Mostrar()
        {
            return base.Mostrar();
        }


        public override string Alimentarse()
        {
            return "Reptil comiendo...";
        }
    }
}
