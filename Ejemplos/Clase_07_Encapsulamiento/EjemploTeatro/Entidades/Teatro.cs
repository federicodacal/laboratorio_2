using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Teatro
    {
        private string nombre;
        private List<Espectador> espectadores;
        private List<Funcion> obrasDisponibles;
        private int capacidad;

        public Teatro()
        {
            this.nombre = "Teatro de Juana";
            this.capacidad = 100;
            this.espectadores = new List<Espectador>();
            this.obrasDisponibles = new List<Funcion>();
            this.obrasDisponibles.Add(new Funcion("La Traviata", new DateTime(2022, 5, 22)));
            this.obrasDisponibles.Add(new Funcion("La Traviata", new DateTime(2022, 6, 1)));
            this.obrasDisponibles.Add(new Funcion("La Traviata", new DateTime(2022, 6, 4)));
            this.obrasDisponibles.Add(new Funcion("Medea", new DateTime(2022, 5, 23)));
            this.obrasDisponibles.Add(new Funcion("Medea", new DateTime(2022, 6, 20)));
            this.obrasDisponibles.Add(new Funcion("Norma", new DateTime(2022, 5, 24)));
            this.obrasDisponibles.Add(new Funcion("Carmen", new DateTime(2022, 5, 25)));
            this.obrasDisponibles.Add(new Funcion("Carmen", new DateTime(2022, 7, 22)));
            this.obrasDisponibles.Add(new Funcion("Tosca", new DateTime(2022, 5, 26)));
            this.obrasDisponibles.Add(new Funcion("Rusalka", new DateTime(2022, 5, 27)));
            this.obrasDisponibles.Add(new Funcion("Lago de los Cisnes", new DateTime(2022, 5, 28)));
            this.obrasDisponibles.Add(new Funcion("Lago de los Cisnes", new DateTime(2022, 6, 12)));
            this.obrasDisponibles.Add(new Funcion("Lago de los Cisnes", new DateTime(2022, 7, 5)));
            this.obrasDisponibles.Add(new Funcion("Madame Butterfly", new DateTime(2022, 8, 5)));
            this.obrasDisponibles.Add(new Funcion("Romeo y Julieta", new DateTime(2022, 5, 29)));
            this.obrasDisponibles.Add(new Funcion("Tristan e Isolda", new DateTime(2022, 5, 30)));
        }

        public List<Funcion> ObrasDisponbiles
        {
            get { return this.obrasDisponibles; }
        }


        public string Nombre
        {
            get { return this.nombre; }
        }

        public List<Espectador> Espectadores
        {
            get { return this.espectadores; }
        }

        public Funcion this[string nombreObra, DateTime dt]
        {
            get
            {
                if(!String.IsNullOrEmpty(nombreObra))
                {
                    foreach (Funcion item in this.ObrasDisponbiles)
                    {
                        if(item.Fecha == dt && item.Obra == nombreObra)
                        {
                            return item;
                        }
                    }
                }
                return null;
            }
        }

        public Espectador this[int dni]
        {
            get 
            {
                foreach (Espectador item in this.Espectadores)
                {
                    if(item.Dni == dni)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public static bool operator ==(Teatro t, Espectador e)
        {
            bool rta = false;
            if(t is not null && e is not null)
            {
                foreach(Espectador item in t.Espectadores)
                {
                    if(item == e)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Teatro t, Espectador e)
        {
            return !(t == e);
        }

        public static bool operator +(Teatro t, Espectador e)
        {
            bool rta = false;
            if(t != e)
            {
                t.Espectadores.Add(e);
                rta = true;
            }
            return rta;
        }

        public string MostrarEspectadores()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine("Lista de Espectadores");
            foreach (Espectador item in this.Espectadores)
            {
                sb.AppendLine((string)item);
                sb.AppendLine("**************************************");
            }
            return sb.ToString();
        }


    }
}
