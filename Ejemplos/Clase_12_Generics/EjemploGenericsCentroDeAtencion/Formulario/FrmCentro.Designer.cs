
namespace Formulario
{
    partial class FrmCentro
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
            this.btnAltaPaciente = new System.Windows.Forms.Button();
            this.btnAltaAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaPaciente
            // 
            this.btnAltaPaciente.Location = new System.Drawing.Point(43, 44);
            this.btnAltaPaciente.Name = "btnAltaPaciente";
            this.btnAltaPaciente.Size = new System.Drawing.Size(276, 56);
            this.btnAltaPaciente.TabIndex = 0;
            this.btnAltaPaciente.Text = "Alta Persona";
            this.btnAltaPaciente.UseVisualStyleBackColor = true;
            this.btnAltaPaciente.Click += new System.EventHandler(this.btnAltaPaciente_Click);
            // 
            // btnAltaAnimal
            // 
            this.btnAltaAnimal.Location = new System.Drawing.Point(43, 154);
            this.btnAltaAnimal.Name = "btnAltaAnimal";
            this.btnAltaAnimal.Size = new System.Drawing.Size(276, 56);
            this.btnAltaAnimal.TabIndex = 1;
            this.btnAltaAnimal.Text = "Alta Animal";
            this.btnAltaAnimal.UseVisualStyleBackColor = true;
            this.btnAltaAnimal.Click += new System.EventHandler(this.btnAltaAnimal_Click);
            // 
            // FrmCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 276);
            this.Controls.Add(this.btnAltaAnimal);
            this.Controls.Add(this.btnAltaPaciente);
            this.Name = "FrmCentro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Atencion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaPaciente;
        private System.Windows.Forms.Button btnAltaAnimal;
    }
}

