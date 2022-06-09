using System;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;


        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public Persona(int id, string nombre, string apellido, int edad)
            :this(nombre, apellido, edad)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"ID: {this.id} | {this.nombre} {this.apellido} tiene {this.edad} años";
        }

    }
}
