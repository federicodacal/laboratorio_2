using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmNotificador : Form
    {
        private Newsletter newsletterTecnologia;
        private Newsletter newsletterFinanzas;



        public FrmNotificador()
        {
            InitializeComponent();
        }

        private void FrmNotificador_Load(object sender, EventArgs e)
        {
            // objeto.Evento += manejador;
            // Asocio los eventos Click de cada button a su manejador respectivo
            this.btnFinanzas.Click += this.btnFinanzas_OnClick;
            this.btnTecnologia.Click += this.btnTecnologia_OnClick;

            this.newsletterFinanzas = new Newsletter("Finanzas");
            this.newsletterTecnologia = new Newsletter("Tecnologia");

            List<Suscriptor> suscriptores = this.TraerSuscriptores();

            foreach (Suscriptor item in suscriptores)
            {
                if (item.Id % 2 == 0)
                {
                    // Asociar el manejador
                    // objeto.Evento += manejador
                    // NovedadEnviada es el evento del objeto Newsletter
                    // RecibirNovedad es el manejador de dicho evento en un objeto de tipo Suscriptor
                    this.newsletterFinanzas.NovedadEnviada += item.RecibirNovedad;
                }
                else
                {
                    // Asociar el manejador
                    // objeto.Evento += manejador
                    // NovedadEnviada es el evento del objeto Newsletter
                    // RecibirNovedad es el manejador de dicho evento en un objeto de tipo Suscriptor
                    this.newsletterTecnologia.NovedadEnviada += item.RecibirNovedad;
                }
            }
        }

        // Manejador
        public void btnFinanzas_OnClick(object sender, EventArgs e)
        {
            try
            {
                this.newsletterFinanzas.EnviarNovedades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejador
        public void btnTecnologia_OnClick(object sender, EventArgs e)
        {
            try
            {
                this.newsletterTecnologia.EnviarNovedades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private List<Suscriptor> TraerSuscriptores()
        {
            List<Suscriptor> suscriptores = new List<Suscriptor>();

            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Newsletter_DB;Trusted_Connection=True"))
                {                   
                    string commandText = "SELECT id, nombre FROM USUARIOS";
                    SqlCommand command = new SqlCommand(commandText, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string nombre = reader["nombre"].ToString();

                        Suscriptor suscriptor = new Suscriptor(nombre, id);
                        suscriptores.Add(suscriptor);
                    }                 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return suscriptores;
        }


    }
}
