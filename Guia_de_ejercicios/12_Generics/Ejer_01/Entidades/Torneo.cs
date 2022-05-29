using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        private string nombre;
        private List<T> equipos;

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random rdm = new Random();
                int indicePrimerEquipo;
                int indiceSegundoEquipo;

                if(this.equipos is not null && this.equipos.Count > 1)
                {
                    do
                    {
                        indicePrimerEquipo = rdm.Next(0, this.equipos.Count);
                        indiceSegundoEquipo = rdm.Next(0, this.equipos.Count);
                    } while (indicePrimerEquipo == indiceSegundoEquipo);

                    return this.CalcularPartido(this.equipos[indicePrimerEquipo], this.equipos[indiceSegundoEquipo]);
                }
                return "Se necesitan al menos dos Equipos para jugar";
            }
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            bool rta = false;
            if(t is not null && e is not null)
            {
                foreach (Equipo item in t.equipos)
                {
                    if(item == e)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if(t != e)
            {
                t.equipos.Add(e);
            }
            return t;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Torneo \"{this.nombre}\" de {this.equipos.Count} equipos");
            sb.AppendLine("Lista de equipos: ");
            sb.AppendLine("**********************************************");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());    
            }

            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random rdm = new Random();
            string resultado = "";
            if(e1 is not null && e2 is not null)
            {
                int resultadoEquipo1 = 0;
                int resultadoEquipo2 = 0;
                if (e1.GetType() == typeof(EquipoFutbol) && e2.GetType() == typeof(EquipoFutbol))
                {
                    resultadoEquipo1 = rdm.Next(0, 10);
                    resultadoEquipo2 = rdm.Next(0, 10);                
                }
                else if(e1.GetType() == typeof(EquipoBasquet) && e2.GetType() == typeof(EquipoBasquet))
                {
                    resultadoEquipo1 = rdm.Next(60, 190);
                    resultadoEquipo2 = rdm.Next(60, 190);
                }
                resultado = $"{e1.Nombre} {resultadoEquipo1} - {resultadoEquipo2} {e2.Nombre}";
            }
            return resultado;
        }
    }
}
