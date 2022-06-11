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
                Console.WriteLine("*********** READ ***********");
                List<Persona> personas = PersonaAccesoDatos.Leer();

                foreach (Persona item in personas)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("*********** DELETE by ID ***********");
                PersonaAccesoDatos.Eliminar(8);

                personas = PersonaAccesoDatos.Leer();
                foreach (Persona item in personas)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*********** INSERT ***********");

                Persona persona = new Persona("Ale", "Bonggio", 30);

                PersonaAccesoDatos.Guardar(persona);

                List<Persona> lista2 = PersonaAccesoDatos.Leer();
                foreach (Persona item in lista2)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine();
                
                Console.WriteLine("*********** UPDATE ***********");
                Persona otraPersona = new Persona(6, "Lucas Damian", "Rodriguez", 29);

                PersonaAccesoDatos.Modificar(otraPersona);

                List<Persona> lista3 = PersonaAccesoDatos.Leer();
                foreach (Persona item in lista3)
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
