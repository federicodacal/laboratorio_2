using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen.ValidarStock_1(5, MostrarMensajeOk, MostrarMensajeTodoMal);
            Almacen.ValidarStock_1(16, MostrarMensajeOk, MostrarMensajeTodoMal);
            Almacen.ValidarStock_1(10, MostrarMensajeOk, MostrarMensajeTodoMal);
        }

        private static void MostrarMensajeOk()
        {
            Console.WriteLine("Stock Ok");
        }

        private static void MostrarMensajeTodoMal()
        {
            Console.WriteLine("Stock insuficiente");
        }
    }
}
