using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Mamifero("Pepe", 14.85F, EPelaje.Corto);
            Mamifero a2 = new Mamifero("Juana", 10.5F, EPelaje.Largo);
            Mamifero a3 = new Mamifero("Floro", 2.4F, EPelaje.SinPelo);

            Console.WriteLine($"{a1.Nombre}, precio corte de pelo ${((Mamifero)a1).PrecioCortePelo}");
            Console.WriteLine($"{a2.Nombre}, precio corte de pelo ${a2.PrecioCortePelo}");
            Console.WriteLine($"{a3.Nombre}, precio corte de pelo ${a3.PrecioCortePelo}");
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            Gato gato = new Gato("Felix", 3, EPelaje.Mediano, 10);
            Perro perro = new Perro("Perrote", 7.4F, EPelaje.Largo, false);

            List<Animal> animales = new List<Animal>();
            animales.Add(gato);
            animales.Add(perro);

            foreach (Animal item in animales)
            {
                if(item is Perro)
                {
                    Console.WriteLine(((Perro)item).Ladrar());
                }
                else if(item is Gato)
                {
                    Console.WriteLine(((Gato)item).Maullar());
                }
                Console.WriteLine(item.Alimentarse()); 
            }

            Console.WriteLine("************************************");
            Console.WriteLine();

            Reptil reptil = new Reptil("Iguana", 2.2F);
            animales.Add(reptil);

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.Mostrar());
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("************************************");
            Console.WriteLine();


            foreach (Animal item in animales)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
