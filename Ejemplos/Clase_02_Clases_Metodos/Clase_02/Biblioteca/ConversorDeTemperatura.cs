using System;

namespace Biblioteca
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        /// <summary>
        /// Convierte una temperatura en grados Celsius a grados Kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">Temperatura en grados Celsius a convertir</param>
        /// <returns>Temperatura Kelvin</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;
            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;
            return temperaturaCelsius;
        }
    }
}
