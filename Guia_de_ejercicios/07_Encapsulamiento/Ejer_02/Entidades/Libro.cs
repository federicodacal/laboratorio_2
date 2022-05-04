using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public int CantidadPaginas
        {
            get { return this.paginas.Count; }
        }

        public string this[int index]
        {
            get 
            {
                string rta = "";
                if(index >= 0 && index < this.paginas.Count)
                {
                    rta = this.paginas[index];
                }
                return rta; 
            }
            set
            {
                if(index >= 0)
                {
                    if (index < this.paginas.Count)
                    {
                        this.paginas[index] = value;
                    }
                    else
                    {
                        this.paginas.Add(value);
                    }
                }
            }
        }
    }
}
