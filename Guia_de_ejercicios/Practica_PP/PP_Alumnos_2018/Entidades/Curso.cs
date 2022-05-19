using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profe;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profe):this()
        {
            this.anio = anio;
            this.division = division;
            this.profe = profe;
        }

        public string AnioDivision
        {
            get { return $"{this.anio}° {this.division}"; }
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{c.GetType().Name} {c.AnioDivision}");
            sb.AppendLine(c.profe.ExponerDatos());
            sb.AppendLine($"Lista de {c.alumnos.Count} alumnos");
            foreach (Alumno item in c.alumnos)
            {
                sb.AppendLine(item.ExponerDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool rta = false;
            if(c is not null && a is not null)
            {
                if(c.AnioDivision == a.AnioDivision)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
    }
}
