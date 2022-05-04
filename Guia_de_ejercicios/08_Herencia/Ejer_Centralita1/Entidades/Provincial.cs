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
            : base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
        {
            this.franjaHoraria = franja;
        }

        public Provincial(string origen, Franja franja, float duracion, string destino)
            : this(franja, new Llamada(duracion, destino, origen))
        {

        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float costo = -1;
            if(this.franjaHoraria == Franja.Franja_1)
            {
                costo = this.Duracion * 0.99F;
            }
            else if(this.franjaHoraria == Franja.Franja_2)
            {
                costo = this.Duracion * 1.25F;
            }
            else if(this.franjaHoraria == Franja.Franja_3)
            {
                costo = this.Duracion * 0.66F;
            }
            return costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");

            return sb.ToString();
        }
    }
}
