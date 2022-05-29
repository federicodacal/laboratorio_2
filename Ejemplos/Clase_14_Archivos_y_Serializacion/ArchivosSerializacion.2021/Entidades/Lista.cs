using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lista<T>
        where T : new() // Me tengo que asegurar T sea público y tenga un constructor por defecto
    {
        // En este caso el atributo es privado pero como es una colección de objetos me admite que la seralización Xml a que sea una propiedad de al menos sólo lectura.
        private List<T> items;

        private string nombreLista;

        // Constructor público y sin parametros
        public Lista()
        {
            this.nombreLista = "Mi Listita";
            this.items = new List<T>();
        }

        // Propiedad pública de lectura y escritura de nombreLista
        public string NombreLista
        {
            get { return this.nombreLista; }
            set { this.nombreLista = value; }
        }

        // Propiedad pública de sólo lectura de items
        public List<T> Items
        {
            get { return this.items; }
        }

    }
}
