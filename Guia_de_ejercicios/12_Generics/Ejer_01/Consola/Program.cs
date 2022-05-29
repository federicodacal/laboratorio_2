using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Bundesliga");

            EquipoFutbol e1 = new EquipoFutbol("Frankfurt", new DateTime(1919, 10, 22));
            EquipoFutbol e2 = new EquipoFutbol("Bayern München", new DateTime(1901, 04, 18));
            EquipoFutbol e3 = new EquipoFutbol("Borussia Dortmund", new DateTime(1903, 01, 09));
            EquipoFutbol e4 = new EquipoFutbol("Schalke 04", new DateTime(1899, 02, 15));
            EquipoFutbol e5 = new EquipoFutbol("Bayer Leverkusen", new DateTime(1925, 11, 16));
            EquipoFutbol e6 = new EquipoFutbol("RB Leipzig");

            torneoFutbol += e1;

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine();

            torneoFutbol += e2;
            torneoFutbol += e3;
            torneoFutbol += e4;
            torneoFutbol += e5;
            torneoFutbol += e6;
            torneoFutbol += e1;
            torneoFutbol += e6;            

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine();

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine();

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            EquipoBasquet eb1 = new EquipoBasquet("LA Lakers", new DateTime(1920, 10, 22));
            EquipoBasquet eb2 = new EquipoBasquet("Chicago Bulls", new DateTime(1960, 04, 18));
            EquipoBasquet eb3 = new EquipoBasquet("Boston Celtics", new DateTime(1953, 01, 09));
            EquipoBasquet eb4 = new EquipoBasquet("Golden State Warriors", new DateTime(1969, 02, 15));
            EquipoBasquet eb5 = new EquipoBasquet("New York Knicks", new DateTime(1939, 02, 15));

            torneoBasquet += eb1;
            torneoBasquet += eb2;
            torneoBasquet += eb3;
            torneoBasquet += eb4;
            torneoBasquet += eb5;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine();

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
