using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Consola
{
    // DECLARACION DELEGADO 'DelegadoDestinatario'
    public delegate void DelegadoDestinatario();

    public class Emisor
    {
        private List<DelegadoDestinatario> destinatarios;

        public Emisor()
        {
            this.destinatarios = new List<DelegadoDestinatario>();
        }

        public void AgregarDestinatario(DelegadoDestinatario delegadoDestinatario)
        {
            this.destinatarios.Add(delegadoDestinatario);
        }

        public void EmitirNotificacion()
        {
            Console.WriteLine("Emitiendo notificación...");

            foreach (DelegadoDestinatario delegado in this.destinatarios)
            {
                Thread.Sleep(2000);
                delegado.Invoke();
                //delegado();
            }
        }
    }
}
