
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
            this.lblComprarEntrada = new System.Windows.Forms.Label();
            this.rtbEspectadores = new System.Windows.Forms.RichTextBox();
            this.lblEntradasRestantes = new System.Windows.Forms.Label();
            this.btnComprarEntrada = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComprarEntrada
            // 
            this.lblComprarEntrada.AutoSize = true;
            this.lblComprarEntrada.Location = new System.Drawing.Point(39, 36);
            this.lblComprarEntrada.Name = "lblComprarEntrada";
            this.lblComprarEntrada.Size = new System.Drawing.Size(147, 25);
            this.lblComprarEntrada.TabIndex = 0;
            this.lblComprarEntrada.Text = "Comprar Entrada";
            // 
            // rtbEspectadores
            // 
            this.rtbEspectadores.Location = new System.Drawing.Point(39, 90);
            this.rtbEspectadores.Name = "rtbEspectadores";
            this.rtbEspectadores.Size = new System.Drawing.Size(312, 296);
            this.rtbEspectadores.TabIndex = 1;
            this.rtbEspectadores.Text = "";
            // 
            // lblEntradasRestantes
            // 
            this.lblEntradasRestantes.AutoSize = true;
            this.lblEntradasRestantes.Location = new System.Drawing.Point(39, 430);
            this.lblEntradasRestantes.Name = "lblEntradasRestantes";
            this.lblEntradasRestantes.Size = new System.Drawing.Size(169, 25);
            this.lblEntradasRestantes.TabIndex = 2;
            this.lblEntradasRestantes.Text = "Entradas Restantes: ";
            // 
            // btnComprarEntrada
            // 
            this.btnComprarEntrada.Location = new System.Drawing.Point(39, 507);
            this.btnComprarEntrada.Name = "btnComprarEntrada";
            this.btnComprarEntrada.Size = new System.Drawing.Size(312, 81);
            this.btnComprarEntrada.TabIndex = 3;
            this.btnComprarEntrada.Text = "Comprar Entrada";
            this.btnComprarEntrada.UseVisualStyleBackColor = true;
            this.btnComprarEntrada.Click += new System.EventHandler(this.btnComprarEntrada_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(39, 611);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 4;
            // 
            // FrmTeatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 662);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnComprarEntrada);
            this.Controls.Add(this.lblEntradasRestantes);
            this.Controls.Add(this.rtbEspectadores);
            this.Controls.Add(this.lblComprarEntrada);
            this.Name = "FrmTeatro";
            this.Text = "Teatro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComprarEntrada;
        private System.Windows.Forms.RichTextBox rtbEspectadores;
        private System.Windows.Forms.Label lblEntradasRestantes;
        private System.Windows.Forms.Button btnComprarEntrada;
        private System.Windows.Forms.Label lblMensaje;
    }
}

