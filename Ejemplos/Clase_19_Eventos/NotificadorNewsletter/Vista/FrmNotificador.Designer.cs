
namespace Vista
{
    partial class FrmNotificador
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
            this.btnTecnologia = new System.Windows.Forms.Button();
            this.btnFinanzas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTecnologia
            // 
            this.btnTecnologia.Location = new System.Drawing.Point(12, 33);
            this.btnTecnologia.Name = "btnTecnologia";
            this.btnTecnologia.Size = new System.Drawing.Size(285, 98);
            this.btnTecnologia.TabIndex = 0;
            this.btnTecnologia.Text = "Enviar Newsletter Tecnología";
            this.btnTecnologia.UseVisualStyleBackColor = true;
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Location = new System.Drawing.Point(305, 33);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(285, 98);
            this.btnFinanzas.TabIndex = 1;
            this.btnFinanzas.Text = "Enviar Newsletter Finanzas";
            this.btnFinanzas.UseVisualStyleBackColor = true;
            // 
            // FrmNotificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 150);
            this.Controls.Add(this.btnFinanzas);
            this.Controls.Add(this.btnTecnologia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotificador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificador";
            this.Load += new System.EventHandler(this.FrmNotificador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTecnologia;
        private System.Windows.Forms.Button btnFinanzas;
    }
}

