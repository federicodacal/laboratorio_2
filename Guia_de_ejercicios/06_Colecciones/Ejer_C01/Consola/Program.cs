using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(3, "Real Madrid");

            Jugador j1 = new Jugador(5000, "Toni Kross");
            Jugador j2 = new Jugador(5001, "Karim Benzema", 10, 6);
            Jugador j5 = new Jugador(5000, "Courtois", 10, 0);
            Jugador j3 = new Jugador(5002, "Vinicius", 10, 2);
            Jugador j4 = new Jugador(5003, "Nacho", 10, 0);

            Console.WriteLine(e.Mostrar());
            Console.WriteLine("****************************");
            _=e + j1;
            _=e + j2;
            _=e + j3;
            _=e + j4;
            _=e + j5;
            Console.WriteLine();
            Console.WriteLine(e.Mostrar());
            Console.WriteLine();

        }
    }
}
