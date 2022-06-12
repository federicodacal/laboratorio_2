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

namespace Vista
{
    public partial class FrmPersona : Form
    {
        private List<Persona> listaPersonas;
        private Persona auxPersona;
        public FrmPersona()
        {
            InitializeComponent();
            listaPersonas = new List<Persona>();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            this.RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            try
            {
                this.listaPersonas = PersonaDAO.Leer();
                this.lstPersonas.DataSource = null;
                this.lstPersonas.DataSource = this.listaPersonas;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocurrio un problema: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.lstPersonas.SelectedItem is not null)
            {
                auxPersona = (Persona)this.lstPersonas.SelectedItem;

                if(auxPersona is not null)
                {
                    this.txtNombre.Text = auxPersona.Nombre;
                    this.txtApellido.Text = auxPersona.Apellido;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.txtApellido.Text) && !String.IsNullOrWhiteSpace(this.txtNombre.Text) && auxPersona is not null)
            {
                try
                {
                    auxPersona.Nombre = this.txtNombre.Text;
                    auxPersona.Apellido = this.txtApellido.Text;
                    bool rta = PersonaDAO.Modificar(auxPersona);
                    if (rta)
                    {
                        MessageBox.Show("Persona modificada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.RefrescarDatos();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un problema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                    
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(this.txtNombre.Text) && !String.IsNullOrWhiteSpace(this.txtApellido.Text))
                {
                    auxPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text);

                    bool rta = PersonaDAO.Guardar(auxPersona);
                    if (rta)
                    {
                        MessageBox.Show("Persona agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.RefrescarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(this.txtApellido.Text) && !String.IsNullOrWhiteSpace(this.txtNombre.Text))
                {
                    auxPersona = (Persona)this.lstPersonas.SelectedItem;

                    if(auxPersona is not null)
                    {
                        bool rta = PersonaDAO.Borrar(auxPersona.Id);
                        if (rta)
                        {
                            MessageBox.Show("Persona eliminada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.RefrescarDatos();
                        }
                    }                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
