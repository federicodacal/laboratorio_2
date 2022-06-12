using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ProductsDAO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static ProductsDAO()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=AdventureWorks; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Product> Read()
        {
            List<Product> products = new List<Product>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Production.Product";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    products.Add(new Product(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2),
                        dataReader.GetBoolean(3),
                        dataReader.GetBoolean(4),
                        dataReader.GetInt16(6),
                        dataReader.GetInt16(7),
                        dataReader.GetDecimal(8),
                        dataReader.GetDecimal(9),
                        dataReader.GetInt32(14),
                        dataReader.GetDateTime(20),
                        dataReader.GetGuid(23)));
                }

                return products;
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
