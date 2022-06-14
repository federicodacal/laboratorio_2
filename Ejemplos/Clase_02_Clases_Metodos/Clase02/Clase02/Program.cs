using System;
using Entidades;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase.Mostrar();

            MiClase.entero = 88;
            MiClase.cadena = "hola";

            MiClase.Mostrar();

            MiClase.Guardar(99, "chau");

            MiClase.Mostrar();

            Console.ReadLine();


            #region tryparse

            Console.Clear();

            int num;
            bool rta = int.TryParse("5", out num);

            if (rta == true)
            {
                Console.WriteLine("Éxito!, el número es {0}", num);
            }
            else
            {
                Console.WriteLine("Error! Formato incorrecto.");
            }

            while ( ! int.TryParse("5", out num))
            {
                Console.WriteLine("ERROR. Ingrese un valor numérico válido!!!");
            }

            Console.WriteLine("Su número es {0}", num);

            Console.ReadLine();

            #endregion
        }
    }
}
