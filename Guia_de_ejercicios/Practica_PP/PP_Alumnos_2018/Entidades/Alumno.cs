using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones div)
            :base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = div;
        }

        public string AnioDivision
        {
            get { return $"{this.anio}° {this.division}"; }
        }


        protected override bool ValidarDocumentracion(string doc)
        {
            bool rta = false;

            if(doc is not null)
            {
                doc = doc.Trim();
                if(doc[2] == '-' && doc[7] == '-')
                {
                    string[] cadenasDoc = doc.Split('-');

                    if (cadenasDoc.Length == 3 && cadenasDoc[0].Length == 2 && cadenasDoc[1].Length == 4 && cadenasDoc[2].Length == 1)
                    {
                        int auxNum;
                        if (int.TryParse(cadenasDoc[0], out auxNum) && int.TryParse(cadenasDoc[1], out auxNum) && int.TryParse(cadenasDoc[2], out auxNum))
                        {
                            rta = true;
                        }
                    }
                } 
            }
            return rta;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ExponerDatos());
            sb.AppendLine($"Curso: {this.AnioDivision}");

            return sb.ToString();
        }
    }
}
