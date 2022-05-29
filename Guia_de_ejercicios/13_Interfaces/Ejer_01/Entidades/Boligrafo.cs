using System;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = unidades;
        }

        public ConsoleColor Color 
        { 
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }
        public float UnidadesDeEscritura 
        {
            get { return this.tinta; }
            set { this.tinta = value; } 
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= texto.Length * 0.3F;
            return new EscrituraWrapper(this.Color, texto);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            return $"Bolígrafo \nTinta: {this.UnidadesDeEscritura} Color: {this.Color}"; 
        }
    }
}
