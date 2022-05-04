using System;
using System.Text;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio
        {
            get { return this.tamanio; }
        }

        public abstract bool TieneFlores { get; }
        public abstract bool TieneFruto { get; }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} tiene un tamaño de {this.Tamanio}");
            sb.Append("Tiene Flores: ");
            if (this.TieneFlores)
            {
                sb.AppendLine("SI");
            }
            else
            {
                sb.AppendLine("NO");
            }
            sb.Append("Tiene Fruto: ");
            if (this.TieneFruto)
            {
                sb.AppendLine("SI");
            }
            else
            {
                sb.AppendLine("NO");
            }

            return sb.ToString();
        }
    }
}
