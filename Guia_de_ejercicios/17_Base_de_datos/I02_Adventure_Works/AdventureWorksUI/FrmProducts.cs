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

namespace AdventureWorksUI
{
    public partial class FrmProducts : Form
    {
        private List<Product> products;

        public FrmProducts()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            this.RefreshListBox();
        }

        private void RefreshListBox()
        {
            try
            {
                products = ProductsDAO.Read();
                this.dgvProducts.DataSource = null;
                if(products is not null)
                {
                    this.dgvProducts.DataSource = products.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.InnerException.Message + Environment.NewLine + e.StackTrace, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
