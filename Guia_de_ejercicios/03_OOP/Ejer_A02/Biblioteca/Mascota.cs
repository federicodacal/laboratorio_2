using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private List<EVacunas> historialDeVacunacion;

        public Mascota(string nombre, string especie, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
            this.historialDeVacunacion = new List<EVacunas>();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.especie}");
            sb.AppendLine($"{this.nombre}");
            sb.AppendLine($"{this.fechaNacimiento.ToShortDateString()}");
            if(this.historialDeVacunacion.Count > 0)
            {
                sb.AppendLine("Historial de vacunación: ");
                foreach (EVacunas item in this.historialDeVacunacion)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            else
            {
                sb.AppendLine("No registra vacunas");
            }
            return sb.ToString();
        }

        public void Vacunar(EVacunas vacuna)
        {
            switch (vacuna)
            {
                case EVacunas.TripleFelina:
                    this.historialDeVacunacion.Add(EVacunas.TripleFelina);
                    break;
                case EVacunas.Rabia:
                    this.historialDeVacunacion.Add(EVacunas.Rabia);
                    break;
                case EVacunas.Hepatitis:
                    this.historialDeVacunacion.Add(EVacunas.Hepatitis);
                    break;
                case EVacunas.Parvovirosis:
                    this.historialDeVacunacion.Add(EVacunas.Parvovirosis);
                    break;
                case EVacunas.Moquillo:
                    this.historialDeVacunacion.Add(EVacunas.Moquillo);
                    break;
                default:
                    break;
            }
        }


    }
}
