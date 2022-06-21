using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///AlumnoADO (hereda de Alumno)
///Atributos (estáticos)
///conexion : string
///connection : SqlConnection
///command : SqlCommand
///Constructor de clase que inicialice todos sus atributos
///Constructor que recibe un objeto de tipo Alumno cómo parámetro
///Metodo de clase (público)
///ObtenerTodos() : List<Alumno> 
///Métodos de instancia (públicos):
///Agregar() : bool
///Modificar() : bool -> se modifica a partir del dni
///Eliminar() : bool -> se elimina a partir del dni

namespace EntidadesRSP
{
    public class AlumnoADO : Alumno
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static AlumnoADO()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=utn_fra_alumnos2021; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public AlumnoADO(Alumno alumno):base(alumno.Dni, alumno.Apellido, alumno.Nombre, alumno.Nota)
        {

        }

        public static List<Alumno> ObtenerTodos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM alumnos";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    alumnos.Add(new Alumno(
                        Convert.ToInt32(dataReader["dni"]),
                        dataReader["apellido"].ToString(),
                        dataReader["nombre"].ToString(),
                        Convert.ToDouble(dataReader["nota"])));
                }

                return alumnos;
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

        public bool Agregar()
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO alumnos (dni, nombre, apellido, nota) VALUES (@dni, @nombre, @apellido, @nota)";
                command.Parameters.AddWithValue("@dni", this.Dni);
                command.Parameters.AddWithValue("@nombre", this.Nombre);
                command.Parameters.AddWithValue("@apellido", this.Apellido);
                command.Parameters.AddWithValue("@nota", this.Nota);

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

        public bool Modificar()
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE alumnos SET nombre = @nombre, apellido = @apellido, nota = @nota WHERE dni = @dni";

                command.Parameters.AddWithValue("@dni", this.Dni);
                command.Parameters.AddWithValue("@nombre", this.Nombre);
                command.Parameters.AddWithValue("@apellido", this.Apellido);
                command.Parameters.AddWithValue("@nota", this.Nota);

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

        public bool Eliminar()
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM alumnos WHERE dni = {this.Dni}";
                command.Parameters.AddWithValue("@dni", this.Dni);

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
