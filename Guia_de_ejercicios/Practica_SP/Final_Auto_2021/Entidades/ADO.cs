using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void ColorExistenteDelegado(object sender, EventArgs e);

    public class ADO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        public static event ColorExistenteDelegado ColorExistente;

        static ADO()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=concesionaria_final; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public bool Agregar(Auto car)
        {
            bool rta = false;
            try
            {
                Auto auxCar;
                if (!ADO.ExistePatente(car.Patente, out auxCar))
                {
                    command.Parameters.Clear();
                    command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO autos (marca, modelo, kms, color, patente) VALUES (@marca, @modelo, @kms, @color, @patente)";
                    command.Parameters.AddWithValue("@marca", car.Marca);
                    command.Parameters.AddWithValue("@modelo", car.Modelo);
                    command.Parameters.AddWithValue("@kms", car.Kms);
                    command.Parameters.AddWithValue("@color", car.Color);
                    command.Parameters.AddWithValue("@patente", car.Patente);
                    command.Connection = connection;

                    connection.Open();

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
                else
                {
                    throw new PatenteExisteException($"La patente {car.Patente} ya está registrada: {auxCar}");
                }
            }
            catch (Exception)
            {
                rta = false;
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                
                if(ADO.ColorExiste(ADO.ObtenerTodos(), car.Color))
                {
                    if(ADO.ColorExistente != null)
                    {
                        ADO.ColorExistente.Invoke(ADO.ObtenerTodos(car.Color), EventArgs.Empty);
                    }
                }
            }
            return rta;
        }

        public bool Eliminar(Auto car)
        {
            bool rta = true;

            try
            {
                command = new SqlCommand();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM autos WHERE patente = @patente";
                command.Parameters.AddWithValue("@patente", car.Patente);
                command.Connection = connection;

                connection.Open();

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


        public bool Modificar(Auto car)
        {
            bool rta = true;

            try
            {
                command.Parameters.Clear();
                command = new SqlCommand();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE autos SET marca = @marca, modelo = @modelo, kms = @kms, color = @color, patente = @patente WHERE patente = @patente";
                command.Parameters.AddWithValue("@marca", car.Marca);
                command.Parameters.AddWithValue("@modelo", car.Modelo);
                command.Parameters.AddWithValue("@kms", car.Kms);
                command.Parameters.AddWithValue("@color", car.Color);
                command.Parameters.AddWithValue("@patente", car.Patente);
                command.Connection = connection;

                connection.Open();

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
            catch (Exception)
            {
                rta = false;
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

        public static List<Auto> ObtenerTodos()
        {
            List<Auto> autos = new List<Auto>();
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM autos";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    autos.Add(new Auto(dataReader.GetString(0),
                                       dataReader.GetString(1),
                                       dataReader.GetInt32(2),
                                       dataReader.GetString(3),
                                       dataReader.GetString(4)));
                }

                return autos;
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

        public static List<Auto> ObtenerTodos(string color)
        {
            List<Auto> autos = new List<Auto>();
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM autos WHERE color = @color";
                command.Parameters.AddWithValue("@color", color);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    autos.Add(new Auto(dataReader.GetString(0),
                                       dataReader.GetString(1),
                                       dataReader.GetInt32(2),
                                       dataReader.GetString(3),
                                       dataReader.GetString(4)));
                }

                return autos;
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

        public static bool ExistePatente(string patente, out Auto car)
        {
            bool rta = false;
            car = null;
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM autos WHERE patente = @patente";
                command.Parameters.AddWithValue("@patente", patente);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    car = new Auto(dataReader.GetString(0),
                                       dataReader.GetString(1),
                                       dataReader.GetInt32(2),
                                       dataReader.GetString(3),
                                       dataReader.GetString(4));
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

        public static bool ColorExiste(List<Auto> autos, string color)
        {
            bool rta = false;
            int flagRepetido = 0;
            if(autos != null)
            {
                foreach (Auto item in autos)
                {
                    if(item.Color == color)
                    {
                        flagRepetido++;
                        if(flagRepetido == 2)
                        {
                            rta = true;
                            break;
                        }
                    }
                }
            }
            return rta;
        }
    }
}
