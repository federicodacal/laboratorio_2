using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmCurso : Form
    {
        private Curso curso;
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            short anio = (short)this.nudAnioCurso.Value;
            string nombre = this.txtNombreProfe.Text;
            string apellido = this.txtApellidoProfe.Text;
            string documento = this.txtDocProfesor.Text;
            DateTime ingreso = this.dtpIngreso.Value;
            Divisiones division = (Divisiones)this.cmbDivisionCurso.SelectedItem;

            if(anio > 0 && anio < 7 && !String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(apellido) && !String.IsNullOrWhiteSpace(documento) && ingreso < DateTime.Now)
            {
                this.curso = new Curso(anio, division, new Profesor(nombre, apellido, documento, ingreso));
                MessageBox.Show("Se ha creado el curso");
            }
            else
            {
                MessageBox.Show("Hay datos incompletos o incorrectos");
            }
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(this.curso is not null)
            {
                this.rtbInfo.Text = (string)this.curso;
            }
            else
            {
                MessageBox.Show("No hay un curso creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            short anio = (short)this.nudAnioAlumno.Value;
            string nombre = this.txtNombreAlumno.Text;
            string apellido = this.txtApellidoAlumno.Text;
            string legajo = this.txtLegajoAlumno.Text;
            Divisiones division = (Divisiones)this.cmbDivisionAlumno.SelectedItem;

            if(this.curso is not null)
            {
                if (anio > 0 && anio < 7 && !String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(apellido) && !String.IsNullOrWhiteSpace(legajo))
                {
                    Alumno nuevoAlumno = new Alumno(nombre, apellido, legajo, anio, division);
                    this.curso += nuevoAlumno;
                    if (this.curso.Alumnos.Contains(nuevoAlumno))
                    {
                        MessageBox.Show("Se agregó alumno");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar alumno");
                    }
                }
                else
                {
                    MessageBox.Show("Hay campos incompletos o incorrectos");
                }
            }
        }
    }
}
