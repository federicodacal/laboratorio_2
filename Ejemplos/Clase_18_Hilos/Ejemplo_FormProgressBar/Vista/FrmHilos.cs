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

        private CancellationTokenSource cancellationTokenSource;

        private List<Task> hilos;
        
        static FrmHilos()
        {
            random = new Random();
        }

        public FrmHilos()
        {
            InitializeComponent();
            this.hilos = new List<Task>();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = this.txtMensaje.Text;
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtMensaje.Text = string.Empty;          
        }

        private void InicializarHilos()
        {
            foreach (Control item in this.Controls)
            {
                if(item is ProgressBar)
                {
                    ((ProgressBar)item).Value = 0;
                }
            }

            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken ct = cancellationTokenSource.Token;

            Task task = new Task(() => this.IniciarProceso(this.pgb1, this.lblPgb1), ct);
            task.Start(); // Hilo secundario
            this.hilos.Add(task);

            Task task2 = Task.Run(() => this.IniciarProceso(this.pgb2, this.lblPgb2), ct);         
            this.hilos.Add(task2);

            Task task3 = Task.Run(() => this.IniciarProceso(this.pgb3, this.lblPgb3), ct);         
            this.hilos.Add(task3);

            Task task4 = Task.Run(() => this.IniciarProceso(this.pgb4, this.lblPgb4), ct);         
            this.hilos.Add(task4);

            Task task5 = Task.Run(() => this.IniciarProceso(this.pgb5, this.lblPgb5), ct);
            this.hilos.Add(task5);
            

        }

        private void IniciarProceso(ProgressBar pgb, Label label)
        {
            // Hilo secundario
            while (pgb.Value < pgb.Maximum && !(this.cancellationTokenSource.IsCancellationRequested))
            {
                Thread.Sleep(random.Next(100, 1000));
                this.IncrementarProgreso(pgb, label, Task.CurrentId.Value);                
            }

            // Cuando termine por finalizado o cancelación llama a FinalizarProceso
            this.FinalizarProceso(pgb, label);
        }

        private void IncrementarProgreso(ProgressBar pgb, Label label, int idHilo)
        {
            // True cuando el control que lo invoca está en un hilo diferente del hilo que lo creó, el InvokeRequired es del Form.
            // InvokeRequired requiero una invocación, es decir, si estoy en un hilo distinto al principal.
            if (this.InvokeRequired) 
            {
                // Encapsular la referencia al método que modifica a los contros en un Delegado.
                Action<ProgressBar, Label, int> delegadoIncrementar = this.IncrementarProgreso;

                // Si recibe parámetros voy a guardarlos en un array de objects.
                object[] parametros = new object[] { pgb, label, idHilo };

                // Invoke, invoca al delegado desde el hilo que creó al formulario, pasándole los parametros en el mismo orden que en el array.
                this.Invoke(delegadoIncrementar, parametros);
            }
            else // Luego del Invoke, InvokeRequired retorna false porque estamos en el mismo hilo que creó al formulario y se pueden modificar los controles
            {
                pgb.Increment(1);
                label.Text = $"Hilo N°{idHilo} - {pgb.Value}%";
            }
        }

        private void FinalizarProceso(ProgressBar pgb, Label label)
        {
            if (this.InvokeRequired)
            {
                Action<ProgressBar, Label> delegadoFinalizar = FinalizarProceso;
                object[] parametros = new object[] { pgb, label };
                this.Invoke(delegadoFinalizar, parametros);
            }
            else
            {
                if(pgb.Value == pgb.Maximum)
                {
                    label.Text = "Finalizado";
                }
                else
                {
                    label.Text = "Cancelado";
                }
            }
        }

        private void FrmHilos_Load(object sender, EventArgs e)
        {
            this.InicializarHilos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }

        private void FrmHilos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Task item in this.hilos)
            {
                sb.Append($"Hilo {item.Id} ");
                string mensaje = item.IsCanceled ? $"está completado." : $"en estado {item.Status}.";
                sb.Append(mensaje);
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();

            while (!hilos.All(h => h.IsCompleted))
            {
                await Task.Delay(1000);
            }

            this.InicializarHilos();
        }
    }
}
