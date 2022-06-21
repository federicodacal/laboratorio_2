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
    public partial class FrmAuto : Form
    {
        private Entidades.Auto auto;
        private string accion;

        public Entidades.Auto AutoDelFormulario
        {
            get { return this.auto; }
        }

        public FrmAuto()
        {
            InitializeComponent();
        }

        public FrmAuto(Auto unAuto, string accion):this()
        {
            this.auto = unAuto;
            this.accion = accion;
        }

        private bool ValidarInput()
        {
            bool rta = false;
            if (!String.IsNullOrWhiteSpace(this.txtMarca.Text) && !String.IsNullOrWhiteSpace(this.txtModelo.Text) && !String.IsNullOrWhiteSpace(this.txtPatente.Text) && !String.IsNullOrWhiteSpace(this.txtKms.Text) && !String.IsNullOrWhiteSpace(this.txtColor.Text))
            {
                rta = true;
            }
            return rta;
        }

        /// Crar una instancia de tipo Auto
        /// Establecer como valor del atributo auto
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.ValidarInput()) 
            {
                this.auto = new Auto(this.txtMarca.Text, this.txtModelo.Text, Convert.ToInt32(this.txtKms.Text), this.txtColor.Text, this.txtPatente.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmAuto_Load(object sender, EventArgs e)
        {
            if(this.auto != null)
            {
                this.txtColor.Text = this.auto.Color;
                this.txtModelo.Text = this.auto.Modelo;
                this.txtKms.Text = this.auto.Kms.ToString();
                this.txtMarca.Text = this.auto.Marca;
                this.txtPatente.Text = this.auto.Patente;
                if (this.accion == "Modificar")
                {
                    this.Text = this.accion;
                    this.txtPatente.Enabled = false;
                }
                else
                {
                    this.Text = this.accion;
                    this.txtColor.Enabled = false;
                    this.txtModelo.Enabled = false;
                    this.txtKms.Enabled = false;
                    this.txtMarca.Enabled = false;
                    this.txtPatente.Enabled = false;
                    this.txtPatente.Enabled = false;
                }
                
            }       
        }
    }
}
