using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi Centralita
            Centralita c = new Centralita("Mi Centralita");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            try
            {
                _ = c + l1;
                Console.WriteLine(c.ToString());
                _ = c + l2;
                Console.WriteLine(c.ToString());
                _ = c + l3;
                Console.WriteLine(c.ToString());
                _ = c + l4;
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaException e)
            {
                Console.WriteLine($"{e.Message}\nClase: {e.NombreClase}, Método: {e.NombreMetodo}");
            }

        }
    }
}
