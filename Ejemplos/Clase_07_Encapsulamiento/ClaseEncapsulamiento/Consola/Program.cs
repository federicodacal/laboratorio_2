using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador(100,"Ale",10,5);

            Console.WriteLine($"ID: {jugador.Id}");

            jugador.Id = 101;
            Console.WriteLine($"ID: {jugador.Id}");

            jugador.Id = -15;
            Console.WriteLine($"ID: {jugador.Id}");

            Console.WriteLine($"Nombre: {jugador.Nombre}");

            jugador.Nombre = "Pepe";
            Console.WriteLine($"Nombre: {jugador.Nombre}");
            Console.WriteLine();

            Console.WriteLine($"Total de goles: {jugador.TotalGoles} \nPartidos jugados: {jugador.PartidosJugados} \nPromedio de goles: {jugador.PromedioGoles}");
            Console.WriteLine();

            jugador.ColorCamiseta = Jugador.Color.Blanco;

            Console.WriteLine($"Color camiseta: {jugador.ColorCamiseta} {(int)jugador.ColorCamiseta}");

            jugador.ColorCamiseta = 0;

            Console.WriteLine($"Color camiseta: {jugador.ColorCamiseta} {(int)jugador.ColorCamiseta}");

            Console.WriteLine();
            Console.WriteLine("<----------------------------------------------->");
            Console.WriteLine();

            Dias dias = new Dias();

            Console.WriteLine(dias[2]);
            Console.WriteLine(dias[3]);

            dias[3] = "Feriado";
            Console.WriteLine(dias[3]);

        }
    }
}
