using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {

        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            :this(patente, modelo, PickUp.valorHora)
        {
           
        }

        public PickUp(string patente, string modelo, int valorHora)
            :base(patente)
        {
            this.modelo = modelo;
            PickUp.valorHora = valorHora;
        }


        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Valor Hora: {PickUp.valorHora}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ImprimirTicket());

            int horas = (int)(DateTime.Now - this.ingreso).TotalHours;
            double costoEstadia = horas * PickUp.valorHora;

            sb.AppendLine($"Costo Estadía: ${costoEstadia} por {horas} horas");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(PickUp);
        }
    }
}
