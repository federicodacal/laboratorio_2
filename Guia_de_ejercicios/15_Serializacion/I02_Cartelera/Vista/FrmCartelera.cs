using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;

        static FrmCartelera()
        {
            string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string fileName = "configuracion.json";

            FrmCartelera.rutaConfiguracion = Path.Combine(applicationData, fileName); 
        }

        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.pnlCartel.BackColor = this.colorDialog1.Color;
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.lblTitulo.ForeColor = this.colorDialog1.Color;
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.lblMensaje.ForeColor = this.colorDialog1.Color;
        }

        private void CargarConfiguracion(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                Cartel cartel = JsonSerializer.Deserialize<Cartel>(json);

                this.pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                this.txtTitulo.Text = cartel.Titulo.Contenido;
                this.lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                this.rtxtMensaje.Text = cartel.Mensaje.Contenido;
                this.lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
            }
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(FrmCartelera.rutaConfiguracion))
                {
                    this.CargarConfiguracion(rutaConfiguracion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaConfiguracion))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string ser = JsonSerializer.Serialize(cartel, cartel.GetType(), options);
                    sw.WriteLine(ser);

                    MessageBox.Show("Configuracion guardada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Importar configuracion";
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog1.Filter = "Json files(.json)|*.json";

            DialogResult rta = this.openFileDialog1.ShowDialog();

            if(rta == DialogResult.OK)
            {
                this.CargarConfiguracion(this.openFileDialog1.FileName);
            }
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro?", "Eliminar Configuración", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                this.txtTitulo.Text = "Título";
                this.lblTitulo.ForeColor = Control.DefaultForeColor;

                this.rtxtMensaje.Text = "Mensaje";
                this.lblMensaje.ForeColor = Control.DefaultForeColor;

                this.pnlCartel.BackColor = Control.DefaultBackColor;
            }
        }
    }
}
