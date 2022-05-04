using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }


        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool rta = false;
            if(c1 is not null && c2 is not null)
            {
                rta = c1.numero == c2.numero;
            }
            return rta;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
