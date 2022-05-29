using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Paloma paloma = new Paloma(1.2F);
            Courier courier = new Courier("Juan", "Carlos", "34354", 5000);
            Carta carta = new Carta("A4", 1, "Faber");
            Email email = new Email("origen@gmail.com", "destino@gmail.com");
            Cuervo cuervo = new Cuervo(2.3F);

            IMensaje mensaje = paloma; // Guardo variable de tipo paloma en una referencia de mensaje

            Console.WriteLine(mensaje.EnviarMensaje()); // Muestra "Paloma Mensajera"

            mensaje = courier; // Guardo variable de tipo courier en una referencia de mensaje

            Console.WriteLine(mensaje.EnviarMensaje()); // Muestra "Completar la ficha"

            mensaje = email; // Guardo variable de tipo email en una referencia de mensaje

            Console.WriteLine(mensaje.EnviarMensaje()); // Muestra "Conectado a Internet"

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine();

            List<IMensaje> mensajes = new List<IMensaje>();
            mensajes.Add(paloma);
            mensajes.Add(courier);
            mensajes.Add(carta);
            mensajes.Add(email);
            mensajes.Add(cuervo);

            foreach (IMensaje item in mensajes)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

            string mensajeSecreto = ((IEncriptado)cuervo).EnviarMensaje();
            Console.WriteLine(mensajeSecreto);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine();

            foreach (IMensaje item in mensajes)
            {
                Console.WriteLine(ClasePrueba.Probar(item));
            }
        }
    }
}
