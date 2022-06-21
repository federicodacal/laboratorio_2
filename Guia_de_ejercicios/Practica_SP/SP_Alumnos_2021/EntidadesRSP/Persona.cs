using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Persona
///Atributos (todos privados)
///dni : int
///apellido : string
///nombre : string
///Propiedades públicas de lectura y escritura para todos sus atributos.
///Constructor que reciba parámetros para cada atributo
///Polimorfismo sobre ToString
namespace EntidadesRSP
{
    public class Persona
    {
        private int dni;
        private string apellido;
        private string nombre;

        public Persona()
        {

        }

        public Persona(int dni, string apellido, string nombre)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} - DNI: {this.Dni}";
        }
    }
}
