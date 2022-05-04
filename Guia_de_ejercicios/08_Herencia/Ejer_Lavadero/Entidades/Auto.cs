using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos)
            :base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cantidad Asientos: {this.cantidadAsientos}");

            return sb.ToString();
        }
    }
}
