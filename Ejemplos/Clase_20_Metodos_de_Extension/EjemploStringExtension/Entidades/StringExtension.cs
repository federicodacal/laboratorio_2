using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class StringExtension
    {
        public static int ContarCaracteres(this string cadena)
        {
            int totalCaracteres = 0;

            if(cadena is not null)
            {
                totalCaracteres = cadena.Trim().Length;
            }
            return totalCaracteres;
        }

        public static int ContarVocales(this string cadena)
        {
            int totalVocales = 0;
            
            List<char> vocales = new List<char>()
            { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', 'á', 'é', 'í', 'ó', 'ú' }; 


            if(cadena is not null)
            {
                foreach (char item in cadena)
                {
                    if (vocales.Contains(item))
                    {
                        totalVocales++;
                    }
                }
            }
            return totalVocales;
        }

        public static int ContarPalabras(this string cadena)
        {
            int totalPalabras = 0;

            if(cadena is not null)
            {
                string[] palabras = cadena.Trim().Split(' ');

                totalPalabras = palabras.Length;
            }

            return totalPalabras;
        }
    }
}
