using System;
using System.Windows.Forms;

namespace SP.LABII.WinFormsApp
{
    public partial class FrmProducto : Form
    {
        private EntidadesSP.Producto miProducto;

        public EntidadesSP.Producto MiProducto
        {
            get { return this.miProducto; }
        }

        public FrmProducto()
        {
            InitializeComponent();
        }


        /// Crar una instancia de tipo Producto
        /// Establecer, como valor de la propiedad, el atributo miProducto
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
