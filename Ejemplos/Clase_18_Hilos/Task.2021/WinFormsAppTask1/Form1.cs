using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTask1
{
    public delegate void DelegadoTaskSinParam();
    public delegate void DelegadoTaskConParam(object param);

    public partial class Form1 : Form
    {
        protected Task hilo;

        public Form1()
        {
            InitializeComponent();

            this.btnSinParams.Click += new EventHandler(this.ManejadorSinParams);
            this.btnConParams.Click += new EventHandler(this.ManejadorConParams);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ManejadorSinParams(object sender, EventArgs e)
        {
            this.hilo = Task.Run( () => this.DoWork());
        }

        private void ManejadorConParams(object sender, EventArgs e)
        {
            this.hilo = Task.Run(() => this.DoWorkParam("Desde hilo, con parámetros"));
        }

        public void DoWork()
        {
            //FALLA!!!
            //this.lblMensaje.Text = "Desde hilo";

            if (this.lblMensaje.InvokeRequired) // Cuando estoy desde un subproceso si voy a querer modificar un control, desde el subproceso esto se va a colocar como true porque lo voy a estar queriendo invocar desde el proceso que no genero el control
            {
                DelegadoTaskSinParam delegado = new DelegadoTaskSinParam(this.DoWork);

                //FALLA!!!
                //delegado.Invoke();

                //DESDE EL HILO PRINCIPAL, INVOCO AL DELEGADO
                this.Invoke(delegado);
            }
            else
            {
                this.lblMensaje.Text = "Desde hilo";
            }

        }

        public void DoWorkParam(object param)
        {
            if (this.lblMensaje.InvokeRequired) 
            {
                DelegadoTaskConParam delegado = new DelegadoTaskConParam(this.DoWorkParam);

                //ARRAY DE OBJECT PARA EL PARAMETRO
                object[] parametros = new object[] { param };

                //DESDE EL HILO PRINCIPAL, INVOCO AL DELEGADO
                this.Invoke(delegado, parametros);
            }
            else
            {
                this.lblMensaje.Text = param.ToString();
            }
        }
    }
}
