using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaSupermercado
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string objeto, string btnConfirmarText):this()
        {
            this.Text = titulo;
            this.txtObjeto.Text = objeto;
            this.btnConfirmar.Text = btnConfirmarText;
        }
        private FrmAltaModificacion()
        {
            InitializeComponent();
        }

        public string Objeto
        {
            get { return this.txtObjeto.Text; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                this.Confirmar();
            } 
            else if (e.KeyChar == (char)27)
            {
                this.Cancelar();
            }
                    
        }

        private void Confirmar()
        {
            if (String.IsNullOrWhiteSpace(this.Objeto))
            {
                MessageBox.Show("Debe ingresar un texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
