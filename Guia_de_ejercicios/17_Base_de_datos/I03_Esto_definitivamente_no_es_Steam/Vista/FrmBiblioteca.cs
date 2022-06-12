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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            try
            {
                this.dtgvBiblioteca.DataSource = JuegoDao.Leer().ToList();
                this.dtgvBiblioteca.Refresh();
                this.dtgvBiblioteca.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca biblio = (Biblioteca)this.dtgvBiblioteca.CurrentRow.DataBoundItem;

                    JuegoDao.Eliminar(biblio.CodigoJuego);
                    this.RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            try
            {
                if(frmAlta.ShowDialog() == DialogResult.OK)
                {
                    this.RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca biblio = (Biblioteca)this.dtgvBiblioteca.CurrentRow.DataBoundItem;

                    FrmAlta frmAlta = new FrmAlta(biblio.CodigoJuego);

                    if (frmAlta.ShowDialog() == DialogResult.OK)
                    {
                        this.RefrescarBiblioteca();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
