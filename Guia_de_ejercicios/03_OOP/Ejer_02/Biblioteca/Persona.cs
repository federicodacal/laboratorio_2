using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }

        private int CalcularEdad()
        {
            int edad;
            if(DateTime.Now.Month <= this.FechaDeNacimiento.Month && DateTime.Now.Day <= this.FechaDeNacimiento.Day)
            {
                edad = DateTime.Now.Year - this.FechaDeNacimiento.Year - 1;
            }
            else
            {
                edad = DateTime.Now.Year - this.FechaDeNacimiento.Year;
            }
            return edad;
        }

        public string EsMayorDeEdad()
        {
            string respuesta;
            if(this.CalcularEdad() >= 18)
            {
                respuesta = "Es mayor de edad";
            }
            else
            {
                respuesta = "Es menor de edad";
            }
            return respuesta;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Fecha de Nacimiento: {this.FechaDeNacimiento.ToShortDateString()}");
            sb.AppendLine($"Edad: {this.CalcularEdad()}");
            sb.AppendLine($"{this.EsMayorDeEdad()}");

            return sb.ToString();
        }
    }
}
