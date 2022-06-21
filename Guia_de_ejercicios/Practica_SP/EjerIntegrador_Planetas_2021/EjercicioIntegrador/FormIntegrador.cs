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
using Entidades;

namespace EjercicioIntegrador
{
    public partial class FormIntegrador : Form
    {
        public FormIntegrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /* 
          1- Crear un objeto de tipo Planeta.
          2- Serializarlo y mostrar en un MessageBox lo sucedido.
          3- Si serializo, deserializarlo y mostrarlo en el ListBox.
        */
        private void btn1_Click(object sender, EventArgs e)
        {
            Planeta planeta = new Planeta(10, "Tierra", 1, 9.8);

            try
            {
                if (planeta.SerializarXml())
                {
                    MessageBox.Show("Planeta serializado", "XML OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.lstPlanetas.Items.Add(planeta.DeserializarXml());
                }
                else
                {
                    MessageBox.Show("Planeta no serializado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Planeta no serializado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /*
        1- Crear tres objetos de tipo Planeta.
		2- Crear objeto de tipo SistemaSolar.
		3- Agregarlos planetas al sistema solar.
        4- Serializar SistemaSolar.
        5- Mostrarlo en el ListBox.
        */
        private void btn2_Click(object sender, EventArgs e)
        {
            Planeta p1 = new Planeta(11, "Marte", 2, 3.7);
            Planeta p2 = new Planeta(12, "Saturno", 9, 24.7);
            Planeta p3 = new Planeta(13, "Neptuno", 3, 11.15);

            SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(3);

            sistemaSolar.Agregar(p1);
            sistemaSolar.Agregar(p2);
            sistemaSolar.Agregar(p3);

            try
            {
                if (sistemaSolar.SerializarXml())
                {
                    MessageBox.Show("Sistema serializado", "XML OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MessageBox.Show(sistemaSolar.DeserializarXml(), "XML OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Planeta item in sistemaSolar.Lista)
                    {
                        this.lstPlanetas.Items.Add(item.ToString());
                    }     
                }
                else
                {
                    MessageBox.Show("Sistema no serializado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sistema no serializado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /*
         1- Crear tres objetos de tipo Planeta.
		 2- Crear objeto de tipo SistemaSolar con capacidad=2.
		 3- Atrapar la Excepción "NoHayLugarException" en un bloque try-catch 
         4- Mostrar el mensaje de error en un MessageBox.
         */
        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                Planeta p1 = new Planeta(11, "Marte", 2, 3.7);
                Planeta p2 = new Planeta(12, "Saturno", 9, 24.7);
                Planeta p3 = new Planeta(13, "Neptuno", 3, 11.15);

                SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(2);

                sistemaSolar.Agregar(p1);
                sistemaSolar.Agregar(p2);
                sistemaSolar.Agregar(p3);
            }
            catch (NoHayLugarException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "No es posible añadir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
         * 1-Creo un objeto planeta
         * 2-Asociar evento al manejador "PlanetaConMuchaGravedad"
         * 3-Hago saltar el evento
         * 4-Atrapo y muestro la gravedad del planeta en un MessageBox
         
         */

        private void btn4_Click(object sender, EventArgs e)
        {
            Planeta planeta = new Planeta(15, "Magnus", 32, 29);
            planeta.MuchaGravedad += PlanetaConMuchaGravedad;

            planeta.Gravedad = 40;
        }

        private void PlanetaConMuchaGravedad(Planeta sender, double gravedad)
        {
            MessageBox.Show($"Planeta con mucha gravedad!!! {gravedad}m/s");
            this.lstPlanetas.Items.Add(sender);
        }


        /*
         1-Crea un Task, creo el método TraerPlanetas():void
         2-En el subproceso invoco al método TraerPlanetas()
         2-Traigo los planetas de la base de datos a través del hilo secundario.
         3-Modifico el ListBox a través del hilo principal.
         */
        private void btnTraer_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() => TraerPlanetas());
        }

        private void TraerPlanetas()
        {
            try
            {
                List<Planeta> planetasDB = AccesoDatos.ObtenerLista();
                if(planetasDB != null)
                {
                    if (this.lstPlanetas.InvokeRequired)
                    {
                        Thread.Sleep(1000);
                        Action action = new Action(this.TraerPlanetas);
                        this.lstPlanetas.Invoke(action);
                    }
                    else
                    {
                        this.lstPlanetas.Items.Clear();
                        foreach (Planeta item in planetasDB)
                        {
                            this.lstPlanetas.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         1- Invoca al formulario de alta.
		 2- Si se acepta, se actualiza BD, se agrega a la lista.
         3- Retorna la lista y muestra en el RichTextBox.
         * */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormAlta frmAlta = new FormAlta();
                DialogResult rta = frmAlta.ShowDialog();

                if (rta == DialogResult.OK)
                {
                    if (AccesoDatos.AgregarPlaneta(frmAlta.Planeta))
                    {
                        this.TraerPlanetas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /*
         1 Invoca el formulario de alta a modificar pasandole los datos para mostrar.
		 2- Si se acepta el modificado, se actualiza BD 
         3- Retorna la lista y muestra en el ListBox.
         * */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.lstPlanetas.SelectedItem != null)
                {
                    Planeta auxPlaneta = (Planeta)this.lstPlanetas.SelectedItem;
                    FormAlta frmAlta = new FormAlta(auxPlaneta, "Modificar");
                    DialogResult rta = frmAlta.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        if (AccesoDatos.ModificarPlaneta(frmAlta.Planeta))
                        {
                            this.TraerPlanetas();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*
         1- Invoca el formulario de alta a eliminar pasandole los datos para mostrar.
		 2- Si se acepta el eliminado, se actualiza BD
         3-retorna la lista y muestra.
         */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lstPlanetas.SelectedItem != null)
                {
                    Planeta auxPlaneta = (Planeta)this.lstPlanetas.SelectedItem;
                    FormAlta frmAlta = new FormAlta(auxPlaneta, "Eliminar");
                    DialogResult rta = frmAlta.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        if (AccesoDatos.EliminarPlaneta(frmAlta.Planeta.Id))
                        {
                            this.TraerPlanetas();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
    }
}
