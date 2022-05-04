using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FrmPrincipal : Form
    {

        private EMaterias materia;

        public enum EMaterias
        {
            ProgramacionI, ProgramacionII, LaboratorioI, LaboratorioII, Matematica, SistemasOperativos 
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            StringBuilder sb = new StringBuilder();
            bool esValido = true;
            
            this.lblCamposIncompletos.Text = "";


            sb.AppendLine("Se deben completar los siguientes campos: ");

            if (string.IsNullOrWhiteSpace(nombre))
            {
                esValido = false;
                sb.AppendLine(this.lblNombre.Text);
            }

            if(string.IsNullOrWhiteSpace(apellido))
            {
                esValido = false;
                sb.AppendLine(this.lblApellido.Text);
            }

            if(!esValido)
            {
                this.lblCamposIncompletos.Text = "Debe completar todos los campos";
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmSaludo frmSaludo = new FrmSaludo(nombre, apellido, this.cmbMaterias.Text);
                frmSaludo.ShowDialog();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.DataSource = Enum.GetValues(typeof(EMaterias));
            this.cmbMaterias.SelectedIndex = 0;
        }
    }
}
