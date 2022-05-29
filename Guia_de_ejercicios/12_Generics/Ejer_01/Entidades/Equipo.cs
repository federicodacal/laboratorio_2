using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Ficha()
        {
            return $"{this.GetType().Name}: {this.nombre}. Fundado el {this.fechaCreacion.ToShortDateString()}.";
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool rta = false;
            if(e1 is not null && e2 is not null)
            {
                rta = e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
            }
            return rta;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
