using System;
using Veterinaria;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota[] mascotas = new Mascota[3];

            Mascota felix = new Mascota("Felix", new DateTime(2009,08,02),"Gato");
            Mascota salem = new Mascota("Salem", new DateTime(1990, 06, 06), "Gato");

            mascotas[0] = felix;
            mascotas[1] = salem;
            mascotas[2] = new Mascota("Buddy", new DateTime(2014, 11, 23), "Perro");

            Console.WriteLine($"{felix.GetNombre()} nació el {felix.GetFechaNacmiento()} y es un {felix.GetEspecie()}");
            Console.WriteLine($"{salem.GetNombre()} nació el {salem.GetFechaNacmiento()} y es un {salem.GetEspecie()}");
            
            foreach(Mascota mascota in mascotas)
            {   
                if(mascota != null)
                {
                    Console.WriteLine($"{mascota.GetNombre()} nació el {mascota.GetFechaNacmiento()} y es un {mascota.GetEspecie()}");
                }
            }

            mascotas[2].SetNombre("Fatiga");

            foreach (Mascota mascota in mascotas)
            {
                //if (mascota != null)
                if(!(mascota is null))
                {
                    Console.WriteLine($"{mascota.GetNombre()} nació el {mascota.GetFechaNacmiento()} y es un {mascota.GetEspecie()}");
                }
            }

        }
    }
}
