using System;
using System.Collections.Generic;
using System.Threading;

namespace Consola
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Receptor carpinchoReceptor = new Receptor("Carpincho Receptor");
            Receptor carpinchoProfesor = new Receptor("Carpincho Profesor");
            Perro unPerro = new Perro();

            Emisor emisor = new Emisor();

            // Instanciar delegados
            emisor.AgregarDestinatario(new DelegadoDestinatario(carpinchoReceptor.RecibirNotificacion));
            emisor.AgregarDestinatario(carpinchoProfesor.RecibirNotificacion);
            emisor.AgregarDestinatario(unPerro.Ladrar);
            emisor.AgregarDestinatario(Program.Notificar);
            emisor.AgregarDestinatario(Program.CambiarColorConsola);
            
            emisor.EmitirNotificacion();        
        }       
        
        public static void Notificar()
        {
            Console.WriteLine("¡¡¡Notificación Enviada!!!");
        }

        public static void CambiarColorConsola()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
        }
    }
}
