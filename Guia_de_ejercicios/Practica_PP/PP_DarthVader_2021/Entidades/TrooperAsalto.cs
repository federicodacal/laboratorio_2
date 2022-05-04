using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperAsalto : Trooper
    {
        public TrooperAsalto(Blaster armamento)
            :base(armamento, true)
        {

        }

        public override string Tipo
        {
            get { return "Comando para misiones de infiltración"; }
        }
    }
}
