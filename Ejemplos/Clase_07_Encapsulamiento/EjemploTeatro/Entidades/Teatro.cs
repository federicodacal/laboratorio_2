using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Teatro
    {
        private string nombre;
        private List<Espectador> espectadores;
        private int capacidad;

        public Teatro()
        {
            this.nombre = "Teatro de Juana";
            this.espectadores = new List<Espectador>();
            this.capacidad = 10;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public List<Espectador> Espectadores
        {
            get { return this.espectadores; }
        }

        public Espectador this[int dni]
        {
            get 
            {
                foreach (Espectador item in this.Espectadores)
                {
                    if(item.Dni == dni)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public static bool operator ==(Teatro t, Espectador e)
        {
            bool rta = false;
            if(t is not null && e is not null)
            {
                foreach(Espectador item in t.Espectadores)
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

        public static bool operator !=(Teatro t, Espectador e)
        {
            return !(t == e);
        }

        public static bool operator +(Teatro t, Espectador e)
        {
            bool rta = false;
            if(t.Espectadores.Count < t.capacidad && t != e)
            {
                t.Espectadores.Add(e);
                rta = true;
            }
            return rta;
        }

        public string MostrarEspectadores()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine("Lista de Espectadores");
            foreach (Espectador item in this.Espectadores)
            {
                sb.AppendLine((string)item);
                sb.AppendLine("**************************************");
            }
            return sb.ToString();
        }


    }
}
