using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bateria : Instrumento
    {
        private int cuerpos;

        public Bateria(int codigo, string marca, EClasificacion clasificacion, int cuerpos)
            :base(codigo, marca, clasificacion)
        {
            this.cuerpos = cuerpos;
        }

        public string MostrarBateria()
        { 
            return base.Mostrar() + $"\nCuerpos: {this.cuerpos}";
        }
    }
}
