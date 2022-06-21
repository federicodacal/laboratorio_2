using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogDao
    {
        private static string connectionString;
        private static SqlConnection connection;

        static LogDao()
        {
            LogDao.connectionString = @"Data Source=localhost;Initial Catalog=bomberos-sp; Integrated Security=True";
            LogDao.connection = new SqlConnection(connectionString);
        }

        public void Save(string mensaje)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.log (entrada, alumno) VALUES (@mensaje, 'Federico')", connection);
                sqlCommand.Parameters.AddWithValue("@mensaje", mensaje);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public string Read()
        {
            List<string> registers = new List<string>();

            try
            {
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM dbo.log";
                command.Connection = LogDao.connection;

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string register = dataReader.GetInt32(0).ToString();
                    register += " " + dataReader.GetString(1);
                    register += " " + dataReader.GetString(2);

                    registers.Add(register);
                }

                dataReader.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return registers.ToString();
        }
    }
    
}
