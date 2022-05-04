using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        public enum Color { Roja, Blanca, Amarilla, Rosa, Azul }

        private Color florColor;

        public Rosal(string nombre, int tamanio)
            :this(nombre, tamanio, Color.Roja)
        {

        }

        public Rosal(string nombre, int tamanio, Color color)
            :base(nombre, tamanio)
        {
            this.florColor = color;
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFruto
        {
            get { return false; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color: {this.florColor}");

            return sb.ToString();
        }
    }
}
