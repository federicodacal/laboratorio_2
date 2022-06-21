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

namespace EjercicioIntegrador
{
    public partial class FormAlta : Form
    {
        private Planeta planeta;
        private string accion;
        public FormAlta()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAlta(Planeta planeta, string accion):this()
        {
            this.planeta = planeta;
            this.accion = accion;
        }

        public Planeta Planeta
        {
            get { return this.planeta; }
        }


        
        //Recupera los datos de los txtBox y carga el atributo.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double gravedad;
            int satelites;

            if(!string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtGravedad.Text) && !string.IsNullOrWhiteSpace(this.txtSatelites.Text) && double.TryParse(this.txtGravedad.Text, out gravedad) && int.TryParse(this.txtSatelites.Text, out satelites))
            {
                if(this.planeta != null)
                {
                    this.planeta.Gravedad = gravedad;
                    this.planeta.Satelites = satelites;
                    this.planeta.Nombre = this.txtNombre.Text;
                }
                else
                {
                    this.planeta = new Planeta(this.txtNombre.Text, satelites, gravedad);
                }
                
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Campos incompletos o incorrectos", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {

            if (this.planeta != null)
            {
                this.txtNombre.Text = this.planeta.Nombre;
                this.txtSatelites.Text = this.planeta.Satelites.ToString();
                this.txtGravedad.Text = this.planeta.Gravedad.ToString();

                if (this.accion == "Modificar")
                {
                    this.Text = "Modificar";
                }
                else if(this.accion == "Eliminar")
                {
                    this.Text = "Eliminar";
                    this.txtNombre.Enabled = false;
                    this.txtSatelites.Enabled = false;
                    this.txtGravedad .Enabled = false; 
                }
            }
        }
    }
}
