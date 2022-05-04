using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        public Provincial(Franja franja, Llamada llamada)
            :this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja franja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = franja;
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float costo = -1;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                costo = this.Duracion * 0.99F;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                costo = this.Duracion * 1.25F;
            }
            else if (this.franjaHoraria == Franja.Franja_3)
            {
                costo = this.Duracion * 0.66F;
            }
            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
