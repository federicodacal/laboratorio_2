
namespace Vista
{
    partial class FrmTeatro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbEspectadores = new System.Windows.Forms.RichTextBox();
            this.btnComprarEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEspectadores
            // 
            this.rtbEspectadores.Location = new System.Drawing.Point(12, 12);
            this.rtbEspectadores.Name = "rtbEspectadores";
            this.rtbEspectadores.ReadOnly = true;
            this.rtbEspectadores.Size = new System.Drawing.Size(596, 402);
            this.rtbEspectadores.TabIndex = 1;
            this.rtbEspectadores.Text = "";
            // 
            // btnComprarEntrada
            // 
            this.btnComprarEntrada.Location = new System.Drawing.Point(12, 438);
            this.btnComprarEntrada.Name = "btnComprarEntrada";
            this.btnComprarEntrada.Size = new System.Drawing.Size(596, 81);
            this.btnComprarEntrada.TabIndex = 3;
            this.btnComprarEntrada.Text = "Comprar Entrada";
            this.btnComprarEntrada.UseVisualStyleBackColor = true;
            this.btnComprarEntrada.Click += new System.EventHandler(this.btnComprarEntrada_Click);
            // 
            // FrmTeatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 531);
            this.Controls.Add(this.btnComprarEntrada);
            this.Controls.Add(this.rtbEspectadores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTeatro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teatro";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbEspectadores;
        private System.Windows.Forms.Button btnComprarEntrada;
    }
}

