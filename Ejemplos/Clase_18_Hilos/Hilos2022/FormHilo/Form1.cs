using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hilos2021;
using System.Threading;

namespace FormHilo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(()=> { this.Cambiar(); } );
        }

        private void Cambiar()
        {
            this.lblTexto.Text = "Cambio texto en el hilo: "+Thread.CurrentThread.ManagedThreadId;
        }
    }
}
