using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesSP;

namespace SP.LABII.WinFormsApp
{
    ///Agregar manejo de excepciones en TODOS los lugares críticos!!!


    ///Crear, en EntidadesSP, la clase ADO.
    ///Dicha clase se deberá comunicar con la base de datos, tendrá:
    ///Métodos de clase:
    ///ObtenerTodos() : List<Articulo>
    ///ObtenerTodos(string) : List<Articulo> -> se obtienen por marca 
    ///de acuerdo al parámetro recibido
    ///Métodos de instancia:
    ///Agregar(Articulo) : bool
    ///Modificar(Articulo) : bool -> se modifica a partir del código
    ///Eliminar(Articulo) : bool -> se elimina a partir del código
    ///
    
    public partial class FrmParteDos : Form
    {
        List<EntidadesSP.Articulo> lista;

        public FrmParteDos()
        {
            InitializeComponent();

            this.Text = "Dacal Federico";
            MessageBox.Show(this.Text);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FrmParteDos_Load(object sender, EventArgs e)
        {
            this.CargarListadoArticulosBD();
        }

        public void CargarListadoArticulosBD()
        {
            ///Utilizando la clase ADO, obtener y mostrar todos los articulos
            ///en lstVisorBD          
            try
            {
                this.lista = EntidadesSP.ADO.ObtenerTodos();
                this.lstVisorBD.DataSource = this.lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        ///Agregar un nuevo artículo a la base de datos.
        ///Utilizar FrmArticulo.
        ///Si la marca ya existe en la base, se disparará el evento MarcaExistente. 
        ///Diseñarlo (de acuerdo a las convenciones vistas) en la clase ADO. 
        ///Crear el manejador (Manejador_marcaExistente) para que, una vez capturado el evento, 
        ///se muestren con un MessageBox: 
        ///la fecha (con hora, minutos y segundos) y todos los datos de los artículos (existentes en la bd)
        ///que coincidan con esa marca.
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                EntidadesSP.ADO ado = new EntidadesSP.ADO();

                ado.MarcaRepetida += Manejador_marcaExistente;
                ///Asociar 'dinámicamente' el manejador de eventos (Manejador_marcaExistente) aquí 


                if (ado.Agregar(frm.MiArticulo))
                {
                    this.CargarListadoArticulosBD();

                    MessageBox.Show("Artículo agregado!!!");
                }
                else
                {
                    MessageBox.Show("No se agregó el artículo!!!");
                }

                ///Desasociar 'dinámicamente' el manejador de eventos (Manejador_marcaExistente) aquí 

            }
        }

        ///Modificar el artículo seleccionado (el código no se debe modificar, adecuar FrmArticulo)
        ///reutilizar FrmArticulo
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lstVisorBD.SelectedItem is not null)
                {
                    Articulo articulo = (Articulo)this.lstVisorBD.SelectedItem;

                    FrmArticulo frm = new FrmArticulo(articulo);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ADO ado = new ADO();

                        if (ado.Modificar(frm.MiArticulo))
                        {
                            this.CargarListadoArticulosBD();

                            MessageBox.Show("Modificado");
                        }
                        else
                        {
                            MessageBox.Show("No se modificó");
                        }
                    }
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///Eliminar el artículo seleccionado 
        ///reutilizar FrmArticulo
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lstVisorBD.SelectedItem is not null)
                {
                    Articulo articulo = (Articulo)this.lstVisorBD.SelectedItem;

                    FrmArticulo frm = new FrmArticulo(articulo);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ADO ado = new ADO();

                        if (ado.Eliminar(frm.MiArticulo))
                        {
                            this.CargarListadoArticulosBD();

                            MessageBox.Show("Elimnado");
                        }
                        else
                        {
                            MessageBox.Show("No se eliminó");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///Crear el manejador de eventos, Manejador_marcaExistente, aquí:
        private void Manejador_marcaExistente(object sender, MarcaRepetidaEventArgs e)
        {
            try
            {
                List<Articulo> lista = ADO.ObtenerTodos(e.Marca);

                foreach (Articulo item in lista)
                {
                    MessageBox.Show(item.ToString(), "Marcas repetidas " + DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
