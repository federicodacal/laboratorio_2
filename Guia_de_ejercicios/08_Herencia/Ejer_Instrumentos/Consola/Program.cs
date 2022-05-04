using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Bateria b = new Bateria(100, "Tama", EClasificacion.Percusion, 5);
            Guitarra g = new Guitarra(200, "Fender", 6, EClasificacion.Cuerdas, ETipoGuitarra.Electrica);
            Trompeta t = new Trompeta("Carol Brass", 400, EClasificacion.Vientos, "F");
            Guitarra g2 = new Guitarra(EClasificacion.Cuerdas, ETipoGuitarra.Criolla, "Garcia", 302);
            Guitarra g3 = new Guitarra(EClasificacion.Cuerdas, ETipoGuitarra.Criolla, "Larralde", 302);
            Bateria b2 = new Bateria(105, "Yamaha", EClasificacion.Percusion, 4);

            CasaDeMusica casa = new CasaDeMusica(4);
            
            if(casa + b)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            if (casa + g)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            if (casa + t)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            if (casa + g2)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            if (casa + g3)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            if (casa + b2)
            {
                Console.WriteLine("Se agregó");
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            Console.WriteLine();
            Console.WriteLine(casa.Mostrar());

            if(casa - g)
            {
                Console.WriteLine("Se quitó");
            }
            else
            {
                Console.WriteLine("No se quitó");
            }
            Console.WriteLine();
            Console.WriteLine(casa.Mostrar());
        }
    }
}
