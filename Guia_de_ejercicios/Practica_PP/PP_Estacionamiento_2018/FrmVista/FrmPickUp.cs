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

namespace FrmVista
{
    public partial class FrmPickUp : Form
    {
        private PickUp pickup;
        public FrmPickUp()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.txtModelo.Text) && !String.IsNullOrWhiteSpace(this.txtPatente.Text))
            {
                this.pickup = new PickUp(this.txtPatente.Text, this.txtModelo.Text);
                MessageBox.Show($"¡Creado! \n{this.pickup.ConsultarDatos()}", "Nuevo PickUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
