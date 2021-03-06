using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Hilos2022;

namespace HilosForm
{

    public delegate void MiDelegado(string path);

    public partial class Form_Hilos2 : Form
    {

        public Form_Hilos2()
        {
            InitializeComponent();
        }

        private void btnCambiarTexto_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(() => { this.CambiarTexto(); });
        }

        private void CambiarTexto()
        {
            //ERROR
            //this.lblTexto.Text = "CAMBIANDO TEXTO!!";
            
            if (this.lblTexto.InvokeRequired) // this.InvokeRequired
            {
                //Action d = new Action(this.CambiarTexto);

                //this.lblTexto.Invoke(d);
                              
                this.lblTexto.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblTexto.Text = "cambio en begin invoke";
                }
                );
            }
            else
            {
                this.lblTexto.Text = "CAMBIANDO TEXTO!!";
            }




        }

        private void BtnCambiarFoto(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            path += @"\afremov.jpg";

            Task t = Task.Run(() => { this.CambiarFoto(path); });
        }

        private void CambiarFoto(string path)
        {

            if (this.pictureBox.InvokeRequired)
            {
                MiDelegado d = new MiDelegado(this.CambiarFoto);

                object[] obj = new object[] { path };

                this.Invoke(d, obj);
            }
            else
            {
                this.pictureBox.BorderStyle = BorderStyle.Fixed3D;
                this.pictureBox.ImageLocation = path;
            }
        }

    }
}
