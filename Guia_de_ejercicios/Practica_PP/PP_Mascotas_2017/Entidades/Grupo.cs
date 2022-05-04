using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        static Grupo()
        {
            Grupo.Tipo = TipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo):this(nombre)
        {
            Grupo.tipo = tipo;
        }

        public static TipoManada Tipo
        {
            set { Grupo.tipo = value; }
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool rta = false;
            if(g is not null && m is not null)
            {
                foreach (Mascota item in g.manada)
                {
                    if(item == m)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g != m)
            {
                g.manada.Add(m);
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if(g == m)
            {
                g.manada.Remove(m);
            }
            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"**{g.GetType().Name}: {g.nombre} {Grupo.tipo}**");
            sb.AppendLine($"Integrantes ({g.manada.Count})");
            foreach (Mascota item in g.manada)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
