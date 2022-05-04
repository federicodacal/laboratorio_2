using System;

namespace Biblioteca
{
    public class Jugador
    {
        public enum Color
        {
            Rojo, Azul, Verde, Blanco
        }

        private int id;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private Color colorCamiseta;

        public Jugador(int id, string nombre, int partidosJugados, int totalGoles)
        {
            this.id = id;
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public int Id
        {
            get { return this.id; }
            set 
            {
                if (this.ValidarId(value))
                {
                    this.id = value; 
                }
            }
        }

        private bool ValidarId(int id)
        {
            return id > 0;
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public float PromedioGoles
        {
            get { return (float) this.TotalGoles / this.PartidosJugados; }
        }

        public Color ColorCamiseta
        {
            get { return this.colorCamiseta; }
            set { this.colorCamiseta = value; }
        }
    }
}
