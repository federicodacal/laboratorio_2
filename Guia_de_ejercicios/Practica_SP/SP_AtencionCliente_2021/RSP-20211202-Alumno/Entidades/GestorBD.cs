using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    //12.GestorBD:
    //  a.Sera estática.
    //  b.ObtenerCliente correrá en un hilo secundario, este leerá de la base de datos todos los clientes.
    //      Mientras no sea el fin de los registros o no se haya cancelado el hilo se informará el cliente leído a través del evento.
    //  c.Realizar un Sleep de 2 segundos.
    //  d.En caso de producirse un error encapsular la excepción y lanzar BaseDeDatosException.

    public static class GestorBD
    {
        public delegate void DelegadoCliente(Cliente cliente);

        private static string connectionString;
        private static SqlConnection connection;

        public static event DelegadoCliente InformarCliente;

        static GestorBD()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=Final20112021Alumno; Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public static void ObtenerCliente(CancellationToken ct)
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM clientes";

                SqlDataReader dataReader = command.ExecuteReader();

                if (ct.IsCancellationRequested)
                {
                    throw new TaskCanceledException("Se canceló la tarea");
                }
                else
                {
                    while (dataReader.Read())
                    {
                        Cliente cli = new Cliente(dataReader.GetString(1),
                                                  dataReader.GetInt32(2),
                                                  dataReader.GetBoolean(3));

                        if (GestorBD.InformarCliente is not null)
                        {
                            GestorBD.InformarCliente.Invoke(cli);
                        }
                        Thread.Sleep(2000);
                    }
                }
                
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException(e.Message, e);
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
