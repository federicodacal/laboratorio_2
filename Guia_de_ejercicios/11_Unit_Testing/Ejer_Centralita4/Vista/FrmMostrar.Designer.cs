
namespace Vista
{
    partial class FrmMostrar
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
            this.rtbDetalleCentralita = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDetalleCentralita
            // 
            this.rtbDetalleCentralita.Location = new System.Drawing.Point(10, 24);
            this.rtbDetalleCentralita.Name = "rtbDetalleCentralita";
            this.rtbDetalleCentralita.ReadOnly = true;
            this.rtbDetalleCentralita.Size = new System.Drawing.Size(474, 489);
            this.rtbDetalleCentralita.TabIndex = 0;
            this.rtbDetalleCentralita.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 529);
            this.Controls.Add(this.rtbDetalleCentralita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Centralita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDetalleCentralita;
    }
}