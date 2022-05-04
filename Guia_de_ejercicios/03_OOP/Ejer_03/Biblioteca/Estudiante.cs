using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if(nota > 0)
            {
                this.notaPrimerParcial = nota;
            }
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if(this.notaSegundoParcial >= 4 && this.notaPrimerParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }
            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ALUMNO: ");
            sb.AppendLine($"Apellido y Nombre: {this.apellido} {this.nombre}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota PP: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota SP: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            
            if(this.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota Final: {this.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }
            return sb.ToString();
        }
    }
}
