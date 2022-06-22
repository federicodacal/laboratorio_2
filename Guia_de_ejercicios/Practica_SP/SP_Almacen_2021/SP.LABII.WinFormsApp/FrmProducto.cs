using System;
using System.Windows.Forms;
using EntidadesSP;

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

        public FrmProducto(Producto producto):this()
        {
            this.miProducto = producto;
        }


        /// Crar una instancia de tipo Producto
        /// Establecer, como valor de la propiedad, el atributo miProducto
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.txtCodigo.Text) && !String.IsNullOrWhiteSpace(this.txtCodigo.Text) && !String.IsNullOrWhiteSpace(this.txtCodigo.Text) && !String.IsNullOrWhiteSpace(this.txtCodigo.Text))
            {
                if(this.miProducto is not null)
                {
                    this.miProducto.Marca = this.txtMarca.Text;
                    this.miProducto.Tipo = this.txtTipo.Text;
                    this.miProducto.Precio = Convert.ToDouble(this.txtPrecio.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.miProducto = new Producto(this.txtMarca.Text, this.txtTipo.Text, 
                        int.Parse(this.txtCodigo.Text), double.Parse(this.txtPrecio.Text));
                }
                               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            if(this.miProducto is not null)
            {
                this.txtCodigo.Text = this.miProducto.Codigo.ToString();
                this.txtPrecio.Text = this.miProducto.Precio.ToString();
                this.txtMarca.Text = this.miProducto.Marca;
                this.txtTipo.Text = this.miProducto.Tipo;

                this.txtCodigo.Enabled = false;
            }
        }
    }
}
