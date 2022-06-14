using System;

namespace Ejemplo_Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiempo t1 = new Tiempo(21, 45, 59);
            Tiempo t2 = new Tiempo(21, 45, 59);
            Tiempo t3 = new Tiempo(12, 25, 15);

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
            Console.WriteLine(t1 == t3);

            int segundos = t1;
            Console.WriteLine(segundos);

            Tiempo tiempo = (Tiempo)"12:45:20";
            Console.WriteLine($"hora:{tiempo.hora} / minutos:{tiempo.minutos} / segundos:{tiempo.segundos}");
        }
    }
}
