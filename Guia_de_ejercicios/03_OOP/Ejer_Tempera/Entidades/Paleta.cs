using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }

        private Paleta(int cantidadMaximaColores):this()
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Paleta: ");
            sb.AppendLine($"Cantidad máxima: {this.cantidadMaximaColores}");
            sb.AppendLine("Temperas: ");
            if(this.temperas is not null && this.temperas.Count > 0)
            {
                foreach (Tempera item in this.temperas)
                {
                    sb.AppendLine(Tempera.Mostrar(item));
                }
            }
            else
            {
                sb.AppendLine("No tiene");
            }
            return sb.ToString();
        }

        public static explicit operator string (Paleta p)
        {
            return p.Mostrar();
        }

        public static implicit operator int(Paleta p)
        {
            return p.cantidadMaximaColores;
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool rta = false;
            if(p is not null && t is not null)
            {
                foreach (Tempera item in p.temperas)
                {
                    if(item == t)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        private int ObtenerIndice(Tempera t)
        {
            int index = -1;
            if(t is not null && this.temperas is not null && this.temperas.Count > 0)
            {
                for(int i = 0; i < this.temperas.Count; i++)
                {
                    if(this.temperas[i] == t)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            if(p == t)
            {
                int indice = p.ObtenerIndice(t);
                if(indice > -1)
                {
                    p.temperas[indice] += t;
                }
            }
            else
            {
                if(p.temperas.Count < p.cantidadMaximaColores)
                {
                    p.temperas.Add(t);
                }
            }
            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            if(p == t)
            {
                int indice = p.ObtenerIndice(t);
                if(indice > -1)
                {
                    p.temperas[indice] += (-t);
                    if(p.temperas[indice] <= 0)
                    {
                        p.temperas.RemoveAt(indice);
                    }
                }
            }
            return p;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta nuevaPaleta = null;
            if(p1 is not null && p2 is not null)
            {
                nuevaPaleta = p1.cantidadMaximaColores + p2.cantidadMaximaColores;

                nuevaPaleta.temperas = p1.temperas.ToList();

                foreach (Tempera item in p2.temperas)
                {
                    if(item is not null)
                    {
                       nuevaPaleta += item;
                    }
                }
            }
            return nuevaPaleta;
        }

    }
}
