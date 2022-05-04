using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseWinForms
{
    public partial class FrmEjemplo : Form
    {
        private bool textBox = false;
        public FrmEjemplo()
        {
            InitializeComponent();
        }

        private void btnNuevoForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo WinForms!", "WinForms", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmSecundario miFrm = new FrmSecundario();
            //miFrm.Show();
            miFrm.ShowDialog();
        }

        private void FrmEjemplo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar el form?","Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Antes de cerrarse pasa por el Frm_FormClosing
        }

        private void btnTxtBox_Click(object sender, EventArgs e)
        {
            TextBox txtNuevo = new TextBox();
            txtNuevo.Text = "Hola Mundo en un TextBox";
            txtNuevo.Location = new Point(450, 80);
            txtNuevo.Size = new Size(300, 200);
            txtNuevo.Name = "txtAgregado";

            this.Controls.Add(txtNuevo);
            this.textBox = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }
    }
}
