using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }
            set
            {
                if(this != value && value is not null)
                {
                   _ = this + value;
                }
            }
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            bool rta = false;
            if(n is not null && c is not null)
            {
                foreach (Cliente item in n.clientes)
                {
                    if(item == c)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool rta = false;
            if(n != c)
            {
                n.clientes.Enqueue(c);
                rta = true;
            }
            return rta;
        }

        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

    }
}
