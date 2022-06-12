using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioDao
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static UsuarioDao()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=EJERCICIOS_UTN; Integrated Security=True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.Add(new Usuario(
                        Convert.ToInt32(dataReader["CODIGO_USUARIO"]), 
                        dataReader["USERNAME"].ToString()));
                }

                return usuarios;
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
    }
}
