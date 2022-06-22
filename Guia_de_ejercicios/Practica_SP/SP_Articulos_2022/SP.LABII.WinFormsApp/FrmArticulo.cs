using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesSP;

namespace SP.LABII.WinFormsApp
{
    public partial class FrmArticulo : Form
    {
        private EntidadesSP.Articulo miArticulo;

        public EntidadesSP.Articulo MiArticulo
        {
            get { return this.miArticulo; }
        }
        public FrmArticulo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmArticulo(Articulo articulo):this()
        {
            this.miArticulo = articulo;
        }


        /// Crar una instancia de tipo Articulo
        /// Establecer, como valor de la propiedad, el atributo miArticulo

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double precio;
            int codigo;

            if (!String.IsNullOrWhiteSpace(this.txtCodigo.Text) && !String.IsNullOrWhiteSpace(this.txtMarca.Text) && !String.IsNullOrWhiteSpace(this.txtPrecio.Text) && double.TryParse(this.txtPrecio.Text, out precio) && int.TryParse(this.txtCodigo.Text, out codigo))
            {
                if (this.miArticulo is not null)
                {
                    this.miArticulo.Marca = this.txtMarca.Text;
                    this.miArticulo.Precio = precio;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.miArticulo = new Articulo(this.txtMarca.Text,
                        codigo, precio);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Hay campos incompletos o incorrectos", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            if (this.miArticulo is not null)
            {
                this.txtCodigo.Text = this.miArticulo.Codigo.ToString();
                this.txtPrecio.Text = this.miArticulo.Precio.ToString();
                this.txtMarca.Text = this.miArticulo.Marca;
                this.txtCodigo.Enabled = false;
            }
        }
    }
}
