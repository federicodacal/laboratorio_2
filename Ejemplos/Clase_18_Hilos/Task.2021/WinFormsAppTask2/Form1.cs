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

namespace WinFormsAppTask2
{
    public delegate void DelegadoTaskConParam(object param);

    public partial class Form1 : Form
    {
        protected Task hilo;

        public Form1()
        {
            InitializeComponent();

            Action<object> delegado = this.DoWork;

            this.hilo = new Task(delegado, 0);

            this.imgImagen.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\img\bernabeu.jpg";

            this.StartPosition = FormStartPosition.CenterScreen;

            this.btnIniciar.Click += new EventHandler(this.btnIniciar_Click);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //this.hilo = Task.Run(() => this.DoWork("parámetros"));

            this.hilo.Start();

            this.btnIniciar.Click -= new EventHandler(this.btnIniciar_Click);
        }

        private void DoWork(object param)
        {

            if (this.imgImagen.InvokeRequired)
            {
                bool continua = true;
                int highLights = 0;
                string resultado = "";

                DelegadoTaskConParam delegado = new DelegadoTaskConParam(this.DoWork);

                object[] imagen = new object[8];

                imagen[0] = AppDomain.CurrentDomain.BaseDirectory + @"\img\2018.jpg";
                imagen[1] = AppDomain.CurrentDomain.BaseDirectory + @"\img\pipa.jpg";
                imagen[2] = AppDomain.CurrentDomain.BaseDirectory + @"\img\oso_pratto.jpg";
                imagen[3] = AppDomain.CurrentDomain.BaseDirectory + @"\img\juanfer.jpg";
                imagen[4] = AppDomain.CurrentDomain.BaseDirectory + @"\img\pity.jpg";
                imagen[5] = AppDomain.CurrentDomain.BaseDirectory + @"\img\muñeco.jpg";
                imagen[6] = AppDomain.CurrentDomain.BaseDirectory + @"\img\river_campeon.jpg";

                do
                {
                    switch (highLights)
                    {
                        case 0:
                            resultado = "0 - 0";
                            break;
                        case 1:
                            resultado = "0 - 1";
                            break;
                        case 2:
                            resultado = "1 - 1";
                            break;
                        case 3:
                            resultado = "2 - 1";
                            break;
                        case 4:
                            resultado = "3 - 1";
                            break;
                        case 5:
                        case 6:
                            resultado = "RIVER CAMPEÓN!!!";
                            break;
                    }

                    //ARRAY DE OBJECT PARA EL PARAMETRO
                    object parametro = new object[] { imagen[highLights], resultado };

                    highLights++;

                    //DESDE EL HILO PRINCIPAL, INVOCO AL DELEGADO
                    this.Invoke(delegado, parametro);

                    if (highLights == 7)
                    {
                        continua = false;
                    }

                    Thread.Sleep(3000);

                } while (continua);


            }
            else
            {
                this.imgImagen.ImageLocation = ((object[])param)[0].ToString();
                this.lblResultado.Text = ((object[])param)[1].ToString();
            }

        }
    }
}
