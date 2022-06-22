
namespace SP.LABII.WinFormsApp
{
    partial class FrmParteUno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPunto1 = new System.Windows.Forms.Button();
            this.btnPunto2 = new System.Windows.Forms.Button();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.btnPunto5 = new System.Windows.Forms.Button();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.btnVerLog = new System.Windows.Forms.Button();
            this.btnHilos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnPunto1
            // 
            this.btnPunto1.Location = new System.Drawing.Point(17, 20);
            this.btnPunto1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPunto1.Name = "btnPunto1";
            this.btnPunto1.Size = new System.Drawing.Size(107, 38);
            this.btnPunto1.TabIndex = 0;
            this.btnPunto1.Text = "Punto 1";
            this.btnPunto1.UseVisualStyleBackColor = true;
            // 
            // btnPunto2
            // 
            this.btnPunto2.Location = new System.Drawing.Point(133, 20);
            this.btnPunto2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPunto2.Name = "btnPunto2";
            this.btnPunto2.Size = new System.Drawing.Size(107, 38);
            this.btnPunto2.TabIndex = 1;
            this.btnPunto2.Text = "Punto 2";
            this.btnPunto2.UseVisualStyleBackColor = true;
            // 
            // btnPunto3
            // 
            this.btnPunto3.Location = new System.Drawing.Point(249, 20);
            this.btnPunto3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(107, 38);
            this.btnPunto3.TabIndex = 2;
            this.btnPunto3.Text = "Punto 3";
            this.btnPunto3.UseVisualStyleBackColor = true;
            // 
            // btnPunto4
            // 
            this.btnPunto4.Location = new System.Drawing.Point(364, 20);
            this.btnPunto4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(107, 38);
            this.btnPunto4.TabIndex = 3;
            this.btnPunto4.Text = "Punto 4";
            this.btnPunto4.UseVisualStyleBackColor = true;
            // 
            // btnPunto5
            // 
            this.btnPunto5.Location = new System.Drawing.Point(480, 20);
            this.btnPunto5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPunto5.Name = "btnPunto5";
            this.btnPunto5.Size = new System.Drawing.Size(107, 38);
            this.btnPunto5.TabIndex = 4;
            this.btnPunto5.Text = "Punto 5";
            this.btnPunto5.UseVisualStyleBackColor = true;
            // 
            // lstVisor
            // 
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.ItemHeight = 25;
            this.lstVisor.Location = new System.Drawing.Point(17, 97);
            this.lstVisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(568, 379);
            this.lstVisor.TabIndex = 5;
            // 
            // btnVerLog
            // 
            this.btnVerLog.Location = new System.Drawing.Point(17, 488);
            this.btnVerLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerLog.Name = "btnVerLog";
            this.btnVerLog.Size = new System.Drawing.Size(191, 62);
            this.btnVerLog.TabIndex = 6;
            this.btnVerLog.Text = "Ver log de Facturas";
            this.btnVerLog.UseVisualStyleBackColor = true;
            this.btnVerLog.Click += new System.EventHandler(this.btnVerLog_Click);
            // 
            // btnHilos
            // 
            this.btnHilos.Location = new System.Drawing.Point(396, 488);
            this.btnHilos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHilos.Name = "btnHilos";
            this.btnHilos.Size = new System.Drawing.Size(191, 62);
            this.btnHilos.TabIndex = 7;
            this.btnHilos.Text = "Hilos";
            this.btnHilos.UseVisualStyleBackColor = true;
            this.btnHilos.Click += new System.EventHandler(this.btnHilos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmParteUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 570);
            this.Controls.Add(this.btnHilos);
            this.Controls.Add(this.btnVerLog);
            this.Controls.Add(this.lstVisor);
            this.Controls.Add(this.btnPunto5);
            this.Controls.Add(this.btnPunto4);
            this.Controls.Add(this.btnPunto3);
            this.Controls.Add(this.btnPunto2);
            this.Controls.Add(this.btnPunto1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmParteUno";
            this.Text = "FrmParteUno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPunto1;
        private System.Windows.Forms.Button btnPunto2;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Button btnPunto5;
        private System.Windows.Forms.ListBox lstVisor;
        private System.Windows.Forms.Button btnVerLog;
        private System.Windows.Forms.Button btnHilos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}