using System;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe", "Perez");
            Persona persona2 = new Persona("Juana", "J.");

            try
            {
                Persona.GuardarXml(persona1);
                Persona.GuardarJson(persona2);

                Persona p1 = Persona.LeerXml(Path.Combine(Persona.Ruta, "personaXml.xml"));
                Persona p2 = Persona.LeerJson(Path.Combine(Persona.Ruta, "personaJson.json"));

                Console.WriteLine($"Xml: {p1.ToString()}");
                Console.WriteLine($"Json: {p2.ToString()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
