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
        private static SqlCommand command;
        private static SqlConnection connection;
        private static string connectionString;

        static AccesoDatos()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=Final_Barcos; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static bool Guardar(string mensaje)
        {
            bool rta = false;
            try
            {
                command.Parameters.Clear(); // Para miembros estáticos
                connection.Open();
                command.CommandText = $"INSERT INTO Final_Barcos.dbo.reparaciones (mensaje, alumno) VALUES (@mensaje, @alumno)";
                command.Parameters.AddWithValue("@mensaje", mensaje);
                command.Parameters.AddWithValue("@alumno", "Federico");
                
                int affectedRows = command.ExecuteNonQuery();

                if(affectedRows == 0)
                {
                    rta = false;
                }
                else
                {
                    rta = true;
                }
            }
            catch (Exception e)
            {
                rta = false;
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return rta;
        }
    }
}
