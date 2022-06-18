using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Socio> socios = AccesoDatos.LeerSocios();
                List<Prestamo> prestamos = AccesoDatos.LeerPrestamos();

                AccesoDatos.CargarPrestamos(socios, prestamos);

                foreach (Socio item in socios)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
