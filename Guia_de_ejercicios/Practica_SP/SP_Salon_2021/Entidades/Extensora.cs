using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar método de extensión (clase Extensora) en Persona MostrarBD():string.
//MostrarBD retornará una cadena (Apellido, Nombre y Edad) de todos los registros de la BD.
//Crear la base de datos 'final_lab_II', la cuál tendrá la tabla personas:
//Tabla - personas { id(autoincremental - numérico) - apellido(cadena) - nombre(cadena) 
//                   idioma(numérico) - edad(numérico) }.
//USE [final_lab_II]
//GO
//CREATE TABLE [dbo].[personas](
//[id] [int] IDENTITY(1,1) NOT NULL,
//[apellido] [varchar] (50) NULL,
//[nombre] [varchar] (50) NULL,
//[idioma] [int] NULL,
//[edad] [int] NULL,
//CONSTRAINT[PK_personas] PRIMARY KEY CLUSTERED
//(
//[id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO

namespace Entidades
{
    public static class Extensora
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static Extensora()
        {
            connectionString = @"Server = localhost;Initial Catalog = final_salon_2021; Integrated Security=True; Encrypt=False";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static string MostrarDB(this Persona persona)
        {
            string personas = String.Empty;

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM personas";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Persona auxPersona = new Persona(dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), (EIdioma)(Convert.ToInt32(dataReader["idioma"])), Convert.ToSByte(dataReader["edad"]));

                    personas += $"{auxPersona.Apellido}, {auxPersona.Nombre} {auxPersona.Edad} años{Environment.NewLine}";
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

        public static bool AgregarDB(this Persona p)
        {
            bool rta;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO personas (apellido, nombre, idioma, edad) VALUES (@apellido, @nombre, @idioma, @edad)";
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@apellido", p.Apellido);
                command.Parameters.AddWithValue("@edad", (int)p.Edad);
                command.Parameters.AddWithValue("@idioma", (int)p.Idioma);

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
