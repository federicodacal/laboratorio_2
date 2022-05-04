using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hospital
    {
        private string nombre;
        private List<Personal> personal;

        private Hospital()
        {
            this.personal = new List<Personal>();
        }

        private Hospital(string nombre):this()
        {
            this.nombre = nombre;
        }

        public int CantidadPersonal
        {
            get { return this.personal.Count; }
        }

        public Personal this[int index]
        {
            get 
            {
                Personal p = null;
                if(index >= 0 && index < this.CantidadPersonal)
                {
                    p = this.personal[index];
                }
                return p;
            }
        }

        public static implicit operator Hospital(string nombre)
        {
            return new Hospital(nombre);
        }

        public static int operator |(Hospital h, Personal p)
        {
            int index = -1;
            if(h is not null && p is not null)
            {
                for (int i = 0; i < h.CantidadPersonal; i++)
                {
                    if(h.personal[i] == p)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        public static Hospital operator +(Hospital h, Personal p)
        {
            int indice = h | p;
            if(indice == -1)
            {
                h.personal.Add(p);
            }
            return h;
        }

        public static Hospital operator -(Hospital h, Personal p)
        {
            int indice = h | p;
            if(indice != -1)
            {
                h.personal.RemoveAt(indice);
            }
            return h;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} {this.nombre}");
            sb.AppendLine($"Personal: {this.CantidadPersonal}");
            sb.AppendLine("Listado: ");
            foreach (Medico item in this.personal)
            {
                sb.AppendLine(item.Info);
                sb.AppendLine("************************");
            }
            return sb.ToString();
        }
    }
}
