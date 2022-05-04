using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseWinForms
{
    public partial class FrmSecundario : Form
    {
        public FrmSecundario()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.rtbMensaje.Text += "Hola Mundo WinForms en un RichTextBox!!!\n";
        }
    }
}
