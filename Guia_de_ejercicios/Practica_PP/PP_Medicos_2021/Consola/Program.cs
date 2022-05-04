using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital h = "Público";

            h += new Medico("Perez", 24, DateTime.Now, Especialidad.Cirujano);
            h += new MedicoEgresado(new Medico("Jorge", 124, new DateTime(2022,5,3), Especialidad.Clinico));
            h += new Medico("Martes", 44, DateTime.Now, Especialidad.Pediatra);
            h += new Medico("Marcelo", 144, DateTime.Now, Especialidad.Pediatra);
            h += new MedicoEgresado(new Medico("Perez", 24, DateTime.Now, Especialidad.Cirujano));

            Console.WriteLine(h.ToString());
            Console.WriteLine();
            Console.WriteLine(h[2]);
            Console.WriteLine();

            h -= new Medico("Marcelo", 144, DateTime.Now, Especialidad.Pediatra);
            Console.WriteLine(h.ToString());

        }
    }
}
