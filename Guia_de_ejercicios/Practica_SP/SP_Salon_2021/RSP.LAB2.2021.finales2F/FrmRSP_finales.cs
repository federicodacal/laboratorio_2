using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace RSP.LAB2._2021.finales2F
{
    public partial class FrmRSP_finales : Form
    {
        public FrmRSP_finales()
        {
            InitializeComponent();
        }

        //Cambiar por su apellido y nombre
        private void FrmRSP_finales_Load(object sender, EventArgs e)
        {
            this.Text = "Dacal Federico";
            MessageBox.Show(this.Text);

            //Agregar los manejadores de eventos para cada botón, de forma dinámica.
            this.btnPunto1.Click += this.btnPunto1_Click;
            this.btnPunto2.Click += this.btnPunto2_Click;
            this.btnPunto3.Click += this.btnPunto3_Click;
            this.btnPunto4.Click += this.btnPunto4_Click;
            this.btnPunto5.Click += this.btnPunto5_Click;
            this.btnPunto6.Click += this.btnPunto6_Click;
            this.btnPunto7.Click += this.btnPunto7_Click;
            this.btnPunto8.Click += this.btnPunto8_Click;
        }

        //Desarrollar la siguiente jerarquia de clases, en un class library:
        //Humano (nombre:string;  idioma:EIdioma;) - ToString():string
        //Persona (apellido:string; edad:Sbyte) - ToString():string (polimorfismo; reutilizar código) 
        //Alumno (legajo: Short; nivel: ENivelDeEstudio) - ToString():string (polimorfismo; reutilizar código)
        //AlumnoEgresado (promedio: float; promocion: Short) - ToString():string (polimorfismo; reutilizar código) 
        //Todos los atributos de las clases son públicos y además:
        //que todas las clases poseen un sólo constructor (sin sobrecargas).
        //Realice los constructores de cada una de las clases, sabiendo:
        //que AlumnoEgresado hereda de Alumno, que Alumno hereda de Persona y que éste último hereda de Humano.
        //EIdioma -> Inglés, Español, Portugués
        //ENivelDeEstudio -> Primaria, Secundaria, Terciaria, Universitaria
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Humano h = new Humano("Juan", EIdioma.Español);
            Persona p = new Persona("Brian", "Lopez", EIdioma.Portugués, 17);
            Alumno a = new Alumno(p, 123, ENivelDeEstudio.Primaria);
            AlumnoEgresado ae = new AlumnoEgresado(a, 4.5f, 2020);

            List<Humano> lista = new List<Humano>();
            lista.Add(h);
            lista.Add(p);
            lista.Add(a);
            lista.Add(ae);

            foreach (Humano item in lista)
            {
                MessageBox.Show(item.ToString());
            }
        }

        //Implementar en AlumnoEgresado: ISerializar(Xml(string):bool) de forma implícita e 
        //IDeserializar(Xml(string, out AlumnoEgresado):bool) de forma explícita
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Juanfer", "Quintero", EIdioma.Español, 27);
            AlumnoEgresado a = new AlumnoEgresado(new Alumno(p, 123, ENivelDeEstudio.Primaria), 8.8f, 2001);
            AlumnoEgresado aux = null;

            try
            {
                if (a.Xml("alumno.xml"))
                {
                    MessageBox.Show("Serializado OK");
                }
                else
                {
                    MessageBox.Show("NO Serializado");
                }

                if (((IDeserializar)a).Xml("alumno.xml", out aux))
                {
                    MessageBox.Show("Deserializado OK");
                    MessageBox.Show(aux.ToString());
                }
                else
                {
                    MessageBox.Show("NO Deserializado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Realizar el burbujeo de una excepción propia (MiException), comenzando en un método de instancia
        //(de la clase Burbujeo), pasando por un método estático (de la misma clase *) y capturado 
        //por última vez en el método que lo inicio (manejador btnPunto3_Click). 
        //En cada paso, agregar en un único archivo de texto (burbujeo.log), en la carpeta 
        //'Mis documentos' del cliente, el lugar por donde se pasó junto con la hora, minuto y segundo de la acción. 
        //Atrapar la excepción y relanzarla en cada ocación.
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            try
            {
                Burbujeo.MetodoClase(); //* Método de inicio
            }
            catch (MiException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Crear y configurar un OpenFileDialog, para poder seleccionar el log de excepciones
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            //titulo -> 'Abrir archivo de excepciones'
            //directorio por defecto -> Mis documentos
            //tipo de archivo (filtro) -> .log
            //extensión por defecto -> .log
            //nombre de archivo (defecto) -> burbujeo

            try
            {
                string file;

                this.openFileDialog1.Title = "Abrir archivo";
                this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                this.openFileDialog1.Filter = "LOG files|*.log";
                this.openFileDialog1.DefaultExt = "log";
                this.openFileDialog1.CheckPathExists = true;
                this.openFileDialog1.FileName = "burbujeo.log";

                DialogResult rta = this.openFileDialog1.ShowDialog();//Reemplazar por la llamada al método correspondiente del OpenFileDialog

                file = this.openFileDialog1.FileName;

                if (rta == DialogResult.OK)
                {
                    if(file is not null)
                    {
                        this.txtVisorExcepciones.Text = this.LeerArchivoTxt(file);
                    }
                }

                //leer el archivo seleccionado por el cliente y mostrarlo en txtVisorExcepciones, 
                //sólo si se ha seleccionado algún archivo.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private string LeerArchivoTxt(string fileName)
        {
            string data = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    data = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return data;
        }

        // Generar la clase genérica Salón. Contiene el atributo elementos:List del tipo genérico.
        // (este sólo se podrá inicializar en el constructor por defécto, que además será privado)
        // y el atributo capacidad:int (generar un constructor público que lo reciba como parámetro).
        // Sobrecarga en el operador +.
        // Al sumar un Salón con un elemento de tipo Persona, se deberá agregar a la lista de elementos
        // SÓLO si el idioma de la persona es Español y aún hay lugar en el salon.
        //Eventos
        //Agregar en la clase Salón que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
        //Esto mostrará un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo según convenciones).
        //Agregar en la clase Salon que, si el idioma no es español, se lance un evento SalonNoEspañolEvent.
        //Esto mostrará un mensaje en el manejador Salon_SalonNoEspañolEvent (realizarlo según convenciones).
        private void btnPunto5_Click(object sender, EventArgs e)
        {

            Salon<Persona> s = new Salon<Persona>(3);

            s.SalonLlenoEvent += Salon_SalonLlenoEvent;
            s.SalonNoEspañolEvent += Salon_SalonNoEspañolEvent;

            Persona p = new Persona("Jose", "Lopez", EIdioma.Inglés, 67);
            Persona p1 = new Persona("Pedro", "Gonzalez", EIdioma.Español, 47);
            Persona p2 = new Persona("Susana", "Gimenez", EIdioma.Español, 75);

            s += p;
            s += p1;
            s += p2;
            s += p1;
            s += p1;
        }

        private void Salon_SalonLlenoEvent(Salon<Persona> sender)
        {
            MessageBox.Show($"Salón lleno!!!", "No hay más lugar disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Salon_SalonNoEspañolEvent(Salon<Persona> sender)
        {
            MessageBox.Show($"Salón sólo Español!!!", "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Agregar método de extensión (clase Extensora) en Persona MostrarBD():string.
        //MostrarBD retornará una cadena (Apellido, Nombre y Edad) de todos los registros de la BD.
        //Crear la base de datos 'final_lab_II', la cuál tendrá la tabla personas:
        //Tabla - personas { id(autoincremental - numérico) - apellido(cadena) - nombre(cadena) 
        //                   idioma(numérico) - edad(numérico) }.
        //USE [final_lab_II]
        //GO
        //CREATE TABLE [dbo].[personas](
        //[id] [int] IDENTITY(1,1) NOT NULL,
        //[apellido] [varchar] (50) NULL,
        //[nombre] [varchar] (50) NULL,
        //[idioma] [int] NULL,
        //[edad] [int] NULL,
        //CONSTRAINT[PK_personas] PRIMARY KEY CLUSTERED
        //(
        //[id] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
        //GO

        private void btnPunto6_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona("Oso", "Pratto", EIdioma.Español, 32);

                this.txtVisorBD.Text = p.MostrarDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Agregar otro método de extensión (clase Extensora) en Persona AgregarBD():bool.
        //AgregarBD retornará un booleano indicando si se pudo agregar o no a la base de datos.
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Pity", "Martínez", EIdioma.Español, 29);

            try
            {
                if (p.AgregarDB())
                {
                    this.txtVisorBD.Text = p.MostrarDB();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar a la BD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        //Threads
        //Iniciar un nuevo hilo que ejecute los manejadores de eventos de los botones del formulario:
        //RSP_Load, btnPunto1_Click, y btnPunto6_Click (con un intervalo dos segundos)
        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //Lanzar mediante un hilo el método ProbarTodo.
            Task task = Task.Run(() => this.ProbarTodo());
        }

        //para el thread
        private async void ProbarTodo()
        {
            if (this.InvokeRequired)
            {
                Action action = new Action(this.ProbarTodo);

                this.Invoke(action);
            }
            else
            {
                this.FrmRSP_finales_Load(this, EventArgs.Empty);
                await Task.Delay(2000);
                this.btnPunto1_Click(this, EventArgs.Empty);
                await Task.Delay(2000);
                this.btnPunto5_Click(this, EventArgs.Empty);
            }
        }
    }
}
