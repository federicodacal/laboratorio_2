using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(Estaciones.Verano)); 
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(Estaciones.Invierno)); 
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(Estaciones.Otonio)); 
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(Estaciones.Primavera)); 
        }
    }
}
