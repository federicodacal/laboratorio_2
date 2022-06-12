using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static LocalDAO()
        {
            LocalDAO.connectionString = @"Data Source=localhost;Initial Catalog=Centralita; Integrated Security=True";
            LocalDAO.command = new SqlCommand();
            LocalDAO.connection = new SqlConnection(connectionString);
            LocalDAO.command.Connection = connection;
            LocalDAO.command.CommandType = System.Data.CommandType.Text;
        }

        public List<Local> Leer()
        {
            List<Local> lista = new List<Local>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Llamadas WHERE TIPO = 0";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    lista.Add(new Local(dataReader["Origen"].ToString(), Convert.ToInt32(dataReader["Duracion"]), dataReader["Destino"].ToString(), Convert.ToSingle(dataReader["Costo"])));
                }

                return lista;
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

        public bool Guardar(Local l)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Llamadas (Duracion, Origen, Destino, Costo, Tipo) VALUES (@Duracion, @Origen, @Destino, @Costo, 0)";
                command.Parameters.AddWithValue("@Duracion", l.Duracion);
                command.Parameters.AddWithValue("@Origen", l.NroOrigen);
                command.Parameters.AddWithValue("@Destino", l.NroDestino);
                command.Parameters.AddWithValue("@Costo", l.CostoLlamada);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
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
