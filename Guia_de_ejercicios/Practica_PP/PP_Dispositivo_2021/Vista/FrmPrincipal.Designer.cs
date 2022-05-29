
namespace Vista
{
    partial class FrmPrincipal
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
            this.rtbAppsInstaladas = new System.Windows.Forms.RichTextBox();
            this.rtbAppsNoInstaladas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAppsInstaladas
            // 
            this.rtbAppsInstaladas.BackColor = System.Drawing.Color.Black;
            this.rtbAppsInstaladas.ForeColor = System.Drawing.Color.White;
            this.rtbAppsInstaladas.Location = new System.Drawing.Point(12, 50);
            this.rtbAppsInstaladas.Name = "rtbAppsInstaladas";
            this.rtbAppsInstaladas.Size = new System.Drawing.Size(381, 601);
            this.rtbAppsInstaladas.TabIndex = 0;
            this.rtbAppsInstaladas.Text = "";
            // 
            // rtbAppsNoInstaladas
            // 
            this.rtbAppsNoInstaladas.BackColor = System.Drawing.Color.Black;
            this.rtbAppsNoInstaladas.ForeColor = System.Drawing.Color.White;
            this.rtbAppsNoInstaladas.Location = new System.Drawing.Point(459, 50);
            this.rtbAppsNoInstaladas.Name = "rtbAppsNoInstaladas";
            this.rtbAppsNoInstaladas.Size = new System.Drawing.Size(381, 601);
            this.rtbAppsNoInstaladas.TabIndex = 1;
            this.rtbAppsNoInstaladas.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(852, 692);
            this.Controls.Add(this.rtbAppsNoInstaladas);
            this.Controls.Add(this.rtbAppsInstaladas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispositivo";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAppsInstaladas;
        private System.Windows.Forms.RichTextBox rtbAppsNoInstaladas;
    }
}

