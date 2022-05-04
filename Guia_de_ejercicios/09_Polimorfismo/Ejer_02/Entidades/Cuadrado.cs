using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        private float longitudLado;
        public Cuadrado(float longitudLado)
            :base(longitudLado, longitudLado)
        {

        }
    }
}
