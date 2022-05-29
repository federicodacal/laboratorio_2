using System;
using System.Text;

namespace Entidades
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get { return costoEnvio * 0.35M; }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo envío: $ {this.costoEnvio}");
            sb.AppendLine($"Destino: $ {this.destino}");
            sb.AppendLine($"Origen: $ {this.origen}");
            sb.AppendLine($"Peso: $ {this.pesoKg}kgs");
            sb.AppendLine($"Tiene prioridad: {this.TienePrioridad}");

            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }


    }
}
