using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int edad;
        private int dni;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public string Apellido 
        {
            get { return this.apellido; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public int Dni
        {
            get { return this.dni; }
        }

        public int Edad
        {
            get { return this.edad; }
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}: {this.Nombre} {this.Apellido}");
            sb.AppendLine($"Edad: {this.Edad} años");
            sb.AppendLine($"DNI: {this.Dni}");

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
