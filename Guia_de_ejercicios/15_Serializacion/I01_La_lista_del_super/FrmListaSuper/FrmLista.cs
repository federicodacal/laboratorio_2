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
using System.Xml.Serialization;

namespace VistaSupermercado
{
    public partial class FrmLista : Form
    {
        private List<string> listaSupermercado;

        private static string rutaArchivo;

        static FrmLista()
        {
            string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "listaSupermercado.xml";
            FrmLista.rutaArchivo = Path.Combine(applicationData, fileName);
        }

        public FrmLista()
        {
            InitializeComponent();
            this.listaSupermercado = new List<string>();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar elemento");
            this.toolTip1.SetToolTip(this.btnEliminar, "Quitar elemento");
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar elemento");

            if (File.Exists(FrmLista.rutaArchivo))
            {
                this.RecuperarDatos();
                this.RefrescarListBox();
            }
        }

        private void RefrescarListBox()
        {
            this.lstObjetos.DataSource = null;
            this.lstObjetos.DataSource = this.listaSupermercado;
        }

        private void RecuperarDatos()
        {
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSer = new XmlSerializer(this.listaSupermercado.GetType());

                this.listaSupermercado = xmlSer.Deserialize(sr) as List<string>;
            }
        }

        private void GuardarDatos()
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSer = new XmlSerializer(this.listaSupermercado.GetType());

                xmlSer.Serialize(sw, this.listaSupermercado);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frm = new FrmAltaModificacion("Agregar elemento", String.Empty, "Agregar");
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                this.listaSupermercado.Add(frm.Objeto);
                this.GuardarDatos();
                this.RefrescarListBox();
            }          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItem is not null)
            {
                this.listaSupermercado.Remove(this.lstObjetos.SelectedItem.ToString());
                this.GuardarDatos();
                this.RefrescarListBox();
            }
            else
            {
                MessageBox.Show("No hay elemento seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItem is not null)
            {
                FrmAltaModificacion frm = new FrmAltaModificacion("Modificar elemento", this.lstObjetos.SelectedItem.ToString(), "Modificar");

                frm.ShowDialog();                

                if (frm.DialogResult == DialogResult.OK)
                {
                    int indexElemento = this.listaSupermercado.IndexOf(this.lstObjetos.SelectedItem.ToString());

                    this.listaSupermercado[indexElemento] = frm.Objeto;

                    this.GuardarDatos();
                    this.RefrescarListBox();
                }
            }
            else
            {
                MessageBox.Show("No hay elemento seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        }
    }
}
