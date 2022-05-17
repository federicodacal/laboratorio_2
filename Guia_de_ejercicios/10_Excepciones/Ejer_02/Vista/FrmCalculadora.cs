using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            int kms;
            int litros;

            try
            {
                if (String.IsNullOrWhiteSpace(this.txtKms.Text) || String.IsNullOrWhiteSpace(this.txtLitros.Text))
                {
                    throw new ParametrosVaciosException("No se ingresaron todos los parametros");
                }
                else
                {
                    kms = int.Parse(this.txtKms.Text);
                    litros = int.Parse(this.txtLitros.Text);

                    resultado = Calculador.Calcular(kms, litros);
                    this.rtbResultado.Text = resultado.ToString() + "km / lts" ;
                }
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un problema:\n {ex.Message}");
            }

        }
    }
}
