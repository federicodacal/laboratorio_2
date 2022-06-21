using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //11.	PuestoNoPrioritario:
    //  a.Implementa IAtendedor.
    //  b.La propiedad NombrePuestoAtencion retornara "Puesto de atención No Prioritario”
    //  c.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
    //      De lo contrario retira el primer cliente de la Queue y retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.

    public class PuestoNoPrioritario : IAtendedor
    {
        private Queue<Cliente> filaClientes;

        public PuestoNoPrioritario()
        {
            this.filaClientes = new Queue<Cliente>();
        }

        public Queue<Cliente> FilaClientes 
        {
            get => this.filaClientes;
            set => this.filaClientes = value;
        }

        public string NombrePuestoAtencion => "Puesto de atención No Prioritario";

        public string AtenderClientes()
        {
            if(this.FilaClientes.Count > 0)
            {
                this.FilaClientes.Dequeue();
                return $"Cliente atendido en... {this.NombrePuestoAtencion}";
            }
            else
            {
                return "Sin Clientes";
            }
        }
    }
}
