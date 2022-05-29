using System;
using System.Text;

namespace Entidades
{
    //La clase debe ser pública
    public class Dato
    {
        // Atributos públicos, si son privados necesito que tenga Propiedades de lectura y escritura (las colecciones sólo necesitan Propiedad de lectura)
        public string nombre;
        public int edad;

        //El constructor por defecto es requerido 
        //para poder serializar a XML
        public Dato()
        {

        }

        public Dato(string nombre, int edad)
        {
            this.nombre = nombre; 
            this.edad = edad;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append("Nombre: ");
            cadena.AppendLine(this.nombre);
            cadena.Append("Edad: ");
            cadena.AppendLine(this.edad.ToString());

            return cadena.ToString();
        }
    }
}
