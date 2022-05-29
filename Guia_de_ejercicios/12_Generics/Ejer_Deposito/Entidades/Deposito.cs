using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
        where T : class
    {
        private int capacidadMaxima;
        private List<T> lista;

        public Deposito(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<T>();
        }

        public bool Agregar(T elemento)
        {
            return this + elemento;
        }

        public bool Remover(T elemento)
        {
            return this - elemento;
        }

        private int GetIndice(T elemento)
        {
            int indice = -1;
            if (elemento is not null && this.lista is not null)
            {
                for (int i = 0; i < this.lista.Count; i++)
                {
                    if (this.lista[i] == elemento)
                    {
                        indice = i;
                        break;
                    }
                }
            }
            return indice;
        }

        public static bool operator +(Deposito<T> d, T elemento)
        {
            bool rta = false;
            if (elemento is not null && d.lista is not null && d.lista.Count < d.capacidadMaxima)
            {
                d.lista.Add(elemento);
                rta = true;
            }
            return rta;
        }

        public static bool operator -(Deposito<T> d, T elemento)
        {
            bool rta = false;
            int indice = d.GetIndice(elemento);

            if (indice != -1)
            {
                d.lista.RemoveAt(indice);
                rta = true;
            }
            return rta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Deposito de {typeof(T).Name}: {this.capacidadMaxima} ({this.lista.Count})");
            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
