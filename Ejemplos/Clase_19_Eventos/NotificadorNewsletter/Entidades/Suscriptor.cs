using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suscriptor
    {
        private int id;
        private string nombre;

        public Suscriptor(string nombre, int id):this(nombre)
        {
            this.id = id;
        }

        public Suscriptor(string nombre)
        {
            this.nombre = nombre;
        }


        public int Id => id;

        public string Nombre
        {
            get { return this.nombre; }
        }

        // Manejador
        public void RecibirNovedad(Newsletter sender, NewsletterEventArgs novedades)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Newsletter_DB;Trusted_Connection=True"))
                {
                    string commandText = "INSERT INTO NOVEDADES (tema, contenido, id_usuario) VALUES (@tema, @contenido, @id_usuario)";

                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.AddWithValue("@tema", sender.Tema);
                    command.Parameters.AddWithValue("@contenido", novedades.Contenido);
                    command.Parameters.AddWithValue("@id_usuario", this.Id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            } 
        }


    }
}
