using System;
using System.Windows.Forms;
using EntidadesRSP;

namespace WinFormsAppRSP
{
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;
        private string accion;

        public Alumno Alumno
        {
            get { return alumno; }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }

        public FrmAlumno(Alumno alumno, string accion):this()
        {
            this.alumno = alumno;
            this.accion = accion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double nota;
            int dni;
            if(!String.IsNullOrWhiteSpace(this.txtApellido.Text) && !String.IsNullOrWhiteSpace(this.txtNombre.Text) && !String.IsNullOrWhiteSpace(this.txtDNI.Text) && !String.IsNullOrWhiteSpace(this.txtNota.Text) && int.TryParse(this.txtDNI.Text, out dni) && double.TryParse(this.txtNota.Text, out nota))
            {
                if(this.alumno is null)
                {
                    this.alumno = new Alumno(dni, this.txtApellido.Text, this.txtNombre.Text, nota);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.alumno.Apellido = this.txtApellido.Text;
                    this.alumno.Nombre = this.txtNombre.Text;
                    this.alumno.Nota = nota;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Campos incompletos o erróneos", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            if(this.alumno is not null)
            {
                this.txtApellido.Text = this.alumno.Apellido;
                this.txtNombre.Text = this.alumno.Nombre;
                this.txtDNI.Text = this.alumno.Dni.ToString();
                this.txtNota.Text = this.alumno.Nota.ToString();
                this.txtDNI.Enabled = false;

                if(this.accion == "Eliminar")
                {
                    this.txtApellido.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.txtNota.Enabled = false;
                }
            }
        }
    }
}
