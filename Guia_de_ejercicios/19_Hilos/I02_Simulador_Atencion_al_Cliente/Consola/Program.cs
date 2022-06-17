using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Caja.DelegadoClienteAtendido clienteAtendido = (caja, cliente) =>
            {
                string mensaje = $"{DateTime.Now.ToString("HH:mm:ss")} - Hilo {Task.CurrentId} - Caja {caja.NombreCaja} | Atendiendo a {cliente}. Quedan {caja.CantidadClientesALaEspera} clientes a la espera en esta caja";
                Console.WriteLine(mensaje);
            };

            Caja caja1 = new Caja("Caja 01", clienteAtendido);
            Caja caja2 = new Caja("Caja 02", clienteAtendido);

            List<Caja> cajas = new List<Caja>()
            {
                caja1, caja2
            };

            Negocio negocio = new Negocio(cajas);

            Console.WriteLine("Asignando cajas...");

            List<Task> hilos = negocio.ComenzarAtencion();

            // Evitar que se cierre la consola
            Task.WaitAll(hilos.ToArray());
        }
    }
}
