using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Gondola<Juguete> gondolaJuguetes = new Gondola<Juguete>(1000, "A");

            Gondola<Bebida> gondolaBebidas = new Gondola<Bebida>(1001, "B");

            Gondola<Lacteo> gondolaLacteos = new Gondola<Lacteo>(1002, "C");

            gondolaJuguetes.Agregar(new Juguete());

            gondolaBebidas.Agregar(new Bebida());

            gondolaLacteos.Agregar(new Lacteo());
        }
    }
}
