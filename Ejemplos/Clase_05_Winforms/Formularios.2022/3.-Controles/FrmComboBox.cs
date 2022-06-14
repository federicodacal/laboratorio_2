using System;
using System.Windows.Forms;

namespace Controles
{
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.cboDropDown.Items.AddRange(new String[] {"AZUL", "VERDE", "AMARILLO",
                                                        "ROJO", "BLANCO", "MARRÓN", "GRANATE"});
            this.cboDropDownList.Items.AddRange(new String[] {"ELENA", "JOSE", "ANA",
                                                            "ALFREDO", "LUIS", "ANGEL",
                                                            "RAQUEL"});
            this.cboSimple.Items.AddRange(new String[] {"AVELLANEDA", "QUILMES", "BERNAL",
                                                      "LANUS", "BERAZATEGUI"});
        }

    }
}
