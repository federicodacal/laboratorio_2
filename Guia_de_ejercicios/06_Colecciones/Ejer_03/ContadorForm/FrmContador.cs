using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorForm
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtbInfo.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string item in palabras)
            {
                if (contadorPalabras.ContainsKey(item))
                {
                    contadorPalabras[item]++;
                }
                else
                {
                    contadorPalabras.Add(item, 1);
                }
            }
            return contadorPalabras;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = this.ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = this.ArmarPodio(contadorPalabras);

            this.MostrarPodio(podio);
        }

        private List<KeyValuePair<string, int>> ArmarPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);

            return podio;
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras");
            }
            else
            {
                for (int i = 0; i < 3 && i < podio.Count;  i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} - Repeticiones: {par.Value}");
                }
            }
            MessageBox.Show(sb.ToString(), "Podio Palabras", MessageBoxButtons.OK);
        }

    }
}
