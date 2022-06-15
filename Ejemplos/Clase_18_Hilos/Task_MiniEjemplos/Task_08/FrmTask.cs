using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_07
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        private async void btn_iniciarLongTask_Click(object sender, EventArgs e) // t0
        {
            this.lb_informacion.Text = await GestorDatos.TraerRegistrosAsync();
        }
    }
}
