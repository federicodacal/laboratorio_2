using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasFrm : Form
    {

        private Comiqueria comiqueriaVenta;
        private Producto productoVenta;
        private VentasFrm()
        {
            InitializeComponent();
        }

        public VentasFrm(Comiqueria comiqueria, Producto producto):this()
        {
            this.comiqueriaVenta = comiqueria;
            this.productoVenta = producto;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if((int)nudCantidad.Value <= productoVenta.Stock)
            {
                this.comiqueriaVenta.Vender(productoVenta, (int)nudCantidad.Value);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show(productoVenta.Descripcion);
            }
        }

        private void VentasFrm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = productoVenta.Descripcion;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            double precio = Venta.CalcularPrecioFinal(productoVenta.Precio, (int)nudCantidad.Value);

            this.lblPrecio.Text = $"Precio: ${String.Format("{0:0.00}", precio)}";
        }
    }
}
