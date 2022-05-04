using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Juan", "Perez", "Av. Siempreviva 2000", "440033");
            Cliente c2 = new Cliente("Ana", "Gomez", "Calle Falsa 1234", "392233");
            Cliente c3 = new Cliente("Pepo", "Peposo", "Mitre 910", "431190");

            Mascota m1 = new Mascota("Buddy", "Perro", new DateTime(2020, 5, 6));
            Mascota m2 = new Mascota("Amigo", "Perro", new DateTime(2017, 4, 9));
            Mascota m3 = new Mascota("Salem", "Gato", new DateTime(1998, 1, 12));
            Mascota m4 = new Mascota("Audrey Hepburn", "Gato", new DateTime(2015, 10, 15));
            Mascota m5 = new Mascota("Lento", "Tortuga", new DateTime(1990, 2, 9));
            Mascota m6 = new Mascota("Bigotes", "Gato", new DateTime(2022, 1, 16));

            c1.AgregarMascota(m1);
            c1.AgregarMascota(m2);

            c2.AgregarMascota(m3);
            c2.AgregarMascota(m4);

            c3.AgregarMascota(m5);
            c3.AgregarMascota(m6);

            Veterinaria.AgregarCliente(c1);
            Veterinaria.AgregarCliente(c2);
            Veterinaria.AgregarCliente(c3);

            Console.WriteLine(Veterinaria.MostrarClientes());

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            m1.Vacunar(EVacunas.Moquillo);
            m1.Vacunar(EVacunas.Rabia);
            m3.Vacunar(EVacunas.TripleFelina);
            m6.Vacunar(EVacunas.Parvovirosis);

            Console.WriteLine(Veterinaria.MostrarClientes());

        }
    }
}
