using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRspectoDolar;

        static Peso()
        {
            Peso.cotizRspectoDolar = 1 / 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRspectoDolar = cotizacion;
        }

        public double GetCantidad
        {
            get { return this.cantidad; }
        }

        public static double GetCotizacion
        {
            get { return Peso.cotizRspectoDolar; }
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion);
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }


    }
}
