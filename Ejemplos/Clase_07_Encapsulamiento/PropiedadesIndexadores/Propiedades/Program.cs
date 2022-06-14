using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Test prueba = new Test();

            prueba.SetCadena("valor STRING");
            prueba.SetEntero(22);
            prueba.SetFlotante(44.56f);

            Console.WriteLine(prueba.GetCadena());
            Console.WriteLine(prueba.GetEntero());
            Console.WriteLine(prueba.GetFlotante());

            Console.WriteLine(prueba.TestToString());

            Console.ReadLine();




            #region Mejoras...

            prueba.Cadena = "otro valor STRING";
            prueba.Entero = 88;
            prueba.Flotante = 125.33f;

            Console.WriteLine(prueba.Cadena);
            Console.WriteLine(prueba.Entero);
            Console.WriteLine(prueba.Flotante);

            Console.WriteLine(prueba.TestToStringBuilder());

            Console.ReadLine();

            #region Más Mejoras...

            Console.WriteLine(prueba.PropiedadSoloLectura);

            prueba.PropiedadSoloEscritura = 88;
            prueba.PropiedadSoloEscritura = 52;

            prueba.PropiedadAutoContenida = DateTime.Now;

            Console.WriteLine(prueba.PropiedadAutoContenida.ToLongDateString());

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
