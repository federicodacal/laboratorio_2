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
using IO;

namespace FrmNotepad
{
    public partial class FrmNotepad : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        private string ultimoArchivo;

        private PuntoJson<string> puntoJson;
        private PuntoXml<string> puntoXml;
        private PuntoTxt puntoTxt;

        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }
        public FrmNotepad()
        {
            InitializeComponent();

            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";

            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";

            this.puntoJson = new PuntoJson<string>();
            this.puntoXml = new PuntoXml<string>();
            this.puntoTxt = new PuntoTxt();

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.UltimoArchivo = this.openFileDialog.FileName;

                try
                {
                    switch (Path.GetExtension(this.UltimoArchivo))
                    {
                        case ".json":
                            this.rtbTexto.Text = this.puntoJson.Leer(this.UltimoArchivo);
                            break;
                        case ".xml":
                            this.rtbTexto.Text = this.puntoXml.Leer(this.UltimoArchivo);
                            break;
                        case ".txt":
                            this.rtbTexto.Text = this.puntoTxt.Leer(this.UltimoArchivo);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GuardarTexto(bool existeArchivo)
        {
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GuardarComo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.UltimoArchivo))
            {
                this.GuardarComo();
            }
            else
            {
                this.Guardar();
            }
        }

        private void GuardarComo()
        {
            this.UltimoArchivo = this.SeleccionarUbicacionGuardado();

            try
            {
                switch (Path.GetExtension(this.UltimoArchivo))
                {
                    case ".json":
                        puntoJson.GuardarComo(this.UltimoArchivo, this.rtbTexto.Text);
                        break;
                    case ".xml":
                        puntoXml.GuardarComo(this.UltimoArchivo, this.rtbTexto.Text);
                        break;
                    case ".txt":
                        puntoTxt.GuardarComo(this.UltimoArchivo, this.rtbTexto.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guardar()
        {
            try
            {
                switch (Path.GetExtension(this.UltimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(this.UltimoArchivo, this.rtbTexto.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(this.UltimoArchivo, this.rtbTexto.Text);
                        break;
                    case ".txt":
                        puntoTxt.Guardar(this.UltimoArchivo, this.rtbTexto.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
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
