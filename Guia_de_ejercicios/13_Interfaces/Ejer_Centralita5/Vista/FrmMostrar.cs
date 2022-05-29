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

namespace Vista
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private string tipoGanancia;
        private FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(Centralita centralita, string tipoGanancia):this()
        {
            this.centralita = centralita;
            this.tipoGanancia = tipoGanancia;
            this.MostrarInformacion();
        }

        private void MostrarInformacion()
        {
            if(this.centralita is not null)
            {
                if(this.tipoGanancia == "Total")
                {
                    this.rtbDetalleCentralita.Text = $"Ganancia Total: ${this.centralita.GananciasTotal}\n\n"; 
                }
                else if(this.tipoGanancia == "Provincial")
                {
                    this.rtbDetalleCentralita.Text = $"Ganancia Provincial: ${this.centralita.GananciasPorProvincial}\n\n";
                }
                else if (this.tipoGanancia == "Local")
                {
                    this.rtbDetalleCentralita.Text = $"Ganancia Local: ${this.centralita.GananciasPorLocal}\n\n";
                }
                this.rtbDetalleCentralita.Text += this.centralita.ToString();
            }
        }
    }
}
