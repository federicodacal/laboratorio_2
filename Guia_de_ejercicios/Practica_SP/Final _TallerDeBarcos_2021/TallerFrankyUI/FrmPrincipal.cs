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
using Entidades;

namespace TallerFrankyUi
{
    public partial class FrmPrincipal : Form
    {
        Taller taller;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.taller = new Taller();
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            FrmBarco frmBarco = new FrmBarco();

            DialogResult rta = frmBarco.ShowDialog();
            //TODO:Cuando el dialog result del form sea OK Agregar el barco a la lista 

            try
            {
                if (rta == DialogResult.OK)
                {
                    this.taller += frmBarco.Barco;
                }
            }
            catch (BarcoRepetidoException ex)
            {
                MessageBox.Show(ex.Message, "Barco repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            FrmReparacion frmReparacion = new FrmReparacion(taller);

            frmReparacion.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar el form?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lista_barcos.xml");
            try
            {
                XmlManager xml = new XmlManager();
                if(xml.Guardar(this.taller.Barcos, path))
                {
                    MessageBox.Show("Serializado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
