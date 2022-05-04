using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre v = new VehiculoTerrestre(4, Colores.Rojo, 5);
            Moto m = new Moto(2, Colores.Rojo, 10, 4);
            Camion c = new Camion(8, 2, Colores.Blanco, 4, 700);
            Autmovil a = new Autmovil(4, 4, Colores.Negro, 6, 5);

            Console.WriteLine(v.Mostrar());
            Console.WriteLine();
            Console.WriteLine(m.Mostrar());
            Console.WriteLine();
            Console.WriteLine(c.Mostrar());
            Console.WriteLine();
            Console.WriteLine(a.Mostrar());
            Console.WriteLine();
        }
    }
}
