using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            Negocio.realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            this.clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja item in this.cajas)
            {
                hilos.Add(item.IniciarAtencion());
            }

            hilos.Add(Task.Run(this.GenerarClientes));
            hilos.Add(Task.Run(this.AsignarCajas));

            return hilos;
        }

        private void GenerarClientes()
        {
            while (true)
            {
                string cliente = realNameGenerator.Generate();
                this.clientes.Enqueue(cliente);
                Thread.Sleep(1000);
            }
        }

        private void AsignarCajas()
        {
            while (true)
            {
                // Ordeno de forma ascendente (el primero es el que menos clientes tiene)
                //this.cajas.Sort((c1, c2) => c1.CantidadClientesALaEspera - c2.CantidadClientesALaEspera);

                // Por defecto OrderBy ordena de forma ascendante (tambien está 'OrderByDescending')
                Caja caja = this.cajas.OrderBy(c => c.CantidadClientesALaEspera).First();

                string cliente = null;
                if (this.clientes.TryDequeue(out cliente)) // En la caja que menos clientes tiene agrego un nuevo cliente
                {
                    if (!string.IsNullOrWhiteSpace(cliente))
                    {
                        caja.AgregarCliente(cliente);
                    }
                }
            }          
        }
    }
}
