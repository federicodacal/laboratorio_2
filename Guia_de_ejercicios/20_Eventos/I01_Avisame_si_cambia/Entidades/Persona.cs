using System;

namespace Entidades
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        public event DelegadoString EventoString;

        private string apellido;
        private string nombre;

        public Persona() { }

        public string Apellido 
        { 
            get => apellido;
            set 
            { 
                this.apellido = value;
                this.EventoString.Invoke(this.apellido);
            } 
        }
        public string Nombre 
        { 
            get => nombre;
            set
            {
                this.nombre = value;
                this.EventoString.Invoke(this.nombre);
            }
        }

        public string Mostrar()
        {
            return $"{this.nombre} {this.Apellido}";
        }
    }
}
