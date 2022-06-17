using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmReloj : Form
    {
        public FrmReloj()
        {
            InitializeComponent();
        }

        private void FrmReloj_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();

            //reloj.SegundoCambiado += new Reloj.NotificadorCambioTiempo(AsignarHora);
            reloj.SegundoCambiado += this.AsignarHora;

            reloj.Iniciar();
        }

        public void AsignarHora(Reloj reloj)
        {
            if (this.lblHora.InvokeRequired)
            {
                Action<Reloj> delegado = this.AsignarHora;
                object[] param = new object[] { reloj };

                this.lblHora.Invoke(delegado, param);
            }
            else
            {
                this.lblHora.Text = reloj.ToString();
            }
        }
    }
}
