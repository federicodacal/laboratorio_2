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

namespace WinForm
{
    public partial class FrmRegistro : Form
    {

        private Ingresante ingresante;

        private string[] paises = { "Argentina", "Chile", "Uruguay", "Colombia", "Brasil", "Peru", "Ecuador", "Paraguay", "España"};
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int edad = (int)this.nudEdad.Value;
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string genero = this.gbGenero.Text;
            string pais = this.lstPaises.SelectedItem.ToString();
            List<string> cursos = new List<string>();

            foreach (Control item in this.Controls)
            {
                if(item is GroupBox)
                {
                    foreach (Control c in item.Controls)
                    {
                        if (c is CheckBox)
                        {
                            if (((CheckBox)c).Checked)
                            {
                                cursos.Add(c.Text);
                            }
                        }
                        if(c is RadioButton)
                        {
                            if(((RadioButton)c).Checked)
                            {
                                genero = c.Text;
                            }
                        }
                    }
                }
            }

            ingresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);

            MessageBox.Show(ingresante.Mostrar(), "Ingresante", MessageBoxButtons.OK);
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            foreach (string item in paises)
            {
                this.lstPaises.Items.Add(item);
            }
        }
    }
}
