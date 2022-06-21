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
    public partial class FrmReparacion : Form
    {
        Taller tallerReparacion;
        System.Threading.CancellationTokenSource cts;

        public FrmReparacion(Taller taller)
        {
            InitializeComponent();
            this.tallerReparacion = taller;
            this.cts = new System.Threading.CancellationTokenSource();
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            //TODO: Asocio el evento que va a imprimir el ticket
            //TODO: Instanciar y comenzar el hilo que se va a encargar de reparar los barcos del taller
            this.tallerReparacion.ReparacionTerminada += new InformarReparacion(ImprimirTicket);
            try
            {
                Task task = Task.Run(() => this.tallerReparacion.Reparar(this.tallerReparacion, cts.Token));
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show(ex.Message, "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirTicket(Barco barco)
        {
            //TODO: Cargar los valores del barco en sus respectivas labels
            //TODO: Usar la conversion explicita para mostrar el costo
            if (this.InvokeRequired)
            {
                Action<Barco> d = new Action<Barco>(this.ImprimirTicket);

                object[] param = { barco };

                this.Invoke(d, param);

                //this.BeginInvoke((MethodInvoker)delegate ()
                //{
                //    this.lblNombre.Text = barco.Nombre;
                //    this.lblTotal.Text = (string)barco;
                //    this.lblOperacion.Text = barco.Operacion.ToString();
                //    this.lblBarcoTipo.Text = barco.GetType().Name;
                //    this.lblTripulacion.Text = barco.Tripulacion.ToString();
                //});
            }
            else
            {
                this.lblNombre.Text = barco.Nombre;
                this.lblTotal.Text = (string)barco;
                this.lblOperacion.Text = barco.Operacion.ToString();
                this.lblBarcoTipo.Text = barco.GetType().Name;
                this.lblTripulacion.Text = barco.Tripulacion.ToString();
            }
        }

        private void FrmReparacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Cerrar el hilo
            this.cts.Cancel();
        }
    }
}
