using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set 
            {
                if (value.ValidarAptitud())
                {
                    this.dt = value;
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{e.GetType().Name}: {e.Nombre}");
            if(e.dt is not null)
            {
                sb.AppendLine(e.dt.Mostrar());
            }
            else
            {
                sb.AppendLine("Sin DT asignado");
            }

            sb.AppendLine($"Equipo de {e.jugadores.Count} jugadores");
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool rta = false;
            if(e is not null && j is not null)
            {
                rta = e.jugadores.Contains(j);
            }
            return rta;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j && j.ValidarAptitud() && e.jugadores.Count < cantidadMaximaJugadores)
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool rta = false;

            int contArqueros = 0;
            int contDefensores = 0;
            int contDelanteros = 0;
            int contCentrales = 0;

            if(e is not null)
            {
                if(e.dt is not null && e.jugadores.Count == cantidadMaximaJugadores)
                {
                    foreach (Jugador item in e.jugadores)
                    {
                        if(item.Posicion == Posicion.Arquero)
                        {
                            contArqueros++;
                        }
                        else if (item.Posicion == Posicion.Delantero)
                        {
                            contDelanteros++;
                        }
                        else if (item.Posicion == Posicion.Central)
                        {
                            contCentrales++;
                        }
                        else if (item.Posicion == Posicion.Defensor)
                        {
                            contDefensores++;
                        }
                    }

                    if(contArqueros == 1 && contDefensores > 0 && contDelanteros > 0 && contCentrales > 0)
                    {
                        rta = true;
                    }
                }
            }

            return rta;
        }
    }
}
