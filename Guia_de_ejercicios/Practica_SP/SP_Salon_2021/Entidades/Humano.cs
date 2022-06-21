using System;

//Humano (nombre:string;  idioma:EIdioma;) - ToString():string
namespace Entidades
{
    public enum EIdioma { Inglés, Español, Portugués }
    public class Humano
    {
        private string nombre;
        private EIdioma idioma;

        public Humano()
        {

        }

        public Humano(string nombre, EIdioma idioma)
        {
            this.nombre = nombre;
            this.idioma = idioma;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EIdioma Idioma { get => idioma; set => idioma = value; }

        public override string ToString()
        {
            return $"{this.Nombre} - {this.Idioma}";
        }
    }
}
