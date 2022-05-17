using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUniversidad;

namespace Vista
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void LimpiarRichBox()
        {
            this.rtbInfo.Clear();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.LimpiarRichBox();
            int contFallidos=0;

            try
            {
                foreach (Alumno item in Universidad.Alumnos)
                {
                    if (item is not null && item.Apellido is not null && item.Nombre is not null)
                    {
                        this.rtbInfo.Text += item.ToString() + "\n";
                    }
                    else
                    {
                        contFallidos++;
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema: {ex.Message}");
            }
            finally
            {
                this.rtbInfo.Text += $"No se pudieron mostrar {contFallidos} alumnos.\n";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarRichBox();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.LimpiarRichBox();
            int contFallidos = 0;

            try
            {
                foreach (Profesor item in Universidad.Profesores)
                {
                    if (item is not null && item.Apellido is not null && item.Nombre is not null)
                    {
                        this.rtbInfo.Text += item.ToString() + "\n";
                    }
                    else
                    {
                        contFallidos++;
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema: {ex.Message}");
            }
            finally
            {
                this.rtbInfo.Text += $"No se pudieron mostrar {contFallidos} profesores.\n";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Antes de cerrarse pasa por el Frm_FormClosing
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
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
