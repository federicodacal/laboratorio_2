using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear, en EntidadesSP, la clase ADO.
///Dicha clase se deberá comunicar con la base de datos, tendrá:
///Métodos de clase:
///ObtenerTodos() : List<Producto>
///ObtenerTodos(string) : List<Producto> -> se obtienen por marca 
///de acuerdo al parámetro recibido
///Métodos de instancia:
///Agregar(Producto) : bool
///Modificar(Producto) : bool -> se modifica a partir del código
///Eliminar(Producto) : bool -> se elimina a partir del código

namespace EntidadesSP
{

    public delegate void DelegadoAdo(object sender, MarcaRepetidaEventArgs e);

    public class ADO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        public event DelegadoAdo MarcaRepetida;

        static ADO()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=almacen_2021_db; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM productos";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    productos.Add(new Producto(
                        dataReader["marca"].ToString(),
                        dataReader["tipo"].ToString(),
                        Convert.ToInt32(dataReader["codigo"]),
                        Convert.ToDouble(dataReader["precio"])));
                }

                return productos;
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

        public static List<Producto> ObtenerTodos(string marca)
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM productos WHERE marca = @marca";
                command.Parameters.AddWithValue("@marca", marca);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    productos.Add(new Producto(
                        dataReader["marca"].ToString(),
                        dataReader["tipo"].ToString(),
                        Convert.ToInt32(dataReader["codigo"]),
                        Convert.ToDouble(dataReader["precio"])));
                }

                return productos;
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


        public bool Agregar(Producto p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO productos (marca, tipo, codigo, precio) VALUES (@marca, @tipo, @codigo, @precio)";
                command.Parameters.AddWithValue("@marca", p.Marca);
                command.Parameters.AddWithValue("@tipo", p.Tipo);
                command.Parameters.AddWithValue("@codigo", p.Codigo);
                command.Parameters.AddWithValue("@precio", p.Precio);

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
                    List<Producto> listita = ADO.ObtenerTodos(p.Marca);
                    if (listita is not null && listita.Count > 1)
                    {
                        if (this.MarcaRepetida is not null)
                        {
                            MarcaRepetidaEventArgs e = new MarcaRepetidaEventArgs();
                            e.Marca = p.Marca;
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


        public bool Modificar(Producto p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE productos SET marca = @marca, tipo = @tipo, precio = @precio WHERE codigo = {p.Codigo}";
                command.Parameters.AddWithValue("@id", p.Codigo);
                command.Parameters.AddWithValue("@marca", p.Marca);
                command.Parameters.AddWithValue("@tipo", p.Tipo);
                command.Parameters.AddWithValue("@precio", p.Precio);

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


        public bool Eliminar(Producto p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM productos WHERE codigo = {p.Codigo}";
                command.Parameters.AddWithValue("@codigo", p.Codigo);

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
