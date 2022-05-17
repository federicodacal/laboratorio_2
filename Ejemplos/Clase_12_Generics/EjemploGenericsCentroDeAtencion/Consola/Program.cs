using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona() { Apellido = "Perez", Nombre = "Jorge", Dni = 4275981 };
            Persona persona2 = new Persona() { Apellido = "Gomez", Nombre = "José", Dni = 3267923 };
            Animal animal = new Animal() { Especie = "Perro", Raza = "Husky", Nombre = "Perrito", Peso = 6.5F };
            Animal animal2 = new Animal() { Especie = "Gato", Raza = "Siamés", Nombre = "Gatito", Peso = 4.65F };

            CentroDeAtencion<Persona> centroDePersona = new CentroDeAtencion<Persona>();

            centroDePersona.Agregar(persona);
            centroDePersona.Agregar(persona2);
            Console.WriteLine(centroDePersona.MostrarLista());
            
            CentroDeAtencion<Animal> centroDeAnimal = new CentroDeAtencion<Animal>();

            centroDeAnimal.Agregar(animal);
            centroDeAnimal.Agregar(animal2);
            Console.WriteLine(centroDeAnimal.MostrarLista());
            
        }
    }
}
