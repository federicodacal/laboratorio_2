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

namespace Formulario
{
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            FrmPacientes<Persona> frmPacientes = new FrmPacientes<Persona>();
            frmPacientes.ShowDialog();
        }

        private void btnAltaAnimal_Click(object sender, EventArgs e)
        {
            FrmPacientes<Animal> frmPacientes = new FrmPacientes<Animal>();
            frmPacientes.ShowDialog();
        }
    }
}
