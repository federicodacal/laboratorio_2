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

namespace TallerFrankyUi
{
    public partial class FrmBarco : Form
    {
        Barco barco;
        public Barco Barco { get => barco; set => barco = value; }

        public FrmBarco()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(ETipoBarco));
            cmbOperacion.DataSource = Enum.GetValues(typeof(EOperacion));
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //TODO:Validar si el barco es pirata o marina y lo instancio
            // retornar DialogResult OK y cerrar el formulario
            if (!String.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                if((ETipoBarco)this.cmbTipo.SelectedItem == ETipoBarco.Marina)
                {
                    this.barco = new Marina(this.txtNombre.Text, (EOperacion)this.cmbTipo.SelectedItem);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    this.barco = new Pirata(this.txtNombre.Text, (EOperacion)this.cmbTipo.SelectedItem);

                    DialogResult = DialogResult.OK;
                }
            }

        }
    }
}
