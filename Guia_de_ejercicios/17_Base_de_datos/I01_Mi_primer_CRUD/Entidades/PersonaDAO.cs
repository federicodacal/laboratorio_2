using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaDAO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static PersonaDAO()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=EjerCRUD; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Persona p)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {

            }
        }

    }
}
