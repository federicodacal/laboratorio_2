using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    //13.CentroDeAtencion:
    //  a.Su único constructor instanciará una colección de puestos de atencion y
    //      será el encargado de agregar el manejador IngresarCliente al evento InformarCliente de GestorBD.
    //  b.AbrirNegocio será la propiedad encargada de poner a leer los registros de la BD en un hilo secundario.
    //      Implementar lo necesario de modo que se puede cerrar y abrir el negocio.
    //  c.IngresarCliente verificara si el cliente requiere prioridad, y lo encolara en el puesto de atención que corresponda.
    //      Luego de encolarlo informar el puesto de atención a través del evento.

    public class CentroDeAtencion
    {
        public delegate void DelegadoCaja(IAtendedor puesto);

        private CancellationTokenSource cts;
        private string nombre;
        private PuestoNoPrioritario puestoNoPrioritario;
        private PuestoPrioritario puestoPrioritario;
        private Task tarea;

        public event DelegadoCaja InformarPuestoDeAtencion;

        public CentroDeAtencion(string nombre)
        {
            this.nombre = nombre;
            this.puestoNoPrioritario = new PuestoNoPrioritario();
            this.puestoPrioritario = new PuestoPrioritario();
            this.cts = new CancellationTokenSource();
            GestorBD.InformarCliente += new GestorBD.DelegadoCliente(this.IngresarCliente);
            //GetorBD.InformarCliente += this.IngresarCliente;
        }


        public bool AbrirNegocio
        {
            get
            {
                return false;
            }
            set
            {
                if (value)
                {
                    Task task = Task.Run(() => GestorBD.ObtenerCliente(cts.Token));
                }
                else
                {
                    this.cts.Cancel();
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public PuestoNoPrioritario PuestoNoPrioritario
        {
            get { return this.puestoNoPrioritario; }
        }

        public PuestoPrioritario PuestoPrioritario
        {
            get { return this.puestoPrioritario; }
        }

        public void IngresarCliente(Cliente cliente)
        {
            if (cliente.Prioridad)
            {
                this.PuestoPrioritario.FilaClientes.Enqueue(cliente);

                if (this.InformarPuestoDeAtencion is not null)
                {
                    this.InformarPuestoDeAtencion.Invoke(this.PuestoPrioritario);
                }
            }
            else
            {
                this.PuestoNoPrioritario.FilaClientes.Enqueue(cliente);

                if (this.InformarPuestoDeAtencion is not null)
                {
                    this.InformarPuestoDeAtencion.Invoke(this.PuestoNoPrioritario);
                }
            }

        }
            
        
    }
}
