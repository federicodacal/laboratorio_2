using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AccesoDatos
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static AccesoDatos()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=PRUEBA_BIBLIOTECA; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Socio> LeerSocios()
        {
            List<Socio> socios = new List<Socio>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Socios;";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Socio socio = new Socio(dataReader["nombre"].ToString(), Convert.ToInt64(dataReader["dni"]));
                    socios.Add(socio);
                }

                return socios;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static List<Prestamo> LeerPrestamos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Prestamos;";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Prestamo prestamo = new Prestamo(Convert.ToInt32(dataReader["id"]), dataReader["descripcion"].ToString(), Convert.ToInt64(dataReader["dni_socio"]));
                    prestamos.Add(prestamo);
                }

                return prestamos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void CargarPrestamos(List<Socio> socios, List<Prestamo> prestamos)
        {

            try
            {
                foreach (Socio socio in socios)
                {
                    foreach (Prestamo prestamo in prestamos)
                    {
                        if(socio is not null && prestamo is not null && socio.Dni == prestamo.DniSocio)
                        {
                            socio.Prestamos.Add(prestamo);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}
