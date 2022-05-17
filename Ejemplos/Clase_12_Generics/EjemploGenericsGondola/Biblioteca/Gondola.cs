using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Gondola<T>
        where T : class
    {
        private int idGondola;
        private string sector;
        private List<T> listaDeElementos;

        private Gondola()
        {
            this.listaDeElementos = new List<T>();
        }

        public Gondola(int idGondola, string sector):this()
        {
            this.idGondola = idGondola;
            this.sector = sector;
        }

        public int CantidadElementos
        {
            get { return this.listaDeElementos.Count; }
        }

        public void Agregar(T elemento)
        {
            if(this.listaDeElementos is not null && elemento is not null)
            {
                this.listaDeElementos.Add(elemento);
            }
        }

        public T PrimerElemento()
        {
            return this.listaDeElementos[0];
        }

    }
}
