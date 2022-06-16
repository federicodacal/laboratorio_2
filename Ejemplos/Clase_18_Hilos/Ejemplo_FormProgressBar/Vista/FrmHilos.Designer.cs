
namespace Vista
{
    partial class FrmHilos
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
            this.pgb1 = new System.Windows.Forms.ProgressBar();
            this.pgb2 = new System.Windows.Forms.ProgressBar();
            this.pgb3 = new System.Windows.Forms.ProgressBar();
            this.pgb4 = new System.Windows.Forms.ProgressBar();
            this.pgb5 = new System.Windows.Forms.ProgressBar();
            this.lblPgb1 = new System.Windows.Forms.Label();
            this.lblPgb2 = new System.Windows.Forms.Label();
            this.lblPgb3 = new System.Windows.Forms.Label();
            this.lblPgb4 = new System.Windows.Forms.Label();
            this.lblPgb5 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgb1
            // 
            this.pgb1.Location = new System.Drawing.Point(12, 25);
            this.pgb1.Name = "pgb1";
            this.pgb1.Size = new System.Drawing.Size(1186, 63);
            this.pgb1.TabIndex = 0;
            // 
            // pgb2
            // 
            this.pgb2.Location = new System.Drawing.Point(12, 141);
            this.pgb2.Name = "pgb2";
            this.pgb2.Size = new System.Drawing.Size(1186, 63);
            this.pgb2.TabIndex = 1;
            // 
            // pgb3
            // 
            this.pgb3.Location = new System.Drawing.Point(12, 261);
            this.pgb3.Name = "pgb3";
            this.pgb3.Size = new System.Drawing.Size(1186, 63);
            this.pgb3.TabIndex = 2;
            // 
            // pgb4
            // 
            this.pgb4.Location = new System.Drawing.Point(12, 386);
            this.pgb4.Name = "pgb4";
            this.pgb4.Size = new System.Drawing.Size(1186, 63);
            this.pgb4.TabIndex = 3;
            // 
            // pgb5
            // 
            this.pgb5.Location = new System.Drawing.Point(12, 502);
            this.pgb5.Name = "pgb5";
            this.pgb5.Size = new System.Drawing.Size(1186, 63);
            this.pgb5.TabIndex = 4;
            // 
            // lblPgb1
            // 
            this.lblPgb1.AutoSize = true;
            this.lblPgb1.Location = new System.Drawing.Point(12, 100);
            this.lblPgb1.Name = "lblPgb1";
            this.lblPgb1.Size = new System.Drawing.Size(144, 25);
            this.lblPgb1.TabIndex = 5;
            this.lblPgb1.Text = "No iniciado - 0%";
            // 
            // lblPgb2
            // 
            this.lblPgb2.AutoSize = true;
            this.lblPgb2.Location = new System.Drawing.Point(12, 216);
            this.lblPgb2.Name = "lblPgb2";
            this.lblPgb2.Size = new System.Drawing.Size(144, 25);
            this.lblPgb2.TabIndex = 6;
            this.lblPgb2.Text = "No iniciado - 0%";
            // 
            // lblPgb3
            // 
            this.lblPgb3.AutoSize = true;
            this.lblPgb3.Location = new System.Drawing.Point(12, 337);
            this.lblPgb3.Name = "lblPgb3";
            this.lblPgb3.Size = new System.Drawing.Size(144, 25);
            this.lblPgb3.TabIndex = 7;
            this.lblPgb3.Text = "No iniciado - 0%";
            // 
            // lblPgb4
            // 
            this.lblPgb4.AutoSize = true;
            this.lblPgb4.Location = new System.Drawing.Point(12, 462);
            this.lblPgb4.Name = "lblPgb4";
            this.lblPgb4.Size = new System.Drawing.Size(144, 25);
            this.lblPgb4.TabIndex = 8;
            this.lblPgb4.Text = "No iniciado - 0%";
            // 
            // lblPgb5
            // 
            this.lblPgb5.AutoSize = true;
            this.lblPgb5.Location = new System.Drawing.Point(12, 577);
            this.lblPgb5.Name = "lblPgb5";
            this.lblPgb5.Size = new System.Drawing.Size(144, 25);
            this.lblPgb5.TabIndex = 9;
            this.lblPgb5.Text = "No iniciado - 0%";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(12, 649);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(358, 31);
            this.txtMensaje.TabIndex = 10;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(389, 643);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(168, 43);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(682, 643);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(168, 43);
            this.btnReiniciar.TabIndex = 12;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(856, 643);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(168, 43);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "Ver Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1030, 643);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 43);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmHilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 704);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblPgb5);
            this.Controls.Add(this.lblPgb4);
            this.Controls.Add(this.lblPgb3);
            this.Controls.Add(this.lblPgb2);
            this.Controls.Add(this.lblPgb1);
            this.Controls.Add(this.pgb5);
            this.Controls.Add(this.pgb4);
            this.Controls.Add(this.pgb3);
            this.Controls.Add(this.pgb2);
            this.Controls.Add(this.pgb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHilos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHilos_FormClosing);
            this.Load += new System.EventHandler(this.FrmHilos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb1;
        private System.Windows.Forms.ProgressBar pgb2;
        private System.Windows.Forms.ProgressBar pgb3;
        private System.Windows.Forms.ProgressBar pgb4;
        private System.Windows.Forms.ProgressBar pgb5;
        private System.Windows.Forms.Label lblPgb1;
        private System.Windows.Forms.Label lblPgb2;
        private System.Windows.Forms.Label lblPgb3;
        private System.Windows.Forms.Label lblPgb4;
        private System.Windows.Forms.Label lblPgb5;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCancelar;
    }
}

