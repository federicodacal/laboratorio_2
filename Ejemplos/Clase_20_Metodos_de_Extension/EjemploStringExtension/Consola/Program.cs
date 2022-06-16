using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hola Mundo";
            string b = "Métodos de Extensión";
            string c = "C#";
            string d = "C# is a general-purpose, multi-paradigm programming language. C# encompasses static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented and component-oriented programming disciplines";

            Console.WriteLine($"{a}{Environment.NewLine}Tiene {a.ContarCaracteres()} caracteres, {a.ContarVocales()} vocales y {a.ContarPalabras()} palabras");
            Console.WriteLine();
            Console.WriteLine($"{b}{Environment.NewLine}Tiene {b.ContarCaracteres()} caracteres, {b.ContarVocales()} vocales y {b.ContarPalabras()} palabras");
            Console.WriteLine();
            Console.WriteLine($"{c}{Environment.NewLine}Tiene {c.ContarCaracteres()} caracteres, {c.ContarVocales()} vocales y {c.ContarPalabras()} palabras");
            Console.WriteLine();
            Console.WriteLine($"{d}{Environment.NewLine}Tiene {d.ContarCaracteres()} caracteres, {d.ContarVocales()} vocales y {d.ContarPalabras()} palabras");
            Console.WriteLine();

        }
    }
}
