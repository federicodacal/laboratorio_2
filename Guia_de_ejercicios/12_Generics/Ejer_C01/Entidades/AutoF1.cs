using System;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia)
            :base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        public string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - Caballos de Fuerza: {this.CaballosDeFuerza}";
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool rta = false;
            if(a1 is not null && a2 is not null)
            {
                rta = (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.caballosDeFuerza == a2.caballosDeFuerza;
            }
            return rta;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


    }
}
