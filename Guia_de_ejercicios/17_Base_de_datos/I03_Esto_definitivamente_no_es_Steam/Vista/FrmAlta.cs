using Entidades;
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
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            this.btnGuardar.Text = "Modificar";
            this.nupPrecio.Maximum = 10000;
            this.cmbUsuarios.Hide();
            this.lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDao.LeerPorId(this.codigoJuego);

            this.txtGenero.Text = juego.Genero;
            this.txtNombre.Text = juego.Nombre;
            this.nupPrecio.Value = (decimal)juego.Precio;
        }

        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            this.cmbUsuarios.DataSource = UsuarioDao.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnGuardar.Text != "Modificar")
                {
                    Juego nuevoJuego = new Juego(this.txtNombre.Text, (double)this.nupPrecio.Value, this.txtGenero.Text, ((Usuario)this.cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDao.Guardar(nuevoJuego);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    Juego nuevoJuego = new Juego(this.txtNombre.Text, (double)this.nupPrecio.Value, this.txtGenero.Text, this.codigoJuego, ((Usuario)this.cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDao.Modificar(nuevoJuego);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
