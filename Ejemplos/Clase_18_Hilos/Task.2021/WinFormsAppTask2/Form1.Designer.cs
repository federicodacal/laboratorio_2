
namespace WinFormsAppTask2
{
    partial class Form1
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
            this.imgImagen = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imgImagen
            // 
            this.imgImagen.Location = new System.Drawing.Point(12, 12);
            this.imgImagen.Name = "imgImagen";
            this.imgImagen.Size = new System.Drawing.Size(412, 308);
            this.imgImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImagen.TabIndex = 0;
            this.imgImagen.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 342);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(412, 37);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "09/12/18";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(163, 404);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(111, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar partido";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 439);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.imgImagen);
            this.Name = "Form1";
            this.Text = "La gloria eterna";
            ((System.ComponentModel.ISupportInitialize)(this.imgImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgImagen;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnIniciar;
    }
}

