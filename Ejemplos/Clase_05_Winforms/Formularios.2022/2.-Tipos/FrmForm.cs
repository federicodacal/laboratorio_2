﻿using System;
using System.Windows.Forms;

namespace Tipos
{
    public partial class FrmForm : Form
    {
        private string mensaje;

        public FrmForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.mensaje = this.txtMensaje.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public String ObtenerMensaje() 
        {
            return this.mensaje;
        }
    }
}
