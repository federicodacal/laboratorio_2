using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRspectoDolar;

        static Dolar()
        {
            Dolar.cotizRspectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion):this(cantidad)
        {
            Dolar.cotizRspectoDolar = cotizacion;
        }

        public double GetCantidad
        {
            get { return this.cantidad; }
        }

        public static double GetCotizacion
        {
            get { return Dolar.cotizRspectoDolar; }
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
         
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion);
        }

        // ---------------- Comparadores y operaciones ---------------- //
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad == ((Dolar)e).GetCantidad);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad - ((Dolar)e).GetCantidad));
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad + ((Dolar)e).GetCantidad));
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad - ((Dolar)p).GetCantidad));
        }
    }
}
