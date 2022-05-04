using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaOffShore
    {
        private Cliente duenio;
        private int numeroCuenta;
        private double saldo;

        public CuentaOffShore(Cliente duenio, int numero, double saldoInicial)
        {
            this.duenio = duenio;
            this.numeroCuenta = numero;
            this.saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, ETipoCliente tipo, int numero, double saldoInicial)
            :this(new Cliente(tipo, nombre), numero, saldoInicial)
        {

        }

        public Cliente Duenio
        {
            get { return this.duenio; }
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public static bool operator ==(CuentaOffShore c1, CuentaOffShore c2)
        {
            bool rta = false;
            if(c1 is not null && c2 is not null)
            {
                rta = c1.numeroCuenta == c2.numeroCuenta && c1.Duenio.GetAlias() == c2.Duenio.GetAlias();
            }
            return rta;
        }

        public static bool operator !=(CuentaOffShore c1, CuentaOffShore c2)
        {
            return !(c1 == c2);
        }

        public static explicit operator int(CuentaOffShore c)
        {
            return c.numeroCuenta;
        }

    }
}
