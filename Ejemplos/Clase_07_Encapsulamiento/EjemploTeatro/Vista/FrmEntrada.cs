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
        private List<string> obrasDisponible;
        private string nombreObraSeleccionada;
        private Funcion auxFuncion;

        private FrmEntrada()
        {
            InitializeComponent();
            this.obrasDisponible = new List<string>();
        }

        public FrmEntrada(Teatro teatro):this()
        {
            this.auxTeatro = teatro;
        }

        private void FrmEntrada_Load(object sender, EventArgs e)
        {
            this.obrasDisponible.Add("La Traviata");
            this.obrasDisponible.Add("Lago de los Cisnes");
            this.obrasDisponible.Add("Medea");
            this.obrasDisponible.Add("Norma");
            this.obrasDisponible.Add("Carmen");
            this.obrasDisponible.Add("Tosca");
            this.obrasDisponible.Add("Rusalka");
            this.obrasDisponible.Add("Madame Butterfly");
            this.obrasDisponible.Add("Romeo y Julieta");
            this.obrasDisponible.Add("Tristan e Isolda");
         
            this.cmbObra.DataSource = this.obrasDisponible;
        }

        private void btnReservarEntrada_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombreEspectador.Text;
            string auxDni = this.txtDni.Text;
            string auxTelefono = this.txtTelefono.Text;
            int dni;
            long telefono;

            try
            {
                if (!String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(auxDni) && !String.IsNullOrWhiteSpace(auxTelefono) && this.cmbObra.SelectedItem is not null && this.lstFechas.SelectedItem is not null)
                {
                    if (int.TryParse(auxDni, out dni) && long.TryParse(auxTelefono, out telefono))
                    {
                        if (Espectador.ValidarAtrNumerico(dni, 5, 12) && Espectador.ValidarAtrNumerico(telefono, 5, 15))
                        {
                            if (this.auxTeatro[dni] is not null)
                            {
                                this.auxTeatro[dni].ComprarEntrada(this.auxFuncion, (int)this.nudCantidad.Value);
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                if(this.auxTeatro + new Espectador(nombre, dni, telefono))
                                {
                                    this.auxTeatro[dni].ComprarEntrada(this.auxFuncion, (int)this.nudCantidad.Value);
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                        }
                        else
                        {
                            this.lblMensaje.Text = "DNI o Telefono no cumplen el formato";
                        }
                    }
                }
                else
                {
                    this.lblMensaje.Text = "Deben completarse todos los campos";
                }
            }
            catch (Exception)
            {
                this.lblMensaje.Text = "Ocurrió un problema";
            }
            
        }

        private void cmbObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.nombreObraSeleccionada = this.cmbObra.SelectedItem.ToString();
                this.lblFuncionesDisponibles.Text = $"Funciones Disponbiles para {this.nombreObraSeleccionada}";

                this.lstFechas.Items.Clear();

                if(this.nombreObraSeleccionada is not null)
                {
                    foreach (Funcion item in this.auxTeatro.ObrasDisponbiles)
                    {
                        if(item.Obra == this.nombreObraSeleccionada && item.HayEntradas)
                        {
                            this.lstFechas.Items.Add(item.Fecha.ToLongDateString());
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK);
            }  
        }

        private void lstFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada;

                if(this.cmbObra.SelectedItem is not null && this.lstFechas.SelectedItem is not null && DateTime.TryParse(this.lstFechas.SelectedItem.ToString(), out fechaSeleccionada))
                {
                    this.auxFuncion = this.auxTeatro[this.cmbObra.SelectedItem.ToString(), DateTime.Parse(this.lstFechas.SelectedItem.ToString())];

                    this.lblEntradasDisponibles.Text = $"Quedan {this.auxFuncion.EntradasDisponibles} disponibles";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cancelar la reserva?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
