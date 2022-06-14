using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        private static float tempCelsius;
        private static float tempKelvin;
        static void Main(string[] args)
        
        {
            tempCelsius = 30;
            tempKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(tempCelsius);
            MostrarTemperaturas();
            Console.ReadKey();
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine("Temp Celsius: {0}", tempCelsius);
            Console.WriteLine("Temp Kelvin: {0}", tempKelvin);
        }
    }
}
