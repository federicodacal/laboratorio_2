using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2           
            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            Program.Comparar(primerTexto, segundoTexto, (txt1, txt2) => txt1.Length - txt2.Length);

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            Program.Comparar(primerTexto, segundoTexto, (txt1, txt2) => txt1.Split(' ').Length - txt2.Split(' ').Length);

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            Program.Comparar(primerTexto, segundoTexto, (txt1, txt2) => Program.ContarVocales(txt1) - Program.ContarVocales(txt2));

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            Program.Comparar(primerTexto, segundoTexto, (txt1, txt2) => Program.ContarSignosPuntuacion(txt1) - Program.ContarSignosPuntuacion(txt2));
        }

        public static void Comparar(string primerTexto, string segundoTexto, DelegadoComparacion criterio)
        {
            if (criterio(primerTexto, segundoTexto) > 0)
            {
                Console.WriteLine("El primer texto es MAYOR al segundo.");
            }
            else if (criterio(primerTexto, segundoTexto) < 0)
            {
                Console.WriteLine("El primer texto es MENOR al segundo.");
            }
            else
            {
                Console.WriteLine("El primer texto es IGUAL al segundo");
            }
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
    }
}
