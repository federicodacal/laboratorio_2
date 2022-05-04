using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmAltaUser : Form
    {
        private Usuario auxUser;
        public FrmAltaUser()
        {
            InitializeComponent();
        }

        public Usuario AuxUser
        {
            get { return this.auxUser; }
        }

        private void FrmAltaUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string name = this.txtUsername.Text;
            string pass = this.txtPassword.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;

            auxUser = new Usuario(name,pass,telefono,direccion);

            this.DialogResult = DialogResult.OK;
        }
    }
}
