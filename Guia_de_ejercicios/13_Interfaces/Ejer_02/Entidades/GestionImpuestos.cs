using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if(paquete is IAfip)
            {
                this.impuestosAfip.Add((IAfip)paquete);
            }
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                this.RegistrarImpuestos(item);
            }
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalImpuestosAduana = 0;
            foreach (IAduana item in this.impuestosAduana)
            {
                totalImpuestosAduana += item.Impuestos;
            }
            return totalImpuestosAduana;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal totalImpuestosAfip = 0;
            foreach (IAfip item in this.impuestosAfip)
            {
                totalImpuestosAfip += ((IAfip)item).Impuestos;
            }
            return totalImpuestosAfip;
        }


    }
}
