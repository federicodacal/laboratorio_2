using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using EntidadesRSP;

namespace WinFormsAppRSP
{
    ///Agregar manejo de excepciones en TODOS los lugares críticos!!!

    public partial class FrmPrincipal : Form
    {
        ///Crear en un proyecto de tipo class library (EntidadesRSP), las clases:
        ///Persona
        ///Atributos (todos privados)
        ///dni : int
        ///apellido : string
        ///nombre : string
        ///Propiedades públicas de lectura y escritura para todos sus atributos.
        ///Constructor que reciba parámetros para cada atributo
        ///Polimorfismo sobre ToString
        ///
        ///Alumno (deriva de Persona)
        ///Atributo
        ///nota : double
        ///Propiedad pública de lectura y escritura para su atributo.
        ///Constructor que reciba parámetro para cada atributo
        ///Polimorfismo sobre ToString
        ///Eventos (diseñados según convenciones vistas)
        ///Aprobar
        ///NoAprobar
        ///Promocionar
        ///Método de instancia (público)
        ///Clasificar() : void
        ///Si el atributo nota es menor a 4, lanzará el evento NoAprobar.
        ///Si el atributo nota es menor a 6 (y mayor o igual a 4), lanzará el evento Aprobar.
        ///Si el atributo nota es mayor o igual a 6, lanzará el evento Promocionar.
        ///
        ///AlumnoADO (hereda de Alumno)
        ///Atributos (estáticos)
        ///conexion : string
        ///connection : SqlConnection
        ///command : SqlCommand
        ///Constructor de clase que inicialice todos sus atributos
        ///Constructor que recibe un objeto de tipo Alumno cómo parámetro
        ///Métodos de instancia (públicos):
        ///ObtenerTodos() : List<Alumno> 
        ///Agregar() : bool
        ///Modificar() : bool -> se modifica a partir del dni
        ///Eliminar() : bool -> se elimina a partir del dni

        ///BASE DE DATOS
        ///Crear la BASE de DATOS utn_fra_alumnos y ejecutar el siguiente script:
        ///USE [utn_fra_alumnos]
        ///GO
        ///CREATE TABLE [dbo].[alumnos]
        ///(
        ///[dni] [int] NOT NULL,
        ///[apellido] [varchar](50) NOT NULL,
        ///[nombre] [varchar](50) NOT NULL,
        ///[nota] [float] NOT NULL,
        ///) ON[PRIMARY]
        ///GO
        ///

        private List<EntidadesRSP.Alumno> alumnos;
        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = "Dacal Federico";
            MessageBox.Show(this.Text);

            try
            {
                this.CargarListados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo leer la BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ///Agregar los manejadores de eventos para: 
            ///btnAgregar, btnEliminar, btnModificar, btnSerializar, btnDeserializar y btnHilos
            this.btnAgregar.Click += this.ManejadorAgregar; 
            this.btnEliminar.Click += this.ManejadorEliminar; 
            this.btnModificar.Click += this.ManejadorModificar; 
            this.btnSerializar.Click += this.ManejadorSerializar; 
            this.btnDeserializar.Click += this.ManejadorDeserializar; 
            this.btnHilos.Click += this.ManejadorHilos; 

        }

        private void CargarListados()
        {
            this.lstAprobados.Items.Clear();
            this.lstDesaprobados.Items.Clear();
            this.lstPromocionados.Items.Clear();

            ///Utilizando la clase AlumnoADO, obtener y mostrar todos los productos
            ///
            this.alumnos = EntidadesRSP.AlumnoADO.ObtenerTodos();
            this.lstTodos.DataSource = this.alumnos;


            foreach (EntidadesRSP.Alumno item in this.alumnos)
            {
                ///Agregar, para los eventos
                ///Aprobar, NoAprobar y Promocionar, los manejadores
                ///AlumnoAprobado, AlumnoNoAprobado y AlumnoPromocionado, respectivamente

                item.Aprobar += AlumnoAprobado;
                item.NoAprobar += AlumnoNoAprobado;
                item.Promocionar += AlumnoPromocionado;

                item.Calificar();

                ///Quitar los manejadores de eventos para:
                ///Aprobar, NoAprobar y Promocionar
                ///
                item.Aprobar -= AlumnoAprobado;
                item.NoAprobar -= AlumnoNoAprobado;
                item.Promocionar -= AlumnoPromocionado;
            }
        }

        private void ManejadorAgregar(object emisor, EventArgs argumentos)
        {
            ///Agregar un nuevo alumno a la base de datos
            ///Utilizar FrmAlumno.
            ///Si se pudo agregar, invocar al método CargarListados, caso contrario mostrar mensaje
            FrmAlumno frmAlumno = new FrmAlumno();

            DialogResult rta = frmAlumno.ShowDialog();

            try
            {
                if (rta == DialogResult.OK)
                {
                    AlumnoADO ado = new AlumnoADO(frmAlumno.Alumno);
                    if (ado.Agregar())
                    {
                        this.CargarListados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo leer la BD", "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManejadorModificar(object emisor, EventArgs argumentos)
        {
            ///Modificar el alumno seleccionado (el dni no se debe modificar, adecuar FrmAlumno)
            ///Se deben mostrar todos los datos en el formulario (adaptarlo)
            ///reutilizar FrmAlumno.
            ///Si se pudo modificar, invocar al método CargarListados, caso contrario mostrar mensaje

            try
            {
                if(this.lstTodos.SelectedItem is not null)
                {
                    FrmAlumno frmAlumno = new FrmAlumno((Alumno)this.lstTodos.SelectedItem, "Modificar");
                    DialogResult rta = frmAlumno.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        AlumnoADO ado = new AlumnoADO(frmAlumno.Alumno);
                        if (ado.Modificar())
                        {
                            this.CargarListados();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo leer la BD", "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ManejadorEliminar(object emisor, EventArgs argumentos)
        {
            ///Eliminar el alumno seleccionado (el dni no se debe modificar, adecuar FrmAlumno)
            ///Se deben mostrar todos los datos en el formulario (adaptarlo)
            ///reutilizar FrmAlumno.
            ///Si se pudo eliminar, invocar al método CargarListados, caso contrario mostrar mensaje

            try
            {
                if (this.lstTodos.SelectedItem is not null)
                {
                    FrmAlumno frmAlumno = new FrmAlumno((Alumno)this.lstTodos.SelectedItem, "Eliminar");
                    DialogResult rta = frmAlumno.ShowDialog();

                    if (rta == DialogResult.OK)
                    {
                        AlumnoADO ado = new AlumnoADO(frmAlumno.Alumno);
                        if (ado.Eliminar())
                        {
                            this.CargarListados();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo leer la BD", "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ManejadorSerializar(object emisor, EventArgs argumentos)
        {
            ///Serializar a XML la lista de alumnos del formulario (this.alumnos)
            ///El archivo .xml guardarlo en el escritorio del cliente, 
            ///con el nombre formado con su apellido.nombre.alumnos.xml
            ///Ejemplo: Alumno Juan Pérez -> perez.juan.alumnos.xml
            ///Indicar si se pudo o no serializar la lista de alumnos
            try
            {
                bool ok = false;

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dacal.federico.alumnos.xml");

                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Alumno>));
                    xs.Serialize(sw, this.alumnos);
                    ok = true;
                }

                if (ok)
                {
                    MessageBox.Show("Serialización XML Ok!", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Serialización fallida", "Mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ManejadorDeserializar(object emisor, EventArgs argumentos)
        {
            ///Deserializar de XML a una lista de alumnos
            ///El archivo .xml tomarlo del escritorio del cliente, 
            ///con el nombre formado con su apellido.nombre.alumnos.xml
            ///Ejemplo: Alumno Juan Pérez -> perez.juan.alumnos.xml
            ///Si se pudo serializar, mostrar el listado completo en un MessageBox.
            ///Si no se pudo deserializar, mostrar los motivos
            try
            {
                bool ok = false;

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dacal.federico.alumnos.xml");

                List<Alumno> auxAlumnos;

                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Alumno>));
                    auxAlumnos = xs.Deserialize(sr) as List<Alumno>;
                    ok = true;
                }

                string mensaje = "";
                foreach (Alumno item in auxAlumnos)
                {
                    mensaje += item.ToString();
                    mensaje += "\n";
                }

                if (ok)
                {
                    MessageBox.Show(mensaje, "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Serialización fallida", "Mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void AlumnoNoAprobado(object alumni, EventArgs e)
        {
            ///Agregar el alumno al listado lstDesaprobados
            this.lstDesaprobados.Items.Add(alumni);
        }

        public void AlumnoAprobado(object alumni, EventArgs e)
        {
            ///Agregar el alumno al listado lstAprobados
            this.lstAprobados.Items.Add(alumni);
        }

        public void AlumnoPromocionado(object alumni, EventArgs e)
        {
            ///Agregar el alumno al listado lstPromocionados
            this.lstPromocionados.Items.Add(alumni);
        }

        private void ManejadorHilos(object emisor, EventArgs argumentos)
        {
            ///Iniciar una nueva tarea en segundo plano que, para lstDesaprobados:
            ///cambie el color de fondo (a rojo) y el color de la fuente (a blanco)
            ///y lo intercambie (fondo a blanco y fuente a rojo) 10 veces,
            ///agregando un retardo de 1 segundo por cada intercambio.
            ///
            ///NOTA: propiedades BackColor (fondo) y ForeColor (fuente)
            ///colores: 
            ///System.Drawing.Color.Red (rojo)
            ///System.Drawing.Color.White (blanco)

            Task t = Task.Run(() => this.CambiarColores());
        }

        private async void CambiarColores()
        {
            int veces = 0;
            if (this.lstDesaprobados.InvokeRequired)
            {
                Action action = new Action(this.CambiarColores);

                this.lstDesaprobados.Invoke(action);
            }
            else
            {
                while (veces < 11)
                {
                    this.lstDesaprobados.BackColor = System.Drawing.Color.Red;
                    this.lstDesaprobados.ForeColor = System.Drawing.Color.White;
                    await Task.Delay(1000);
                    this.lstDesaprobados.BackColor = System.Drawing.Color.White;
                    this.lstDesaprobados.ForeColor = System.Drawing.Color.Red;
                    await Task.Delay(1000);
                    veces++;
                }
            }
        }

    }
}
