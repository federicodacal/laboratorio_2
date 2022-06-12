using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JuegoDao
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static JuegoDao()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=EJERCICIOS_UTN; Integrated Security=True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Juego j)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "INSERT INTO JUEGOS (NOMBRE, PRECIO, GENERO, CODIGO_USUARIO) VALUES (@nombre, @precio, @genero, @codigoUsuario)";
                command.Parameters.AddWithValue("@nombre", j.Nombre);
                command.Parameters.AddWithValue("@precio", j.Precio);
                command.Parameters.AddWithValue("@genero", j.Genero);
                command.Parameters.AddWithValue("@codigoUsuario", j.CodigoUsuario);

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

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego = null;
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    juego = new Juego(
                        dataReader["NOMBRE"].ToString(), 
                        Convert.ToDouble(dataReader["PRECIO"]), 
                        dataReader["GENERO"].ToString(), 
                        Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
                }

                return juego;
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

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> bibliotecas = new List<Biblioteca>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT JUEGOS.NOMBRE AS juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, USUARIOS.USERNAME as usuario FROM JUEGOS INNER JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                   bibliotecas.Add(new Biblioteca(
                        dataReader["genero"].ToString(), 
                        dataReader["juego"].ToString(), 
                        dataReader["usuario"].ToString(),
                        Convert.ToInt32(dataReader["codigoJuego"])));
                }

                return bibliotecas;
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

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
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

        public static void Modificar(Juego j)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero WHERE CODIGO_JUEGO = {j.CodigoJuego}";
                command.Parameters.AddWithValue("@nombre", j.Nombre);
                command.Parameters.AddWithValue("@precio", j.Precio);
                command.Parameters.AddWithValue("@genero", j.Genero);

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
    }
}
