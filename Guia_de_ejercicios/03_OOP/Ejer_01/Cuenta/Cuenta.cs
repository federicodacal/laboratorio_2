using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidadDinero;

        public Cuenta(string titular, decimal cantidadDinero)
        {
            this.titular = titular;
            this.cantidadDinero = cantidadDinero;
        }

        public string Titular
        {
            get { return this.titular; }
        }

        public decimal CantidadDinero
        {
            get { return this.cantidadDinero; }
        }

        public string Mostrar()
        {
            return $"{this.Titular}: ${this.CantidadDinero}";
        }

        public void Ingresar(decimal cantidadIngresada)
        {
            if(cantidadIngresada > 0)
            {
                this.cantidadDinero += cantidadIngresada;
            }
        }

        public void Retirar(decimal cantidadARetirar)
        {
            if(cantidadARetirar > 0)
            {
                this.cantidadDinero -= cantidadARetirar;
            }
        }
    }
}
