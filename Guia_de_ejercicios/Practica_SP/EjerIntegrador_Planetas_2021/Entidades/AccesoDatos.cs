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
            connectionString = @"Data Source=localhost;Initial Catalog=Astros; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Planeta> ObtenerLista()
        {
            List<Planeta> planetas = new List<Planeta>();

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM planetas";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    planetas.Add(new Planeta(
                        Convert.ToInt32(dataReader["id"]),
                        dataReader["nombre"].ToString(),
                        Convert.ToInt32(dataReader["satelites"]),
                        Convert.ToDouble(dataReader["gravedad"])));

                }

                return planetas;
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

        public static bool AgregarPlaneta(Planeta p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO planetas (nombre, satelites, gravedad) VALUES (@nombre, @satelites, @gravedad)";
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@satelites", p.Satelites);
                command.Parameters.AddWithValue("@gravedad", p.Gravedad);

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

        public static bool ModificarPlaneta(Planeta p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE planetas SET nombre = @nombre, satelites = @satelites, gravedad = @gravedad WHERE ID = {p.Id}";
                command.Parameters.AddWithValue("@id", p.Id);
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@satelites", p.Satelites);
                command.Parameters.AddWithValue("@gravedad", p.Gravedad);

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


        public static bool EliminarPlaneta(int id)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM planetas WHERE ID = {id}";
                command.Parameters.AddWithValue("@id", id);

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
