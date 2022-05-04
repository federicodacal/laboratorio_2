using System;
using System.Text;

namespace Entidades
{
    public class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas}

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Llamada de {this.NroOrigen} a {this.NroDestino}. Duración: {this.Duracion}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            int rta = 0;
            if(l1.Duracion < l2.Duracion)
            {
                rta = 1;
            }
            else
            {
                rta = -1;
            }
            return rta;
        }

    }
}
