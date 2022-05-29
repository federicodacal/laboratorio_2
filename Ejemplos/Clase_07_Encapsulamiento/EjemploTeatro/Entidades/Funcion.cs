using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcion
    {
        private string nombreObra;
        private DateTime fechaFuncion;
        private int entradasDisponibles;

        public Funcion(string nombreObra, DateTime fechaFuncion)
        {
            this.nombreObra = nombreObra;
            this.fechaFuncion = fechaFuncion;
            this.entradasDisponibles = 100;
        }

        public string Obra
        {
            get { return this.nombreObra; }
        }

        public DateTime Fecha
        {
            get { return this.fechaFuncion; }
        }

        public int EntradasDisponibles
        {
            get { return this.entradasDisponibles; }
            set { this.entradasDisponibles = value; }
        }

        public bool HayEntradas
        {
            get { return this.entradasDisponibles > 0; }
        }

        public static implicit operator string(Funcion f)
        {
            return f.Obra;
        }

        public static bool operator ==(Funcion f1, Funcion f2)
        {
            bool rta = false;
            if(f1 is not null && f2 is not null)
            {
                rta = f1.Obra == f2.Obra && f1.Fecha == f2.Fecha;
            }
            return rta;
        }

        public static bool operator !=(Funcion f1, Funcion f2)
        {
            return !(f1 == f2);
        }

        public override string ToString()
        {
            return this.Obra;
        }
    }
}
