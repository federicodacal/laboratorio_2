using System;
using System.Text;
using Entidades;

namespace TestEntidades.Métodos_de_extensión
{
    public static class Extensora
    {

        #region Para clases propias

        public static string ObtenerInfoExtension(this Persona p)
        {
            return p.Nombre + " - " + p.Edad;
        }

        #endregion

        #region Para clases de terceros

        public static string ObtenerInfoExtension(this Entidades.Externa.Sellada.Persona ps)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(ps.Nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(ps.Apellido);
            sb.Append("Edad: ");
            sb.AppendLine(ps.Edad.ToString());

            return sb.ToString();
        }

        #endregion

        #region Para object

        public static bool EsNulo(this object o)
        {
            return o == null;
        }

        #endregion

        #region Para string

        public static int CantidadDePalabras(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        #endregion

        #region Para clases de terceros, con parámetros

        public static bool CompararNombreExtensionParam(this Entidades.Externa.Sellada.Persona ps, string nombre)
        {
            return nombre == ps.Nombre;
        }

        #endregion

    }
}
