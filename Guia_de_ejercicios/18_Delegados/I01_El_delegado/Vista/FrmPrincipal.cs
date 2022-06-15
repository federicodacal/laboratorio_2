using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();
            this.frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);

            this.frmTestDelegados.MdiParent = this;
            this.frmMostrar.MdiParent = this;

            this.mostrarToolStripMenuItem.Enabled = false;           
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();

            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}
