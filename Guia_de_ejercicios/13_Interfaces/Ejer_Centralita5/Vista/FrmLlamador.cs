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
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        private bool marcoNumero;
        private bool esProvincial;
        private Random rdm;

        private FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            this.marcoNumero = false;
            this.esProvincial = false;
            this.cmbFranja.Enabled = false;
            this.rdm = new Random();
        }

        public Centralita Centralita
        {
            get { return this.centralita; }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.txtNroDestino.ReadOnly = true;
        }

        private void escribirPrimerNumero(object sender, EventArgs e, char caracter)
        {
            if (!this.marcoNumero)
            {
                this.marcoNumero = true;
                this.txtNroDestino.Text = "";
                if(caracter == '#')
                {
                    this.esProvincial = true;
                    this.cmbFranja.Enabled = true;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '1');
            this.txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '2');
            this.txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '3');
            this.txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '4');
            this.txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '5');
            this.txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '6');
            this.txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '7');
            this.txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '8');
            this.txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '9');
            this.txtNroDestino.Text += "9";
        }

        private void btnGuion_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '-');
            this.txtNroDestino.Text += "-";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '0');
            this.txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.escribirPrimerNumero(sender, e, '#');
            this.txtNroDestino.Text += "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "";
            this.txtNroDestino.Text = "";
            this.cmbFranja.Enabled = false;
            this.esProvincial = false;
            this.marcoNumero = false;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float duracion;
            float precio;

            try
            {
                if (EsLlamadaValida(this.txtNroOrigen.Text) && EsLlamadaValida(this.txtNroDestino.Text))
                {
                    duracion = rdm.Next(1, 50);
                    if (this.esProvincial)
                    {
                        Provincial p = new Provincial(this.txtNroOrigen.Text, (Provincial.Franja)this.cmbFranja.SelectedIndex, duracion, this.txtNroDestino.Text);
                        if (centralita + p)
                        {
                            MessageBox.Show("Llamada realizada con éxito!!!");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No atendieron!!!");
                        }
                    }
                    else
                    {
                        precio = (rdm.Next(5, 56) / 10);
                        Local l = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, precio);
                        if (centralita + l)
                        {
                            MessageBox.Show("Llamada realizada con éxito!!!");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No atendieron!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Revise que los numeros ingresados sean válidos");
                }
            }
            catch (CentralitaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un problema");
            }
        }

        private bool EsLlamadaValida(string numero)
        {
            bool esValida = false;
            bool tieneLetra = false;
             if(!String.IsNullOrWhiteSpace(numero) && numero.Length > 4 && numero.Length < 26)
             {
                foreach (char item in numero)
                {
                    if(char.IsLetter(item))
                    {
                        tieneLetra = true;
                        break;
                    }
                }
                if (!tieneLetra)
                {
                    esValida = true;
                }
            }
            return esValida;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar el form?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
