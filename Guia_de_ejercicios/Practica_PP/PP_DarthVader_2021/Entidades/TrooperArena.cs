using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperArena : Trooper
    {

        public TrooperArena(Blaster armamento)
            :base(armamento)
        {

        }

        public override string Tipo
        {
            get { return "Soldado de asalto de terrenos desérticos"; }
        }

    }
}
