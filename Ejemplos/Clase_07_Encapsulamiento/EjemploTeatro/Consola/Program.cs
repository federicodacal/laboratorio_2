using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Espectador espectador = new Espectador("Pepe",40250520,15080901);

            Console.WriteLine((string)espectador);
            Console.WriteLine();

            Console.WriteLine("Intento asignar -11114 y 3945");
            espectador.Telefono = -11114;
            espectador.Dni = 3945;

            Console.WriteLine((string)espectador);
            Console.WriteLine();

            Console.WriteLine("Intento asignar 15888212 y 39400521");
            espectador.Telefono = 15888212;
            espectador.Dni = 39400521;

            Console.WriteLine((string)espectador);
            Console.WriteLine();
            Console.WriteLine("<--------------------------------------->");
            Console.WriteLine();

            Console.WriteLine("Intento asignar 'Pep3'");
            espectador.Nombre = "Pep3";

            Console.WriteLine((string)espectador);
            Console.WriteLine();

            Console.WriteLine("Intento asignar 'Pablo'");
            espectador.Nombre = "Pablo";

            Console.WriteLine((string)espectador);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("<--------------------------------------->");
            Console.WriteLine();

            Teatro teatrito = new Teatro();
            teatrito.Espectadores.Add(espectador);

            if(teatrito[39400521] is not null)
            {
                Console.WriteLine((string)teatrito[39400521]);
            }

            Console.WriteLine();

            if (teatrito[44444] is not null)
            {
                Console.WriteLine((string)teatrito[44444]);
            }
            else
            {
                Console.WriteLine("No se encontró espectador");
            }

            Console.WriteLine();
            Console.WriteLine("<--------------------------------------->");
            Console.WriteLine();

            Espectador espectadorcito = new Espectador("Juancito", 40333123, 15666787);
            Espectador otroEspectador = new Espectador("Cleto", 47331129, 15432781);
            Espectador dniRepetido = new Espectador("Marta", 40333123, 4432314);

            if(teatrito + espectadorcito)
            {
                Console.WriteLine("Se agregó");
            }
            if (teatrito + otroEspectador)
            {
                Console.WriteLine("Se agregó");
            }
            if (teatrito + dniRepetido)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }

            foreach(Espectador item in teatrito.Espectadores)
            {
                Console.WriteLine((string)item);
            }
        }
    }
}
