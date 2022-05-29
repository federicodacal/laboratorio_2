using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Entidades;

namespace ConsolaSerializacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Ejemplo 1");

                Personaje personaje1 = new Personaje(100, "Carpincho");

                Serializadora<Personaje>.Serializar_StreamWriter("personaje1Xml.xml", personaje1);

                Personaje pXml = Serializadora<Personaje>.Deserializar_StreamReader("personaje1Xml.xml");

                Console.WriteLine(pXml.ToString());

                Console.WriteLine("********************************************");
                Console.WriteLine("Ejemplo 2");

                Personaje personaje2 = new Mago(100, "Carpincho Mago", 250);

                Serializadora<Personaje>.Serializar_StreamWriter("personaje2Xml.xml", personaje2);

                Personaje pXml2 = Serializadora<Personaje>.Deserializar_StreamReader("personaje2Xml.xml");

                Console.WriteLine(pXml2.ToString());

                Console.WriteLine("********************************************");
                Console.WriteLine("Ejemplo 3");

                List<Personaje> personajes = new List<Personaje>();

                Personaje personaje3 = new Mago(100, "Carpincho Mistico", 500);
                Personaje personaje4 = new Guerrero(50, "Carpincho Guerrero", 75);

                personajes.Add(personaje1);
                personajes.Add(personaje2);
                personajes.Add(personaje3);
                personajes.Add(personaje4);

                Serializadora<List<Personaje>>.Serializar_StreamWriter("listaPersonajesXml.xml", personajes);

                List<Personaje> listaXml = Serializadora<List<Personaje>>.Deserializar_StreamReader("listaPersonajesXml.xml");

                foreach (Personaje item in listaXml)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("********************************************");
                Console.WriteLine("Ejemplo 4");

                Serializadora<Personaje>.Serializar_JSON("personaje1Json.json", personaje2);

                Personaje personajeJson = Serializadora<Personaje>.Deserializar_JSON("personaje1Json.json");

                Console.WriteLine(personajeJson.ToString());

                Console.WriteLine("********************************************");
                Console.WriteLine("Ejemplo 5");

                Serializadora<List<Personaje>>.Serializar_JSON("listaJson.json", personajes);

                List<Personaje> listaJson = Serializadora<List<Personaje>>.Deserializar_JSON("listaJson.json");

                foreach (Personaje item in listaJson)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("********************************************");

                Console.WriteLine("Listo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
