using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=PersonasUTN; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Personas";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    personas.Add(new Persona(Convert.ToInt32(dataReader["id"]), dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), Convert.ToInt32(dataReader["edad"])));
                }

                return personas;
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

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear(); // Para miembros estáticos
                connection.Open();
                command.CommandText = $"DELETE FROM Personas WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
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

        public static void Guardar(Persona persona)
        {
            try
            {
                command.Parameters.Clear(); // Para miembros estáticos
                connection.Open();
                command.CommandText = $"INSERT INTO Personas (nombre, apellido, edad) VALUES (@nombre, @apellido, @edad)";
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
                command.Parameters.AddWithValue("@edad", persona.Edad);
                command.ExecuteNonQuery();
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

        public static void Modificar(Persona persona)
        {
            try
            {
                command.Parameters.Clear(); // Para miembros estáticos
                connection.Open();
                command.CommandText = $"UPDATE Personas SET nombre = @nombre, apellido = @apellido, edad = @edad WHERE ID = {persona.Id}";
                command.Parameters.AddWithValue("@id", persona.Id);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
                command.Parameters.AddWithValue("@edad", persona.Edad);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
