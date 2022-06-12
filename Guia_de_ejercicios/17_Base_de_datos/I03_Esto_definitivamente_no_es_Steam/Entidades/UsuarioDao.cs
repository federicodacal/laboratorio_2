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
        }
    }
}
