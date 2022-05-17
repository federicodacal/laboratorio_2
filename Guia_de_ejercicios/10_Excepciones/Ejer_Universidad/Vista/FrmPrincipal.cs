using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUniversidad;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        private int intentos;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.intentos = 3;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)this.nudID.Value;
                string password = this.txtPassword.Text;

                if (!String.IsNullOrWhiteSpace(password))
                {
                    if (Universidad.Loguear(id, password))
                    {
                        MessageBox.Show("Log in existoso!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.lblMensaje.Text = String.Empty;

                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.ShowDialog();
                    }
                }
                else
                {
                    this.lblMensaje.Text = "Falta completar el campo password";
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                this.intentos--;
                this.lblMensaje.Text = $"{ex.Message}. Te quedan {this.intentos} intentos";
                if (this.intentos == 0)
                {
                    this.txtPassword.Enabled = false;
                    this.nudID.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                this.lblMensaje.Text = ex.Message;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = "lucas123";
            this.nudID.Value = 123123;
        }
    }
}
