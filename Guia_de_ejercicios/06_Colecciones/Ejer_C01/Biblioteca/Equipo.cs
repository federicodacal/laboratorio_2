using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre):this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool rta = false;
            if(e != j && e.jugadores.Count < e.cantidadJugadores)
            {
                e.jugadores.Add(j);
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool rta = false;
            if(e is not null & j is not null)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if(item == j)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine($"Jugadores: {this.jugadores.Count} | Cantidad Maxima: {this.cantidadJugadores}");
            sb.AppendLine("Lista: ");
            foreach (Jugador item in this.jugadores)
            {
                sb.AppendLine(item.MostrarDatos());
                sb.AppendLine("-----------------------");
            }
            return sb.ToString();
        }

    }
}
