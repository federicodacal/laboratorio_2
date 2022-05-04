using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Perez", "Juan", "1200");
            Estudiante e2 = new Estudiante("Fernandez", "Ana", "1100");
            Estudiante e3 = new Estudiante("Pepito", "Pepe", "1250");

            e1.SetNotaPrimerParcial(4);
            e1.SetNotaSegundoParcial(5);
                
            e2.SetNotaPrimerParcial(3);
            e2.SetNotaSegundoParcial(7);
            
            e3.SetNotaPrimerParcial(6);
            e3.SetNotaSegundoParcial(10);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
            Console.WriteLine();
        }
    }
}
