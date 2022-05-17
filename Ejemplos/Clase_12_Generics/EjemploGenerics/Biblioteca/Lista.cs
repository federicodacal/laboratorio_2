using System;
using System.Text;

namespace Biblioteca
{
    public class Lista<T>
    {
        private int capacidad;
        private int proximoIndice;
        private T[] lista;

        public Lista(int capacidad)
        {
            this.lista = new T[capacidad];
            this.proximoIndice = 0;
        }

        public void Add(T item)
        {
            if(item is not null && this.lista is not null && this.proximoIndice < this.lista.Length)
            {
                this.lista[this.proximoIndice] = item;
                this.proximoIndice++;
            }
        }

        public T GetElement(int index)
        {
            T aux = default;
            if(index >= 0 && this.lista is not null && index < this.lista.Length)
            {
                for (int i = 0; i < this.lista.Length; i++)
                {
                    if(index == i && this.lista[index] is not null)
                    {
                        aux = this.lista[index];
                    }
                }
            }
            return aux;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if(this.lista is not null)
            {
                foreach (T item in this.lista)
                {
                    if(item is not null)
                    {
                        sb.AppendLine(item.ToString());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
