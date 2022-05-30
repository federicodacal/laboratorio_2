using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivoLocoForm
{
    public partial class FormLoco : Form
    {
        private const string EXT_VALIDA = ".txt";
        public FormLoco()
        {
            InitializeComponent();
        }

        private void buttonLeer_OnClick(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.Title = "Leer archivo txt";
                this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                this.openFileDialog.CheckPathExists = true;
                this.openFileDialog.Filter = "TXT files|*.txt";

                DialogResult rta = this.openFileDialog.ShowDialog();

                if (rta == DialogResult.OK)
                {
                    string path = this.openFileDialog.FileName;

                    if (Path.GetExtension(path) == EXT_VALIDA)
                    {
                        this.richTextBoxTexto.Text = Archivador.ReadTxt(path);
                    }
                    else
                    {
                        MessageBox.Show("El formato debe ser .txt", "Error", MessageBoxButtons.OK);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonGuardar_OnClick(object sender, EventArgs e)
        {
            try
            {
                Archivador.SaveTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "miTexto", this.richTextBoxTexto.Text, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

    }
}
