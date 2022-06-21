using System;
using System.Windows.Forms;
using Application.Repositories;
using Application.Helpers;
using System.Collections.Generic;
using Application.Models;
using Application.Files.Xml;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        CustomerRepository customerRepository;
        List<Customer> customersXml;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.customerRepository = new CustomerRepository();
            this.customersXml = new List<Customer>();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)//SE VA
        {

        }

        private void visualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerVisualizer frm = new FrmCustomerVisualizer(this.customerRepository);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Abrir archivo";
                this.openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                this.openFileDialog1.Filter = "XML files|*.xml";
                this.openFileDialog1.DefaultExt = "xml";
                this.openFileDialog1.CheckPathExists = true;

                DialogResult rta = this.openFileDialog1.ShowDialog();

                if(rta == DialogResult.OK)
                {
                    Xml<List<Customer>> xml = new Xml<List<Customer>>();
                    if(xml.Read(this.openFileDialog1.FileName, out this.customersXml))
                    {
                        MessageBox.Show("Clientes deserializados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (Customer item in this.customersXml)
                        {
                            this.customerRepository.Create(item);
                        }

                        FrmCustomerVisualizer frm = new FrmCustomerVisualizer(this.customerRepository);

                        frm.StartPosition = FormStartPosition.CenterScreen;

                        frm.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede abrir: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }
            private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                try
                {

                    if (this.customerRepository.SaveToFile(customerRepository.GetAll()))
                    {
                        MessageBox.Show("Clientes serializados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No se puede Guardar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se puede Guardar: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.LogException(ex.Message);
                }
            }
        
    }
}
