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
    public partial class FrmMenu : Form
    {
        private Usuario user;
        private FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(Usuario usuario):this()
        {
            this.user = usuario;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.lblWelcome.Text += $" {user.GetUsername()}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Sistema.ListarUsuarios());
            this.rtbInformacionUser.Text = sb.ToString();
        }
    }
}
