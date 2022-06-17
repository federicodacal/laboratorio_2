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
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(this.persona is null)
            {
                this.persona = new Persona();
                this.persona.EventoString += FrmAvisador.NotificarCambio;
                this.btnActualizar.Text = "Actualizar";
            }

            if(this.txtApellido.Text != persona.Apellido)
            {
                this.persona.Apellido = this.txtApellido.Text;
            }

            if (this.txtNombre.Text != persona.Nombre)
            {
                this.persona.Nombre = this.txtNombre.Text;
            }

            this.lblNombreCompleto.Text = this.persona.Mostrar();
        }

        private void FrmAvisador_Load(object sender, EventArgs e)
        {
            this.btnActualizar.Text = "Crear";
        }
    }
}
