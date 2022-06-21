using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace Final._2021
{
    ///Agregar manejo de excepciones en TODOS los lugares críticos!!!

    public delegate void DelegadoThreadConParam(object param);

    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        ///
        /// Punto 10 - Iniciar hilo
        ///
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Dacal Federico";
            MessageBox.Show(this.Text);

            this.ObtenerDB();
        }

        private async void ObtenerDB()
        {
            while (true)
            {
                List<Auto> autitos = await Task.Run(() =>
                {
                    return ADO.ObtenerTodos();
                });

                foreach (Auto item in autitos)
                {
                    this.lstAutos.Items.Add(item.ToString());
                }

                await Task.Delay(5000);

                this.lstAutos.Items.Clear();
            }
        }

        ///
        /// Punto 3 - FrmListado
        /// 
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListado frm = new FrmListado();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show(this);
        }

        ///
        /// Punto 9 - Configurar OpenFileDialog. Mostrar contenido del archivo
        ///
        private void VerLogAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Abrir archivo";
                this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                this.openFileDialog1.Filter = "TXT files|*.log";
                this.openFileDialog1.DefaultExt = "txt";
                this.openFileDialog1.CheckPathExists = true;
                this.openFileDialog1.FileName = "autos";

                DialogResult rta = this.openFileDialog1.ShowDialog();


                if (rta == DialogResult.OK)
                {
                    MessageBox.Show(this.openFileDialog1.FileName);

                    System.IO.Stream lector = this.openFileDialog1.OpenFile();

                    System.IO.StreamReader sr = new System.IO.StreamReader(lector);

                    this.txtAutosLog.Text = sr.ReadToEnd();

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///
        /// Punto 10 - Cerrar hilo
        ///
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    }
}
