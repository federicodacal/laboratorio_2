using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Llamada
    {

        public enum TipoLlamada { Local, Provincial, Todas }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Llamada de {this.NroOrigen} a {this.NroDestino}. Duración: {this.Duracion}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            int rta = 0;
            if (l1.Duracion < l2.Duracion)
            {
                rta = 1;
            }
            else
            {
                rta = -1;
            }
            return rta;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool rta = false;
            if (l1 is not null && l2 is not null)
            {
                rta = l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
            }
            return rta;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
