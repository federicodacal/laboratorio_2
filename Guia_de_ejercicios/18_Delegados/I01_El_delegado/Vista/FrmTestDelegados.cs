using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void DelegadoActualizarNombre(string nombre);

        private DelegadoActualizarNombre delegado;  

        public FrmTestDelegados(DelegadoActualizarNombre delegado)
        {
            InitializeComponent();
            this.delegado = delegado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.delegado is not null)
            {
                this.delegado.Invoke(this.txtNombre.Text);
            }
        }
    }
}
