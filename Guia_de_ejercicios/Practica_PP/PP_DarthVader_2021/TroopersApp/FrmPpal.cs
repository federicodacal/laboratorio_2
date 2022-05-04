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

namespace TroopersApp
{
    public partial class FrmPpal : Form
    {
        private EjercitoImperial ejercito;
        public FrmPpal()
        {
            InitializeComponent();
            this.ejercito = new EjercitoImperial(5);
            this.ejercito += new TrooperAsalto(Blaster.EC17);
            this.RefrescarEjercito();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
        }

        private void RefrescarEjercito()
        {
            this.lstEjercito.Items.Clear();
            foreach (Trooper item in this.ejercito.Troopers)
            {
                this.lstEjercito.Items.Add(item.InfoTrooper());
            }
            this.lstEjercito.Update();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if((ETipo)cmbTipo.SelectedItem == ETipo.Arena)
            {
                this.ejercito += new TrooperArena(Blaster.EC17); 
            }
            else if((ETipo)cmbTipo.SelectedItem == ETipo.Explorador)
            {
                this.ejercito += new TrooperExplorador("Motonave");
            }
            else if((ETipo)cmbTipo.SelectedItem == ETipo.Asalto)
            {
                this.ejercito += new TrooperAsalto(Blaster.E11);
            }
            this.RefrescarEjercito();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
