using System;
using Entidades;
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int cantSolicitidad = Convert.ToInt32(this.txtCantidad.Text);

            Almacen.ValidarStock_1(cantSolicitidad, MostrarMensajeOk, MostrarMensajeTodoMal);
        }

        private void MostrarMensajeOk()
        {
            MessageBox.Show("Stock Ok", "Todo Ok", MessageBoxButtons.OK);
        }

        private void MostrarMensajeTodoMal()
        {
            MessageBox.Show("Stock insuficiente", "Todo Mal", MessageBoxButtons.OK);
        }

        private void btnValidar2_Click(object sender, EventArgs e)
        {
            int cantSolicitidad = Convert.ToInt32(this.txtCantidad.Text);

            Almacen.ValidarStock_2(cantSolicitidad, MostrarMensajeOk, MostrarMensajeTodoMal);
        }

        private void MostrarMensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Todo Ok", MessageBoxButtons.OK);
        }

        private void MostrarMensajeTodoMal(int fallo)
        {
            MessageBox.Show($"Stock insuficiente: {fallo}", "Todo Mal", MessageBoxButtons.OK);
        }
    }
}
