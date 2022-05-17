using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class CentroDeAtencion<T>
    {
        private List<T> lista;

        public CentroDeAtencion()
        {
            this.lista = new List<T>();
        }

        public void Agregar(T elemento)
        {
            this.lista.Add(elemento);
        }

        public string MostrarLista()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**** Lista ****");
            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
