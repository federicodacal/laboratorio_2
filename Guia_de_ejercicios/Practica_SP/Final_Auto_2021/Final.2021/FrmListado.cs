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

namespace Final._2021
{
    public partial class FrmListado : Form
    {
        List<Entidades.Auto> lista;

        public FrmListado()
        {
            InitializeComponent();

            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.StartPosition = FormStartPosition.CenterScreen;

            ADO.ColorExistente += new ColorExistenteDelegado(this.Manejador_colorExistente);

        }

        private void RefrescarDatagrid()
        {
            this.dataGridView1.DataSource = null;
            this.lista = Entidades.ADO.ObtenerTodos();
            this.dataGridView1.DataSource = this.lista;
        }

        ///
        /// Punto 3 - Obtener y mostrar todos los autos de la BD
        ///
        private void FrmListado_Load(object sender, EventArgs e)
        {
            this.RefrescarDatagrid();            
        }

        private void MessageError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        ///
        /// Punto 4 - Agregar un nuevo auto a la BD. Utilizar FrmAuto
        ///
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAuto frmAuto = new FrmAuto();

                DialogResult rta = frmAuto.ShowDialog();

                if (rta == DialogResult.OK)
                {
                    ADO ado = new ADO();

                    if (ado.Agregar(frmAuto.AutoDelFormulario))
                    {
                        MessageBox.Show("Agregado", "Bien", MessageBoxButtons.OK);
                        this.RefrescarDatagrid();
                    }
                }
                
            }
            catch (Exception ex)
            {
                this.MessageError(ex);
            }
        }

        ///
        /// Punto 5 - Modificar auto seleccionado en la BD. Reutilizar FrmAuto
        ///
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows[0].DataBoundItem != null)
                {
                    Auto auxAuto = this.dataGridView1.SelectedRows[0].DataBoundItem as Auto;

                    FrmAuto frmAuto = new FrmAuto(auxAuto, this.btnModificar.Text);

                    DialogResult rta = frmAuto.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        ADO ado = new ADO();

                        if (ado.Modificar(frmAuto.AutoDelFormulario))
                        {
                            MessageBox.Show("Modificado", "Bien", MessageBoxButtons.OK);
                            this.RefrescarDatagrid();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                this.MessageError(ex);
            }

           
        }

        ///
        /// Punto 6 - Eliminar auto seleccionado de la BD. Reutilizar FrmAuto.
        ///
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows[0].DataBoundItem != null)
                {
                    Auto auxAuto = this.dataGridView1.SelectedRows[0].DataBoundItem as Auto;

                    FrmAuto frmAuto = new FrmAuto(auxAuto, this.btnEliminar.Text);

                    DialogResult rta = frmAuto.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        ADO ado = new ADO();

                        if (ado.Eliminar(frmAuto.AutoDelFormulario))
                        {
                            MessageBox.Show("Eliminado", "Bien", MessageBoxButtons.OK);
                            this.RefrescarDatagrid();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                this.MessageError(ex);
            }            
        }

        ///
        /// Punto 8-b - Capturar evento ColorExiste y escribir en log
        ///
        private void Manejador_colorExistente(object sender, EventArgs e)
        {
            try
            {
                bool todoOK = ManejadoraTexto.EscribirArchivo((List<Auto>)sender);//Reemplazar por la llamada al método de clase ManejadoraTexto.EscribirArchivo

                MessageBox.Show("Color repetido!!!");

                if (todoOK)
                {
                    MessageBox.Show("Se escribió correctamente!!!");
                }
                else
                {
                    MessageBox.Show("No se pudo escribir!!!");
                }
            }
            catch (Exception ex)
            {
                this.MessageError(ex);
            }

        }
    }
}
