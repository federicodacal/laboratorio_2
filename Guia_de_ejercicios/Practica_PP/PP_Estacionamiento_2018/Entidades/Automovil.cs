using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            :this(patente, color, Automovil.valorHora)
        {

        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            :base(patente)
        {
            this.color = color;
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Valor Hora: {Automovil.valorHora}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ImprimirTicket());

            int horas = (int)(DateTime.Now - this.ingreso).TotalHours;
            double costoEstadia = horas * Automovil.valorHora;

            sb.AppendLine($"Costo Estadía: ${costoEstadia} por {horas} horas");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Automovil);
        }
    }
}
