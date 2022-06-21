using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//AlumnoEgresado (promedio: float; promocion: Short) - ToString():string (polimorfismo; reutilizar código) 
namespace Entidades
{
    public class AlumnoEgresado : Alumno, ISerializar, IDeserializar
    {
        private float promedio;
        private short promocion;

        public AlumnoEgresado()
        {

        }

        public AlumnoEgresado(Alumno a, float promedio, short promocion):base(new Persona(a.Nombre, a.Apellido, a.Idioma, a.Edad), a.Legajo, a.Nivel)
        {
            this.promedio = promedio;
            this.promocion = promocion;
        }

        public float Promedio { get => promedio; set => promedio = value; }
        public short Promocion { get => promocion; set => promocion = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Promedio {this.Promedio} - Promocion {this.Promocion}";
        }

        public bool Xml(string path)
        {
            try
            {
                bool rta = false;
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), path)))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(AlumnoEgresado));
                    xs.Serialize(sw, this);
                    rta = true;
                }
                return rta;
            }
            catch
            {
                throw;
            }
        }

        bool IDeserializar.Xml(string path, out AlumnoEgresado alumno)
        {
            try
            {
                bool rta = false;
                using (StreamReader sr = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), path)))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(AlumnoEgresado));
                    alumno = xs.Deserialize(sr) as AlumnoEgresado;
                    rta = true;
                }
                return rta;
            }
            catch
            {
                throw;
            }

        }
    }
}
