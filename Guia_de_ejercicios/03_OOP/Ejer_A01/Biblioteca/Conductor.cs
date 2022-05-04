using System;
using System.Text;

namespace Biblioteca
{
    public class Conductor
    {
        private string nombre;
        private double kmsRecorridos;
        private double[] kmsPorDia;

        public Conductor(string nombre)
        {
            this.nombre = nombre;
            this.kmsPorDia = new double[7];
        }

        public void SetKmsPorDia(int dia, double kms)
        {
            dia--;
            if(dia >= 0 && dia <= 6 && kms >= 0)
            {
                this.kmsPorDia[dia] = kms;
            }
        }

        public double GetKmsTotales()
        {
            double kms = 0;
            for (int i = 0; i < this.kmsPorDia.Length; i++)
            {
                kms += this.kmsPorDia[i];
            }
            return kms;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Conductor: {this.nombre}");
            sb.AppendLine($"Kms Recorridos: {this.GetKmsTotales()} kms");
            for (int i = 0; i < this.kmsPorDia.Length; i++)
            {
                sb.AppendLine($"Día {i + 1}: {this.kmsPorDia[i]} kms");
            }

            return sb.ToString();
        }

    }
}
