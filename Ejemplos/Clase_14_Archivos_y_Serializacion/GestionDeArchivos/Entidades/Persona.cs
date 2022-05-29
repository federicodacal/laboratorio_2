using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]
    public abstract class Persona
    {
        protected string nombre;
        protected DateTime fechaNacimiento;

        public Persona()
        {

        }

        public Persona(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public DateTime FechaNacimiento { get => this.fechaNacimiento; set => this.fechaNacimiento = value; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} | Fecha de Nacimiento: {this.FechaNacimiento.ToLongDateString()}";
        }

    }
}
