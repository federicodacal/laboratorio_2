using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear, en EntidadesSP, la clase ADO.
///Dicha clase se deberá comunicar con la base de datos, tendrá:
///Métodos de clase:
///ObtenerTodos() : List<Articulo>
///ObtenerTodos(string) : List<Articulo> -> se obtienen por marca 
///de acuerdo al parámetro recibido
///Métodos de instancia:
///Agregar(Articulo) : bool
///Modificar(Articulo) : bool -> se modifica a partir del código
///Eliminar(Articulo) : bool -> se elimina a partir del código

namespace EntidadesSP
{

    public delegate void DelegadoADO(object sender, MarcaRepetidaEventArgs e);

    public class ADO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        public event DelegadoADO MarcaRepetida;

        static ADO()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=deposito_db; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Articulo> ObtenerTodos()
        {
            List<Articulo> articulos = new List<Articulo>();

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Articulos";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    articulos.Add(new Articulo(
                        dataReader["marca"].ToString(),
                        Convert.ToInt32(dataReader["codigo"]),
                        Convert.ToDouble(dataReader["precio"])));
                }

                return articulos;
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

        public static List<Articulo> ObtenerTodos(string marca)
        {
            List<Articulo> articulos = new List<Articulo>();

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Articulos WHERE marca = @marca";
                command.Parameters.AddWithValue("@marca", marca);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    articulos.Add(new Articulo(
                        dataReader["marca"].ToString(),
                        Convert.ToInt32(dataReader["codigo"]),
                        Convert.ToDouble(dataReader["precio"])));
                }

                return articulos;
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


        public bool Agregar(Articulo art)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO Articulos (marca, codigo, precio) VALUES (@marca, @codigo, @precio)";
                command.Parameters.AddWithValue("@marca", art.Marca);
                command.Parameters.AddWithValue("@codigo", art.Codigo);
                command.Parameters.AddWithValue("@precio", art.Precio);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    rta = false;
                }
                else
                {
                    rta = true;
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    List<Articulo> listita = ADO.ObtenerTodos(art.Marca);
                    if (listita is not null && listita.Count > 1)
                    {
                        if (this.MarcaRepetida is not null)
                        {
                            MarcaRepetidaEventArgs e = new MarcaRepetidaEventArgs();
                            e.Marca = art.Marca;
                            this.MarcaRepetida.Invoke(this, e);
                        }
                    }
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


        public bool Modificar(Articulo art)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Articulos SET marca = @marca, precio = @precio WHERE codigo = @codigo";
                command.Parameters.AddWithValue("@codigo", art.Codigo);
                command.Parameters.AddWithValue("@marca", art.Marca);
                command.Parameters.AddWithValue("@precio", art.Precio);

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


        public bool Eliminar(Articulo art)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM articulos WHERE codigo = @codigo";
                command.Parameters.AddWithValue("@codigo", art.Codigo);

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
