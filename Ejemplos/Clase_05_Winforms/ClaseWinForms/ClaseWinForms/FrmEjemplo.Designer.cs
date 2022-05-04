
namespace ClaseWinForms
{
    partial class FrmEjemplo
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
            this.btnNuevoForm = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnTxtBox = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoForm
            // 
            this.btnNuevoForm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoForm.Location = new System.Drawing.Point(91, 96);
            this.btnNuevoForm.Name = "btnNuevoForm";
            this.btnNuevoForm.Size = new System.Drawing.Size(282, 87);
            this.btnNuevoForm.TabIndex = 0;
            this.btnNuevoForm.Text = "Cargar Formulario";
            this.btnNuevoForm.UseVisualStyleBackColor = true;
            this.btnNuevoForm.Click += new System.EventHandler(this.btnNuevoForm_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btnCerrar.Location = new System.Drawing.Point(91, 199);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(282, 95);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnTxtBox
            // 
            this.btnTxtBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTxtBox.Location = new System.Drawing.Point(91, 311);
            this.btnTxtBox.Name = "btnTxtBox";
            this.btnTxtBox.Size = new System.Drawing.Size(282, 75);
            this.btnTxtBox.TabIndex = 2;
            this.btnTxtBox.Text = "Nuevo Text Box";
            this.btnTxtBox.UseVisualStyleBackColor = true;
            this.btnTxtBox.Click += new System.EventHandler(this.btnTxtBox_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(139, 406);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 49);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmEjemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTxtBox);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEjemplo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEjemplo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoForm;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnTxtBox;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

