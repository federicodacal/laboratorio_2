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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            if(String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
            {
                this.lblMensaje.Text = "Debe completar ambos campos";
            }
            else
            {
                if(Sistema.VerificarUsuario(new Usuario(username,password)))
                {
                    MessageBox.Show($"Bienvenid@ {username}!", "Estás logead@", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmMenu frmMenu = new FrmMenu(new Usuario(username,password));
                    frmMenu.ShowDialog();

                    this.RefrescarCampos();
                    this.lblMensaje.Text = $"Hola, {username}!";
                    this.lblMensaje.ForeColor = Color.Green;
                    this.BackColor = Color.LightCyan;
                }
                else
                {
                    this.lblMensaje.Text = "El usuario no es válido";
                }
            }
        }

        private void RefrescarCampos()
        {
            this.lblMensaje.ResetText();
            this.txtPassword.Text = "";
            this.txtUsername.Text = "";
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaUser frmAlta = new FrmAltaUser();

            if(frmAlta.ShowDialog() == DialogResult.OK)
            {
                Sistema.AgregarNuevoUsuario(frmAlta.AuxUser);

                FrmMenu menu = new FrmMenu(frmAlta.AuxUser);
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alta Cancelada");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Sistema.CargarUsuarios();
        }
    }
}
