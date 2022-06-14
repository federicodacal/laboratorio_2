using System;
using Entidad;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa unaCosa = new Cosa();

            Cosa c1 = new Cosa();

            DateTime f = new DateTime(2021, 9, 25);

            Cosa c2 = new Cosa(f,25,"Constructor");
            Cosa c3 = new Cosa(99,"Cadena");
            Cosa c4 = new Cosa("Sobrecarga");
            
            DateTime fecha;
            fecha = new DateTime(2021, 10, 5);

            unaCosa.EstablecerValor(200);
            unaCosa.EstablecerValor("Hola");
            unaCosa.EstablecerValor(fecha);

            Console.WriteLine(Cosa.Mostrar(unaCosa));
            Console.WriteLine();

            Console.WriteLine(Cosa.Mostrar(c1)); 
            Console.WriteLine();
            Console.WriteLine(Cosa.Mostrar(c2)); 
            Console.WriteLine();
            Console.WriteLine(Cosa.Mostrar(c3)); 
            Console.WriteLine();
            Console.WriteLine(Cosa.Mostrar(c4));
            Console.WriteLine();
        }
    }
}
