using System;
using Entidades;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            Console.WriteLine("Ingrese usuario: ");
            username = Console.ReadLine();

            Console.WriteLine("Ingrese contraseña: ");
            password = Console.ReadLine();

            if(Sistema.VerificarUsuario(new Usuario(username, password)))
            {
                Console.WriteLine($"Bienvenid@ {username}");
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
            Console.WriteLine();

            Console.WriteLine(Sistema.ListarUsuarios());

            Console.WriteLine();

            Sistema.AgregarNuevoUsuario("", "");
            Sistema.AgregarNuevoUsuario("Romeo", "password");
            Sistema.AgregarNuevoUsuario("Juan", "micontrasenia");
            Sistema.AgregarNuevoUsuario("Juan", "soyotrojuan");

            Console.WriteLine(Sistema.ListarUsuarios());

        }
    }
}
