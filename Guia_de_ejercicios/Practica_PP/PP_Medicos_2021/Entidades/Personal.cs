using System;

namespace Entidades
{
    public abstract class Personal
    {
        protected string apellido;
        protected DateTime horarioEntrada;
        protected int legajo;

        public Personal(string apellido, int legajo)
            :this(apellido, legajo, DateTime.Now)
        {

        }

        public Personal(string apellido, int legajo, DateTime ingreso)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.horarioEntrada = ingreso;
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public DateTime Ingreso
        {
            get { return this.horarioEntrada; }
        }

        public int Legajo
        {
            get { return this.legajo; }
        }

        public abstract string Info { get; }

        protected virtual string ArmarInfo()
        {
            return $"{this.Apellido}, legajo: {this.legajo}";
        }

        public override string ToString()
        {
            return $"{this.ArmarInfo()} - ingreso: {this.Ingreso.ToLongTimeString()}"; 
        }

        public static explicit operator string(Personal p)
        {
            return p.legajo.ToString();
        }

        public static bool operator ==(Personal p1, Personal p2)
        {
            bool rta = false;
            if(p1 is not null && p2 is not null)
            {
                rta = p1.Apellido == p2.Apellido && p1.Legajo == p2.Legajo;
            }
            return rta;
        }

        public static bool operator !=(Personal p1, Personal p2)
        {
            return !(p1 == p2);
        }

        public static int OrdenarPorLegajoASC(Personal p1, Personal p2)
        {
            return p2.Legajo - p1.Legajo;
        }

        public static int OrdenarPorLegajoDESC(Personal p1, Personal p2)
        {
            return p1.Legajo - p2.Legajo;
        }


    }
}
