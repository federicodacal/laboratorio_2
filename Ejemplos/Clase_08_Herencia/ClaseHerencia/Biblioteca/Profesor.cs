using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor : Persona
    {
        public string catedra;

        public Profesor(string catedra, string nombre, string apellido, long dni)
            :base(nombre,apellido,dni)
        {
            this.catedra = catedra;
        }

        public string Corregir()
        {
            return "Estoy corrigiendo...";
        }

        public string MostrarProfe()
        {
            return $"{base.MostrarPersona()} \nCatedra: {this.catedra}";
        }

    }
}
