using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
            :base(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public Jugador(int dni, string nombre)
            :this(dni,nombre,0,0)
        {

        }

        public float PromedioGoles
        {
            get 
            {
                float promedio = 0;
                if (!(this.partidosJugados == 0))
                {
                    promedio = (float)this.totalGoles / this.partidosJugados;
                }
                return promedio;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados} | Goles {this.totalGoles}");
            sb.AppendLine($"Promedio de Gol: {this.PromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool rta = false;
            if(j1 is not null && j2 is not null)
            {
                rta = j1.Dni == j2.Dni;
            }
            return rta;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
