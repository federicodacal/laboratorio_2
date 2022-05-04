using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara)
            :base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Tara: {this.tara}");

            return sb.ToString();
        }
    }
}
