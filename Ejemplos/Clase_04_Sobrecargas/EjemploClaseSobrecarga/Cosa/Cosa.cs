using System;

namespace Entidad
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(DateTime fecha, int entero, string cadena):this(entero,cadena)
        {
            this.fecha = fecha;
        }

        public Cosa(int entero, string cadena):this(cadena)
        {
            this.entero = entero;
        }

        public Cosa(string cadena):this()
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(int unEntero)
        {
            this.entero = unEntero;
        }

        public void EstablecerValor(string unaCadena)
        {
            this.cadena = unaCadena;
        }

        public void EstablecerValor(DateTime unaFecha)
        {
            this.fecha = unaFecha;
        }

        private string Mostrar() // de instancia
        {
            return $"Entero: {this.entero} \nCadena: {this.cadena} \nFecha: {this.fecha}";
        }

        public static string Mostrar(Cosa c) // de clase
        {
            return c.Mostrar();
        }
    }
}
