using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    //10.PuestoPrioritario:
    //  a.Implementa IAtendedor.
    //  b.Por defecto un puesto prioritario será de MAX_UNIDADES con 15 propductos.
    //  c.La propiedad NombrePuestoAtencion retornara "Puesto de atencion Prioritario de tipo [tipo]”
    //  d.La sobrecarga del operador  ==  comparara un PuestoPrioritario con un cliente para determinar si puede ser atendido por dicho puesto.
    //      Se retornará True si puesto es de tipo ANT_ESPECIAL y el cliente requiere prioridad, o si el tipo es MAX_UNIDADES y la cantidad de productos del cliente es menor a los permitidos en el puesto de atención.
    //  e.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
    //      De lo contrario retira el primer cliente de la Queue y verifica si este puede ser atendido de forma prioritaria.
    //      En caso afirmativo retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.
    //      En caso negativo se lanzará una excepción ClienteNoAtendidoException. 

    public class PuestoPrioritario : IAtendedor
    {
        public enum ETipo { MAX_UNIDADES, ATN_ESPECIAL }

        private int cantProductos;
        private ETipo tipo;
        private Queue<Cliente> filaClientes;

        public PuestoPrioritario():this(500, ETipo.MAX_UNIDADES)
        {

        }

        public PuestoPrioritario(int cantProductos, ETipo tipo)
        {
            this.cantProductos = cantProductos;
            this.tipo = tipo;
            this.filaClientes = new Queue<Cliente>();
        }

        public ETipo Tipo
        {
            get { return this.tipo; }
        }

        public Queue<Cliente> FilaClientes
        {
            get => this.filaClientes;
            set => this.filaClientes = value;
        }

        public string NombrePuestoAtencion
        { 
            get => $"Puesto de atencion Prioritario de tipo {this.Tipo}"; 
        }

        public string AtenderClientes()
        {
            if(this.FilaClientes.Count > 0)
            {
                Cliente cli = this.FilaClientes.Dequeue();
                if(this == cli)
                {
                    return $"Cliente atendido en... {this.NombrePuestoAtencion}";
                }
                else
                {
                    throw new ClienteNoAtendidoException();
                }
            }
            else
            {
                return "Sin Clientes";
            }
        }

        public static bool operator ==(PuestoPrioritario puesto, Cliente cliente)
        {
            bool rta = false;
            if(puesto is not null && cliente is not null)
            {
                if(puesto.Tipo == ETipo.MAX_UNIDADES && puesto.cantProductos >= cliente.CantProductos)
                {
                    rta = true;
                }
                else if(puesto.Tipo == ETipo.ATN_ESPECIAL && cliente.Prioridad)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(PuestoPrioritario puesto, Cliente cliente)
        {
            return !(puesto == cliente);
        }
    }
}
