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

namespace FrmNotepad
{
    public partial class FrmNotepad : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string archivo;

        public FrmNotepad()
        {
            InitializeComponent();
            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();
        }

        private string LeerArchivoTexto(string path)
        {
            string texto = String.Empty;

            if (File.Exists(path))
            {
                if(Path.GetExtension(path) == ".txt")
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        texto = sr.ReadToEnd();
                    }
                }
                else
                {
                    throw new Exception("El formato debe ser .txt");
                }
            }            
            return texto;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                this.openFileDialog.Title = "Abrir archivo";
                this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                this.openFileDialog.CheckFileExists = true;

                DialogResult rta = this.openFileDialog.ShowDialog();

                this.archivo = this.openFileDialog.FileName;

                if(rta == DialogResult.OK)
                {
                    this.rtbTexto.Text = this.LeerArchivoTexto(this.archivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} en {ex.StackTrace}", "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarTexto(bool existeArchivo)
        {
            try
            {
                if (!existeArchivo)
                {
                    this.openFileDialog.Title = "Guardar archivo";
                    this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    this.openFileDialog.CheckFileExists = true;
                    this.saveFileDialog.Filter = "TXT files|*.txt";

                    DialogResult rta = this.saveFileDialog.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        this.archivo = this.saveFileDialog.FileName;
                        using (StreamWriter sw = new StreamWriter(this.archivo))
                        {
                            sw.WriteLine(this.rtbTexto.Text);
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(this.archivo))
                    {
                        sw.WriteLine(this.rtbTexto.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} en {ex.StackTrace}", "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.GuardarTexto(false);
                      
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.archivo))
            {
                this.GuardarTexto(false);
            }
            else
            {
                this.GuardarTexto(true);
            }
                                
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabelCaracteres.Text = "0 caracteres";
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabelCaracteres.Text = $"{this.rtbTexto.Text.Length} caracteres";
        }
    }
}
