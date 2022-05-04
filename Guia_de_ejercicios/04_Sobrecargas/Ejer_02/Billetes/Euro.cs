using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRspectoDolar;

        static Euro()
        {
            Euro.cotizRspectoDolar = 1/1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRspectoDolar = cotizacion;
        }

        public double GetCantidad
        {
            get { return this.cantidad; }
        }

        public static double GetCotizacion
        {
            get { return Euro.cotizRspectoDolar; }
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Dolar.GetCotizacion);
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }

        public static bool operator ==(Peso d, Euro e)
        {
            return (d.GetCantidad == ((Dolar)e).GetCantidad);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
    }
}
