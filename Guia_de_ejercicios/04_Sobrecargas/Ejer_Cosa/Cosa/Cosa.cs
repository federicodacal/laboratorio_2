using System;

namespace Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa(DateTime fecha, int entero, string cadena)
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = fecha;
        }

        public Cosa(int entero, string cadena):this(DateTime.Now,entero,cadena)
        {

        }

        public Cosa(string cadena):this(DateTime.Now,10,cadena)
        {

        }

        public Cosa():this(DateTime.Now,10,"sin valor")
        {

        }

        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }

        public void EstablecerValor (string valor)
        {
            this.cadena = valor;
        }

        public void EstablecerValor (DateTime valor)
        {
            this.fecha = valor;
        }

        private string Mostrar()
        {
            return $"{this.entero} | {this.cadena} | {this.fecha.ToShortDateString()}";
        }

        public static string Mostrar(Cosa c)
        {
            return c.Mostrar();
        }
    }
}
