using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmHilos : Form
    {
        private static Random random;

        static FrmHilos()
        {
            random = new Random();
        }

        public FrmHilos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = this.txtMensaje.Text;
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtMensaje.Text = string.Empty;          
        }

        private void InicializarHilos()
        {
            Task task = new Task(() => this.IniciarProceso(this.pgb1, this.lblPgb1));
            task.Start(); // Hilo secundario

            Task task2 = Task.Run(() => this.IniciarProceso(this.pgb2, this.lblPgb2));
        }

        private void IniciarProceso(ProgressBar pgb, Label label)
        {
            // Hilo secundario
            while (pgb.Value < pgb.Maximum)
            {
                Thread.Sleep(random.Next(100, 1000));
                this.IncrementarProgreso(pgb, label, Task.CurrentId.Value);                
            }
        }

        private void IncrementarProgreso(ProgressBar pgb, Label label, int idHilo)
        {
            // True cuando el control que lo invoca está en un hilo diferente del hilo que lo creó, el InvokeRequired es del Form.
            // InvokeRequired requiero una invocación, es decir, si estoy en un hilo distinto al principal.
            if (this.InvokeRequired) 
            {
                // Encapsular la referencia al método que modifica a los contros en un Delegado.
                Action<ProgressBar, Label, int> delegado = this.IncrementarProgreso;

                // Si recibe parámetros voy a guardarlos en un array de objects.
                object[] parametros = new object[] { pgb, label, idHilo };

                // Invoke, invoca al delegado desde el hilo que creó al formulario, pasándole los parametros en el mismo orden que en el array.
                this.Invoke(delegado, parametros);
            }
            else // Luego del Invoke, InvokeRequired retorna false porque estamos en el mismo hilo que creó al formulario y se pueden modificar los controles
            {
                pgb.Increment(1);
                label.Text = $"Hilo N°{Task.CurrentId} - {pgb.Value}%";
            }
        }

        private void FrmHilos_Load(object sender, EventArgs e)
        {
            this.InicializarHilos();
        }

        private void FrmHilos_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
