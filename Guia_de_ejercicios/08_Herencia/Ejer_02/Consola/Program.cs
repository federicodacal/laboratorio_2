using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(3434435, "Pablo");
            Jugador j2 = new Jugador(3923477, "Pedro", 10, 3);
            DirectorTecnico t1 = new DirectorTecnico("Juan",new DateTime(1965,8,11));
            DirectorTecnico t2 = new DirectorTecnico("Juan",new DateTime(1965,8,11));
            DirectorTecnico t3 = new DirectorTecnico("Jorge",new DateTime(1975,2,1));

            Console.WriteLine(t1==t2);
            Console.WriteLine(t1==t3);
            Console.WriteLine();
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(t1.MostrarDatos());
            Console.WriteLine(t2.MostrarDatos());
            Console.WriteLine(t3.MostrarDatos());


        }
    }
}
