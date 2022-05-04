using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empresa
    {
        private string razonSocial;
        private Conductor[] conductores;

        public Empresa(string razonSocial, int cantidadConductores)
        {
            this.razonSocial = razonSocial;
            this.conductores = new Conductor[cantidadConductores];
        }

        public bool AgregarConductor(Conductor c)
        {
            bool rta = false;
            if(this.conductores is not null && c is not null && this.conductores.Length > 0)
            {
                for (int i = 0; i < this.conductores.Length; i++)
                {
                    if(this.conductores[i] is null)
                    {
                        this.conductores[i] = c;
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public string MostrarConductores()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*********************************");
            sb.AppendLine($"LISTA DE CONDUCTORES de {this.razonSocial}");
            sb.AppendLine("*********************************");

            if(this.conductores is not null && this.conductores.Length > 0)
            {
                for (int i = 0; i < this.conductores.Length; i++)
                {
                    if(this.conductores[i] is not null)
                    {
                        sb.AppendLine(this.conductores[i].Mostrar());
                    }
                }
            }
            return sb.ToString();
        }

        public Conductor GetConductorMasKmsRecorridosSemana()
        {
            Conductor elQueMasKmsRecorrio = new Conductor(""); 
            double mayorRecorrido = 0;

            if(this.conductores is not null && this.conductores.Length > 0)
            {
                for (int i = 0; i < this.conductores.Length; i++)
                {
                    if(this.conductores[i].GetKmsTotales() > mayorRecorrido || i == 0)
                    {
                        mayorRecorrido = this.conductores[i].GetKmsTotales();
                        elQueMasKmsRecorrio = this.conductores[i];
                    }
                }
            }
            return elQueMasKmsRecorrio;
        }
    }
}
