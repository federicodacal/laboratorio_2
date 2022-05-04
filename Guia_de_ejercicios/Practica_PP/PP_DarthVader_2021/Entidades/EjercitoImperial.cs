using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();
        }

        public EjercitoImperial(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public List<Trooper> Troopers
        {
            get { return this.troopers; }
        }

        public static EjercitoImperial operator +(EjercitoImperial e, Trooper t)
        {
            if(e is not null && t is not null && e.capacidad > e.Troopers.Count)
            {
                e.Troopers.Add(t);
            }

            return e;
        }

        public static EjercitoImperial operator -(EjercitoImperial e, Trooper t)
        {
            if(e is not null && t is not null)
            {
                foreach (Trooper item in e.Troopers)
                {
                    if (item.Equals(t))
                    {
                        e.troopers.Remove(item);
                        break;
                    }
                }
            }
            return e;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ejercito: capacidad {this.capacidad} ({this.Troopers.Count})");
            foreach (Trooper item in this.Troopers)
            {
                sb.Append(item.InfoTrooper());
                sb.Append("*************************************");
            }
            return sb.ToString();
        }
    }
}
