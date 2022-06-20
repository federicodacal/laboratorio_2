using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        static UsuarioDAO()
        {
            UsuarioDAO.connectionString = @"Data Source=localhost;Database=bd-modelo-sp;Trusted_Connection=True;";
        }

        public UsuarioDAO()
        {
            this.connection = new SqlConnection(UsuarioDAO.connectionString);
        }

        public bool Save(Usuario u)
        {
            bool rta = false;
            try
            {
                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "INSERT INTO usuario (nombre, edad) VALUES (@nombre, @edad)";
                this.command.Parameters.AddWithValue("@nombre", u.Nombre);
                this.command.Parameters.AddWithValue("@edad", u.Edad);
                this.command.Connection = this.connection;

                this.connection.Open();

                int affectedRows = this.command.ExecuteNonQuery();

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
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return rta;
        }

        public Usuario ReadById(int id)
        {
            Usuario usuario = null;
            try
            {
                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM usuario WHERE ID = @id";
                this.command.Parameters.AddWithValue("@id", id);
                this.command.Connection = this.connection;

                this.connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    usuario = new Usuario(
                                    dataReader.GetInt32(0),
                                    dataReader.GetString(1),
                                    dataReader.GetInt32(2));
                }

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
        }

        public bool Delete(int id)
        {
            bool rta = true;

            try
            {
                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "DELETE FROM usuario WHERE ID = @id";
                this.command.Parameters.AddWithValue("@id", id);
                this.command.Connection = this.connection;

                this.connection.Open();

                int affectedRows = this.command.ExecuteNonQuery();

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
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return rta;
        }


        public bool Update(Usuario u)
        {
            bool rta = true;

            try
            {
                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "UPDATE usuario SET nombre = @nombre, edad = @edad WHERE ID = @id";
                this.command.Parameters.AddWithValue("@id", u.Id);
                this.command.Parameters.AddWithValue("@nombre", u.Nombre);
                this.command.Parameters.AddWithValue("@edad", u.Edad);
                this.command.Connection = this.connection;

                this.connection.Open();

                int affectedRows = this.command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    rta = false;
                }
                else
                {
                    rta = true;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return rta;
        }


        public List<Usuario> ReadAll()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM usuario";
                this.command.Connection = this.connection;

                this.connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Usuario usuario = new Usuario(
                                            dataReader.GetInt32(0),
                                            dataReader.GetString(1),
                                            dataReader.GetInt32(2));
                    lista.Add(usuario);
                }

                dataReader.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return lista;
        }
    }
}
