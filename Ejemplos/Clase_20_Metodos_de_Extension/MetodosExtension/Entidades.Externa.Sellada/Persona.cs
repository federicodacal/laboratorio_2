using System;

namespace Entidades.Externa.Sellada
{
    public sealed class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Edad { get { return this.edad; } }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

    }
}
