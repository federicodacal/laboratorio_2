using System;

namespace Entidades.Externa
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
    }
}
