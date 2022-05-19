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

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.txtApellido.Text) && !String.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                this.dt = new DirectorTecnico(this.txtNombre.Text, this.txtApellido.Text, (int)nudEdad.Value, (int)nudDni.Value, (int)nudExp.Value);

                MessageBox.Show($"Se ha creado DT! \n{this.dt.Mostrar()}");
            }
            else
            {
                MessageBox.Show("Hay campos incompletos");
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(this.dt is not null)
            {
                if (this.dt.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto");
                }
                else
                {
                    MessageBox.Show("El DT no es apto");
                }
            }
            else
            {
                MessageBox.Show("Aun no se ha creado el DT");
            }
        }
    }
}
