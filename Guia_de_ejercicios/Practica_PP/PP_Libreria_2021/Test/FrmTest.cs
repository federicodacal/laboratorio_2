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

namespace Test
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            this.vendedor = new Vendedor("Mi Librería");
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1);
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(this.vendedor + (Publicacion)this.lstStock.SelectedItem)
            {
                MessageBox.Show("Venta exitosa", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Venta fallida", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = Vendedor.ObtenerInformeVentas(this.vendedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar el form?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
