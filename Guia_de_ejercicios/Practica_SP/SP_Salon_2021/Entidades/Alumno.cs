using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Alumno (legajo: Short; nivel: ENivelDeEstudio) - ToString():string (polimorfismo; reutilizar código)
namespace Entidades
{
    public enum ENivelDeEstudio { Primaria, Secundaria, Terciaria, Universitaria }

    public class Alumno : Persona
    {
        private short legajo;
        private ENivelDeEstudio nivel;

        public Alumno()
        {

        }

        public Alumno(Persona p, short legajo, ENivelDeEstudio nivel):base(p.Nombre, p.Apellido, p.Idioma, p.Edad)
        {
            this.legajo = legajo;
            this.nivel = nivel;
        }

        public short Legajo { get => legajo; set => legajo = value; }
        public ENivelDeEstudio Nivel { get => nivel; set => nivel = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Legajo: {this.Legajo} - {this.nivel}";
        }
    }
}
