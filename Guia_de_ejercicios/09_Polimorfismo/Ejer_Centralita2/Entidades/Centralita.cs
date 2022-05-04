using System;
using System.Collections.Generic;
using System.Text;

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

        public Centralita(string razonSocial) : this()
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
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada;
                        }
                        if (item is Provincial)
                        {
                            ganancia += ((Provincial)item).CostoLlamada;
                        }
                    }
                    break;
            }
            return ganancia;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada is not null)
            {
                this.Llamadas.Add(nuevaLlamada);
            }
        }

        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(razonSocial);
            sb.AppendLine($"Ganancia total: {this.GananciasTotal}");
            sb.AppendLine($"Ganancia por local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia por provincial: {this.GananciasPorProvincial}");
            sb.AppendLine("<-------------------------------------------------->");
            this.OrdenarLlamadas();
            sb.AppendLine("Llamadas: ");
            foreach (Llamada item in this.Llamadas)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("********************************");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool rta = false;
            if(c is not null && l is not null)
            {
                foreach (Llamada item in c.Llamadas)
                {
                    if(item == l)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static bool operator +(Centralita c, Llamada l)
        {
            bool rta = false;
            if(c != l)
            {
                c.AgregarLlamada(l);
                rta = true;
            }
            return rta;
        }

    }
}
