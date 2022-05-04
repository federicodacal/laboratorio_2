using System;
using System.Collections;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Array Unidimensional

            string[] nombres = new string[4];

            nombres[0] = "Ale";
            nombres[1] = "Esteban";
            nombres[3] = "Pepe";

            int[] edades = { 12, 45, 20, 25, 50 };

            Console.WriteLine($"Longitud del array de nombres: {nombres.Length}");
            Console.WriteLine($"Longitud del array de edades: {edades.Length}");
            Console.WriteLine();

            Console.WriteLine("Nombres: ");
            for (int i = 0; i < nombres.Length; i++)
            {
                if(nombres[i] is not null)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Edades: ");
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] > 0)
                {
                    Console.WriteLine(edades[i]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Recorrer nombres con foreach:");
            foreach (string item in nombres)
            {
                if(item is not null)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Buscar por indice");
            int indice=-1111;
            foreach (string item in nombres)
            {
                indice = Array.IndexOf(nombres, "Pepe");
            }
            Console.WriteLine(indice);
            Console.WriteLine();

            Console.WriteLine("Resize de array");
            Array.Resize(ref nombres, 10);

            nombres[8] = "Fede";
            Console.WriteLine("Recorrer nombres con foreach:");
            foreach (string item in nombres)
            {
                if (item is not null)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
            #endregion

            #region List

            Console.WriteLine("****************** LIST ******************");
            Console.WriteLine();

            List<string> listaDeNombres = new List<string>();

            listaDeNombres.Add("Jorge");
            listaDeNombres.Add("Romeo");
            listaDeNombres.Add("Julieta");
            listaDeNombres.Add("Arturo");

            Console.WriteLine($"Lista de nombres con {listaDeNombres.Count} elementos");
            foreach (string item in listaDeNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            listaDeNombres.Insert(1, "Ale");
            Console.WriteLine($"Lista de nombres con {listaDeNombres.Count} elementos");
            foreach (string item in listaDeNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            listaDeNombres.Remove("Jorge");
            Console.WriteLine($"Lista de nombres con {listaDeNombres.Count} elementos");
            foreach (string item in listaDeNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Ordenar lista: ");
            List<int> numerosOrden = new List<int>();

            numerosOrden.Add(2);
            numerosOrden.Add(8);
            numerosOrden.Add(10);
            numerosOrden.Add(4);
            numerosOrden.Add(7);
            numerosOrden.Add(0);

            Console.WriteLine("Lista inicial");
            foreach (int item in numerosOrden)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            numerosOrden.Sort(); // Criterio por defecto
            Console.WriteLine("Lista ordenada");
            foreach (int item in numerosOrden)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            numerosOrden.Sort(Program.Comparar); // Criterio por Metodo 'Comparar'
            Console.WriteLine("Lista ordenada");
            foreach (int item in numerosOrden)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            #endregion

            #region Dictionary

            Console.WriteLine("****************** DICCIONARIO ******************");
            Console.WriteLine();

            Dictionary<string, int> agenda = new Dictionary<string, int>();

            agenda.Add("Ale", 123456);
            agenda.Add("Diego", 4455332);
            agenda.Add("Esteban", 4455332);

            foreach (KeyValuePair<string,int> item in agenda)
            {
                Console.WriteLine($"La clave es: {item.Key} y su valor es: {item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine(agenda.ContainsKey("Esteban"));
            Console.WriteLine(agenda.ContainsKey("Pepe"));
            Console.WriteLine(agenda.ContainsValue(123456));

            Console.WriteLine();

            #endregion

            #region Queue

            Console.WriteLine("****************** QUEUE ******************");
            Console.WriteLine();

            Queue<string> colaDeAtencion = new Queue<string>();

            // Agregar elemento al final
            colaDeAtencion.Enqueue("Juan");
            colaDeAtencion.Enqueue("Fede");
            colaDeAtencion.Enqueue("Esteban");

            Console.WriteLine($"Cantidad de clientes en espera {colaDeAtencion.Count}");
            foreach (string item in colaDeAtencion)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            colaDeAtencion.Dequeue();
            foreach (string item in colaDeAtencion)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Proximo por ser atendido: ");
            Console.WriteLine(colaDeAtencion.Peek());
            Console.WriteLine();

            #endregion

            #region Stack


            Console.WriteLine("****************** STACK ******************");
            Console.WriteLine();

            Stack<char> letras = new Stack<char>();

            letras.Push('H');
            letras.Push('O');
            letras.Push('L');
            letras.Push('A');

            foreach (char item in letras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Siguiente sin eliminar");
            Console.WriteLine(letras.Peek());

            Console.WriteLine("Mostrar y eliminar siguiente elemento");
            Console.WriteLine(letras.Pop());
            Console.WriteLine();

            foreach (char item in letras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            #endregion

            #region SortedList
            Console.WriteLine("****************** SORTED LIST ******************");
            Console.WriteLine();

            SortedList<string, string> profesores = new SortedList<string, string>();

            profesores.Add("Octavio", "Programacion III");
            profesores.Add("Ale", "Programacion II");
            profesores.Add("Baus", "Programacion I");

            foreach (KeyValuePair<string,string> item in profesores)
            {
                Console.WriteLine($"Profesor: {item.Key} | Materia: {item.Value}");
            }

            Console.WriteLine();
            #endregion
        }

        // Orden DESC
        // Si A es menor a B devuelve un negativo
        // Si A es mayor a B devuelve un positivo
        // Si son iguales devuelve 0
        public static int Comparar(int a, int b) 
        {
            return b - a;
        }
    }
}
