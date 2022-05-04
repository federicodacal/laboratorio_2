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
            Bateria b2 = new Bateria(105, "Pearl", EClasificacion.Percusion, 7);
            Bateria b3 = new Bateria(100, "Mapex", EClasificacion.Percusion, 4);
            Bateria b4 = new Bateria(200, "Mapex", EClasificacion.Percusion, 4);
            Guitarra g2 = new Guitarra(200, "Gibson", 6, EClasificacion.Cuerdas, ETipoGuitarra.Electrica);

            CasaDeMusica casa = new CasaDeMusica(4);

            _=casa + b;
            _=casa + g;
            _=casa + t;
            _=casa + b2;

            Console.WriteLine(casa.ToString());

            Console.WriteLine();
            Console.WriteLine("Con ToString() desde Main");
            Console.WriteLine(b);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(b.Equals(g));
            Console.WriteLine(b.Equals(b3));
            Console.WriteLine(g.Equals(b4));
            Console.WriteLine(g.Equals(g2));
            Console.WriteLine();
            Console.WriteLine(b.ToString() + " HashCode: " + b.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(g.ToString() + " HashCode: " + g.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(b3.ToString() + " HashCode: " + b3.GetHashCode());
            Console.WriteLine();


            
        }
    }
}
