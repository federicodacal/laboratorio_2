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
            connectionString = @"Data Source=localhost;Initial Catalog=Ejer_CRUD; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static bool Guardar(Persona p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO Persona (nombre, apellido) VALUES (@nombre, @apellido)";
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@apellido", p.Apellido);
                
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

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Persona";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    personas.Add(new Persona(
                        Convert.ToInt32(dataReader["ID"]),
                        dataReader["Nombre"].ToString(),
                        dataReader["Apellido"].ToString()));
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

        public static Persona LeerPorId(int id)
        {
            Persona persona = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Persona WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    persona = new Persona(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2));
                }

                return persona;
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

        public static Persona LeerPorNombre(string nombre)
        {
            Persona persona = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Persona WHERE Nombre = @nombre";
                command.Parameters.AddWithValue("@nombre", nombre);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    persona = new Persona(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2));
                }

                return persona;
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

        public static bool Modificar(Persona p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Persona SET nombre = @nombre, apellido = @apellido WHERE ID = {p.Id}";
                command.Parameters.AddWithValue("@id", p.Id);
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@apellido", p.Apellido);

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


        public static bool Borrar(int id)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Persona WHERE ID = {id}";
                command.Parameters.AddWithValue("@id", id);

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
