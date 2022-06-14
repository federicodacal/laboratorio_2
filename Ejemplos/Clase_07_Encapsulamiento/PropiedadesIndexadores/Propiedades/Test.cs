using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Test
    {
        private String cadena;
        private Int32 entero;
        private Single flotante;

        #region Métodos Getters y Setters

        #region Getters

        public String GetCadena() { return this.cadena; }
        public Int32 GetEntero() { return this.entero; }
        public Single GetFlotante() { return this.flotante; }

        #endregion

        #region Setters

        public void SetCadena(String cadena) { this.cadena = cadena; }
        public void SetEntero(Int32 nroEntero) { this.entero = nroEntero; }
        public void SetFlotante(Single nroFlotante) { this.flotante = nroFlotante; }

        #endregion

        #endregion

        #region Método

        public string TestToString()
        {
            String retorno = "";

            retorno = "Cadena: " + this.cadena + "\n" + "Entero: " + this.entero + "\n" +
                      "Flotante: " + this.flotante + "\n";

            return retorno;
        }

        #endregion




        #region Mejoras

        #region Propiedades

        public String Cadena
        {
            get { return this.cadena; }
            set { this.cadena = value; }
        }
        public Int32 Entero
        {
            get { return this.entero; }
            set { this.entero = value; }
        }
        public Single Flotante
        {
            get { return this.flotante; }
            set { this.flotante = value; }
        }

        #endregion

        #region Método con StringBuilder

        public string TestToStringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Cadena: ");
            sb.AppendLine(this.cadena);

            sb.Append("Entero: ");
            sb.AppendLine(this.entero.ToString());

            sb.Append("Flotante: ");
            sb.AppendLine(this.flotante.ToString());

            return sb.ToString();
        }
        #endregion

        #region Más Propiedades

        #region Propiedad Sólo Lectura

        public string PropiedadSoloLectura
        {
            get { return this.TestToStringBuilder(); }
        }
        #endregion

        #region Propiedad Sólo Escritura

        public Int32 PropiedadSoloEscritura
        {
            set
            {
                if (value != this.entero)
                {
                    this.entero = value;
                }
                else
                {
                    Console.WriteLine("Es el mismo valor!!!");
                }
            }
        }

        #endregion

        #region Propiedad Auto-Contenida

        public DateTime PropiedadAutoContenida { get; set; }

        #endregion

        #endregion

        #endregion

    }
}
