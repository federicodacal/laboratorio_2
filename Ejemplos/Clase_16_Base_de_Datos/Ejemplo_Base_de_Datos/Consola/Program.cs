using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Console.WriteLine("*********** READ ***********");
                List<Persona> personas = PersonaAccesoDatos.Leer();

                foreach (Persona item in personas)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();

                Console.WriteLine("*********** DELETE by ID ***********");
                PersonaAccesoDatos.Eliminar(5);

                personas = PersonaAccesoDatos.Leer();
                foreach (Persona item in personas)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("*********** INSERT ***********");

                Persona persona = new Persona("Lautaro", "Galarza", 25);

                PersonaAccesoDatos.Guardar(persona);

                List<Persona> lista2 = PersonaAccesoDatos.Leer();
                foreach (Persona item in lista2)
                {
                    Console.WriteLine(item.ToString());
                }
                */
                Console.WriteLine("*********** UPDATE ***********");
                Persona persona = new Persona(6, "Lucas", "Rodriguez", 28);

                PersonaAccesoDatos.Modificar(persona);

                List<Persona> lista2 = PersonaAccesoDatos.Leer();
                foreach (Persona item in lista2)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
