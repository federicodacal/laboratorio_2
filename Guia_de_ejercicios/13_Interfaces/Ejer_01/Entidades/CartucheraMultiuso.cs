using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> utiles;

        public CartucheraMultiuso()
        {
            this.utiles = new List<IAcciones>();
            this.utiles.Add(new Boligrafo(10, ConsoleColor.Red));
            this.utiles.Add(new Boligrafo(2, ConsoleColor.White));
            this.utiles.Add(new Lapiz(1));
        }

        public bool RecorrerElementos()
        {
            bool flag = false;
            foreach (IAcciones item in this.utiles)
            {
                if(item.UnidadesDeEscritura < 1)
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }

                if(item.UnidadesDeEscritura >= 1)
                {
                    item.UnidadesDeEscritura -= 1;
                    if(item.UnidadesDeEscritura < 1)
                    {
                        item.Recargar(20);
                    }
                }
            }
            return flag;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cartuchera Multiuso");
            foreach (IAcciones item in this.utiles)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
