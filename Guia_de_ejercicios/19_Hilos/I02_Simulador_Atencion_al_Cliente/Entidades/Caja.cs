using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{

    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);
            
        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        static Caja()
        {
            Caja.random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            this.nombreCaja = nombreCaja;
            this.clientesALaEspera = new Queue<string>();
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public string NombreCaja
        {
            get { return this.nombreCaja; }
        }

        public int CantidadClientesALaEspera
        {
            get { return this.clientesALaEspera.Count; }
        }

        internal void AgregarCliente(string cliente)
        {
            this.clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(this.AtenderClientes);

            //Task t = new Task(this.AtenderClientes);
            //t.Start();
            //return t;
        }

        private void AtenderClientes()
        {
            while (true)
            {
                if (this.clientesALaEspera.Any()) // Any determina si la colección contiene algún elemento
                {
                    string cliente = this.clientesALaEspera.Dequeue();
                    if(this.delegadoClienteAtendido is not null)
                    {
                        this.delegadoClienteAtendido.Invoke(this, cliente);
                    }
                    Thread.Sleep(random.Next(1000, 5000)); // Estoy en el hilo secundario, ese es el hilo que se suspende
                }
            }
        }

    }
}
