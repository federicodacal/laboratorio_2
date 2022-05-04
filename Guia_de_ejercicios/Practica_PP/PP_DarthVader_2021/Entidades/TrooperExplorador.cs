using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperExplorador : Trooper 
    {
        public string vehiculo;

        public TrooperExplorador(string vehiculo)
            :base(Blaster.EC17)
        {
            this.vehiculo = vehiculo;
        }

        public override string Tipo
        {
            get { return "Soldado de exploración"; }
        }

        public string Vehiculo
        {
            get 
            {
                if (String.IsNullOrEmpty(this.vehiculo))
                {
                    this.vehiculo = "Indefinido";
                }
                return this.vehiculo; 
            }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.vehiculo = value;
                }
            }
        }

        public override string InfoTrooper()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.InfoTrooper());
            sb.AppendLine($"Vehiculo: {this.Vehiculo}");

            return sb.ToString();
        }
    }
}
