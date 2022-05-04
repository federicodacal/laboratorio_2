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
    public partial class FrmEntrada : Form
    {
        private Teatro auxTeatro;

        private string[] obrasDisponibles = { "La Traviata", "Medea", "Norma", "Tosca", "Rusalka", "El Lago de los Cisnes"}; 

        private FrmEntrada()
        {
            InitializeComponent();
        }

        public FrmEntrada(Teatro teatro):this()
        {
            this.auxTeatro = teatro;
        }

        private void btnReservarEntrada_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombreEspectador.Text;
            string auxDni = this.txtDni.Text;
            string auxTelefono = this.txtTelefono.Text;
            int dni;
            long telefono;

            if(!String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(auxDni) && !String.IsNullOrWhiteSpace(auxTelefono) && this.cmbObra.SelectedItem is not null)
            {
                if(int.TryParse(auxDni, out dni) && long.TryParse(auxTelefono, out telefono))
                {
                    if(auxTeatro + new Espectador(nombre, dni, telefono))
                    {
                        this.auxTeatro[dni].ComprarEntrada(cmbObra.Text, dtpFecha.Value, (int)nudCantidad.Value);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.auxTeatro[dni].ComprarEntrada(cmbObra.Text, dtpFecha.Value, (int)nudCantidad.Value);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                this.lblMensaje.Text = "Deben completarse todos los campos";
            }
        }

        private void FrmEntrada_Load(object sender, EventArgs e)
        {
            this.cmbObra.DataSource = obrasDisponibles;
            /*
            foreach (string item in this.obrasDisponibles)
            {
                this.cmbObra.Items.Add(item);
            }
            */
        }
    }
}
