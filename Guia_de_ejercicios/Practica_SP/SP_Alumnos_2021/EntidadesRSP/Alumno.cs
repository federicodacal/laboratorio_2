using System;

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
namespace EntidadesRSP
{
    public delegate void DelegadoAlumno(Alumno sender, AlumnoEventArgs e);

    public class Alumno : Persona
    {
        private double nota;

        public event DelegadoAlumno Aprobar;
        public event DelegadoAlumno NoAprobar;
        public event DelegadoAlumno Promocionar;

        public Alumno()
        {

        }

        public Alumno(int dni, string apellido, string nombre, double nota)
            :base(dni, apellido, nombre)
        {
            this.nota = nota;
        }

        public double Nota { get => nota; set => nota = value; }

        public void Calificar()
        {
            AlumnoEventArgs eventArgs = new AlumnoEventArgs();
            eventArgs.Nota = this.Nota;

            if (this.Nota < 4)
            {
                if(this.NoAprobar is not null)
                {                 
                    this.NoAprobar(this, eventArgs);
                }
            }
            else
            {
                if(this.Nota >= 4 && this.Nota < 6)
                {
                    if(this.Aprobar is not null)
                    {
                        this.Aprobar(this, eventArgs);
                    }
                }
                else
                {
                    if(this.Promocionar is not null)
                    {
                        this.Promocionar(this, eventArgs);
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"Alumno: {base.ToString()} - Nota {this.Nota}";
        }
    }
}
