using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Animal
    {
        public override string EmitirSonido()
        {
            return "WOOOOF!";
        }
    }
}
