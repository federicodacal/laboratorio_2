using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
    public partial class FrmRadioButton : Form
    {
        public FrmRadioButton()
        {
            InitializeComponent();
        }
        private void rbtTahoma_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombre.Font = new Font("Tahoma", 12);
        }

        private void rbtGaramond_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombre.Font = new Font("Garamond", 8);
        }

        private void rbtComic_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombre.Font = new Font("Comic Sans MS", 15);
        }

        private void rbtVerde_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.Green;
        }

        private void rbtRojo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.Red;
        }

        private void rbtAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.Yellow;
        }
    }
}
