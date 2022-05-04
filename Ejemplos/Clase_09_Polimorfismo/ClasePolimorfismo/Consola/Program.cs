using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal perro = new Perro();
            Animal carpincho = new Carpincho();
            Animal gato = new Gato();
            Perro perrito = new Perro();
            Gato gatito = new Gato();
            Animal perritoBebe = new Cachorro();

            Console.WriteLine(animal.GetType().Name + " " + animal.EmitirSonido());
            Console.WriteLine(perro.GetType().Name + " " + perro.EmitirSonido());
            Console.WriteLine(carpincho.GetType().Name + " " + carpincho.EmitirSonido());
            Console.WriteLine(gato.GetType().Name + " " + gato.EmitirSonido());
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            List<Animal> animalitos = new List<Animal>();
            animalitos.Add(animal);
            animalitos.Add(perro);
            animalitos.Add(carpincho);
            animalitos.Add(gato);
            animalitos.Add(perrito);
            animalitos.Add(gatito);
            animalitos.Add(perritoBebe);

            foreach (Animal item in animalitos)
            {
                Program.EscucharAnimal(item);
            }
            Console.WriteLine();
        }

        public static void EscucharAnimal(Animal a)
        {
            Console.WriteLine($"Este animal hace... {a.EmitirSonido()}");
        }
    }
}
