using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EntidadesDAO
{
    public class ProvincialDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;
        static Random rdmFranja;

        static ProvincialDAO()
        {
            ProvincialDAO.connectionString = @"Data Source=localhost;Initial Catalog=Centralita; Integrated Security=True";
            ProvincialDAO.command = new SqlCommand();
            ProvincialDAO.connection = new SqlConnection(connectionString);
            ProvincialDAO.command.Connection = connection;
            ProvincialDAO.command.CommandType = System.Data.CommandType.Text;

            ProvincialDAO.rdmFranja = new Random();
        }

        public List<Provincial> Leer()
        {
            List <Provincial> lista = new List<Provincial>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Llamadas WHERE TIPO = 1";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int franja = rdmFranja.Next(0, 2);
                    lista.Add(new Provincial(dataReader["Origen"].ToString(), 
                        (Provincial.Franja)franja, 
                        float.Parse(dataReader["Duracion"].ToString()), 
                        dataReader["Destino"].ToString()));
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

        public bool Guardar(Provincial p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Llamadas (Duracion, Origen, Destino, Costo, Tipo) VALUES (@Duracion, @Origen, @Destino, @Costo, 1)";
                command.Parameters.AddWithValue("@Duracion", p.Duracion);
                command.Parameters.AddWithValue("@Origen", p.NroOrigen);
                command.Parameters.AddWithValue("@Destino", p.NroDestino);
                command.Parameters.AddWithValue("@Costo", p.CostoLlamada);

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
