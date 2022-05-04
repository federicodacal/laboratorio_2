using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CasaDeMusica
    {
        private List<Instrumento> lista;
        private int cantidadMaxima;

        private CasaDeMusica()
        {
            this.lista = new List<Instrumento>();
        }
        public CasaDeMusica(int cantidad):this()
        {
            this.cantidadMaxima = cantidad;
        }

        public List<Instrumento> Lista
        {
            get { return this.lista; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Casa de Música");
            sb.AppendLine("Lista: ");
            foreach (Instrumento item in this.Lista)
            {
                sb.AppendLine("----------------------------------");
                // sb.AppendLine(item.Mostrar());
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(CasaDeMusica c, Instrumento i)
        {
            bool rta = false;
            if(c is not null && i is not null)
            {
                foreach (Instrumento item in c.Lista)
                {
                    if(item == i)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(CasaDeMusica c, Instrumento i)
        {
            return !(c == i);
        }

        public static bool operator +(CasaDeMusica c, Instrumento i)
        {
            bool rta = false;
            if(c.Lista.Count < c.cantidadMaxima && c != i)
            {
                c.Lista.Add(i);
                rta = true;
            }
            return rta;
        }

        public static bool operator -(CasaDeMusica c, Instrumento instrumento)
        {
            bool rta = false;
            if(c == instrumento)
            {
                for(int i = 0; i < c.lista.Count; i++)
                {
                    if(c.Lista[i] == instrumento)
                    {
                        c.Lista.RemoveAt(i);
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

    }
}
