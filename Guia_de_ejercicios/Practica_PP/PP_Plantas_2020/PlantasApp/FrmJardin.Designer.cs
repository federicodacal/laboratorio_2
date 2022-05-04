
namespace PlantasApp
{
    partial class FrmJardin
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
            this.btnDatos = new System.Windows.Forms.Button();
            this.rtbSalidaDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(527, 28);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(188, 64);
            this.btnDatos.TabIndex = 0;
            this.btnDatos.Text = "Ver Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // rtbSalidaDatos
            // 
            this.rtbSalidaDatos.Location = new System.Drawing.Point(34, 118);
            this.rtbSalidaDatos.Name = "rtbSalidaDatos";
            this.rtbSalidaDatos.Size = new System.Drawing.Size(681, 342);
            this.rtbSalidaDatos.TabIndex = 1;
            this.rtbSalidaDatos.Text = "";
            // 
            // FrmJardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(747, 489);
            this.Controls.Add(this.rtbSalidaDatos);
            this.Controls.Add(this.btnDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJardin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.Jardin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.RichTextBox rtbSalidaDatos;
    }
}

