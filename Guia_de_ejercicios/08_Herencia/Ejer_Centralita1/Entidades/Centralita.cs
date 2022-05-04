using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        private Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasTotal
        {
            get { return this.GananciasPorLocal + this.GananciasPorProvincial; }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada item in this.Llamadas)
                    {
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada item in this.Llamadas)
                    {
                        if (item is Provincial)
                        {
                            ganancia += ((Provincial)item).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada item in this.Llamadas)
                    {
                        if(item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada;
                        }
                        if(item is Provincial)
                        {
                            ganancia += ((Provincial)item).CostoLlamada;
                        }
                    }
                    break;
            }
            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(razonSocial);
            sb.AppendLine($"Ganancia total: {this.GananciasTotal}");
            sb.AppendLine($"Ganancia por local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia por provincial: {this.GananciasPorProvincial}");
            sb.AppendLine("<-------------------------------------------------->");
            sb.AppendLine("Llamadas: ");
            foreach (Llamada item in this.Llamadas)
            {
                if(item is Local)
                {
                    sb.AppendLine(((Local)item).Mostrar());
                }
                else if(item is Provincial)
                {
                    sb.AppendLine(((Provincial)item).Mostrar());
                }
            }
            sb.AppendLine("********************************");
            return sb.ToString();
        }

    }
}
