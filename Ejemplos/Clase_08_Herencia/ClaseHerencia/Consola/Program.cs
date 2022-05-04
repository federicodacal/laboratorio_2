using System;
using System.Collections.Generic;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Juan", "Perez", 35355355);
            Profesor pf = new Profesor("Programacion II", "Carlos", "Garcia", 34344344);
            Estudiante e1 = new Estudiante("Pepe", "Pepito", 39399399, 100, new List<string> {"Programacion", "Laboratorio", "Estadistica"});
            Estudiante e2 = new Estudiante(p1, 111);


            Console.WriteLine(p1.MostrarPersona());
            Console.WriteLine();
            Console.WriteLine(e1.MostrarEstudiante());
            Console.WriteLine();
            Console.WriteLine(e1.MostrarPersona());
            Console.WriteLine();
            Console.WriteLine(e2.MostrarEstudiante());

            Console.WriteLine("<------------------------------------------------->\n");

            Persona p2 = pf;
            
            // Profesor prof = p1; // No se puede

            /* Podemos guardar un objeto de tipo Profesor en un objeto de tipo Persona porque un Profesor es una Persona por medio de herencia pero una Persona no necesariamente es un Profesor por eso, a la inversa, no puedo guardar una referencia de tipo Persona en un objeto de tipo Profesor
            */

            List<Persona> personitas = new List<Persona>();
            personitas.Add(p1);
            personitas.Add(pf);
            personitas.Add(e1);

            foreach (Persona item in personitas)
            {
                Console.WriteLine(item.MostrarPersona());
            }

            Console.WriteLine();

            foreach (Persona item in personitas)
            {
                if(item is Profesor)
                {
                    Console.WriteLine(((Profesor)item).MostrarProfe());
                    Console.WriteLine(((Profesor)item).Corregir());
                }
                else if(item is Estudiante)
                {
                    Console.WriteLine(((Estudiante)item).MostrarEstudiante());
                    Console.WriteLine(((Estudiante)item).Estudiar());
                }
                else
                {
                    Console.WriteLine(item.MostrarPersona());
                }
                Console.WriteLine("**********************");
            }

        }
    }
}
