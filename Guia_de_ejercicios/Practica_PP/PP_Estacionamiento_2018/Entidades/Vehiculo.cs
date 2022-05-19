using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get { return this.patente; }
            set
            {
                if(value is not null && value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return String.Format("{0} Patente {1}", this.GetType().Name,this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine(this.ingreso.ToLongTimeString());

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool rta = false;
            if(v1 is not null && v2 is not null)
            {
                rta = v1.Equals(v2) && v1.Patente == v2.Patente;
            }
            return rta;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
