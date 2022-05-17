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

namespace Formulario
{
    public partial class FrmPacientes<T> : Form // Como es una partial class tambien tengo que modificar el constructor de Designer.cs
        where T : class
    {
        public FrmPacientes()
        {
            InitializeComponent();

            int posicionY = 20;

            foreach (var propiedad in typeof(T).GetProperties())
            {
                Label lbl = new Label();
                TextBox txt = new TextBox();

                lbl.Name = propiedad.Name;
                txt.Name = propiedad.Name;

                lbl.Text = propiedad.Name + ":";

                lbl.Location = new Point(20, posicionY);
                txt.Location = new Point(120, posicionY);

                posicionY += 40;

                this.Controls.Add(lbl);
                this.Controls.Add(txt);
            }
        }
    }
}
