using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class Veterinaria
    {
        private static string nombre;
        private static List<Cliente> clientes;
        
        static Veterinaria()
        {
            Veterinaria.clientes = new List<Cliente>();
            Veterinaria.nombre = "********* Perritos y Gatitos :D *********";
        }

        public static bool AgregarCliente(Cliente c)
        {
            bool rta = false;
            if (c is not null && Veterinaria.clientes is not null)
            {
                Veterinaria.clientes.Add(c);
                rta = true;
            }
            return rta;
        }


        public static string MostrarClientes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Veterinaria.nombre}");
            if(Veterinaria.clientes is not null)
            {
                foreach (Cliente item in Veterinaria.clientes)
                {
                    sb.AppendLine($"{item.Mostrar()}");
                }
            }
            return sb.ToString();
        }
    }
}
