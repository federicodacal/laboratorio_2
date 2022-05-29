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
    public partial class FrmTeatro : Form
    {
        private Teatro teatro;

        public Teatro Teatro
        {
            get { return this.teatro; }
        }

        public FrmTeatro()
        {
            InitializeComponent();
            this.teatro = new Teatro();
        }

        private void btnComprarEntrada_Click(object sender, EventArgs e)
        {
            FrmEntrada frmEntrada = new FrmEntrada(teatro);
            if (frmEntrada.ShowDialog() == DialogResult.OK)
            {
                this.rtbEspectadores.Text = this.teatro.MostrarEspectadores();
            }
        }
    }
}
