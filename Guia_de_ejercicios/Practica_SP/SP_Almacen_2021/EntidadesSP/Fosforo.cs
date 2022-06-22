using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public class Fosforo : Producto
    {
        public Fosforo(string marca, string tipo, int codigo, double precio) 
            :base(marca, tipo, codigo, precio)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
