using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Persona (apellido:string; edad:Sbyte) - ToString():string (polimorfismo; reutilizar código)
    public class Persona : Humano
    {
        private string apellido;
        private SByte edad;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, EIdioma idioma, SByte edad)
            :base(nombre, idioma)
        {
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public sbyte Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - {this.Apellido} - {this.Edad} años";
        }
    }
}
