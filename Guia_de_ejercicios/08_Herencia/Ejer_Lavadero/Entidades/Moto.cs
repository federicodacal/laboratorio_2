using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, byte cantRuedas, EMarcas marca,float cilindrada)
            :base(patente,cantRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");

            return sb.ToString();
        }
    }
}
