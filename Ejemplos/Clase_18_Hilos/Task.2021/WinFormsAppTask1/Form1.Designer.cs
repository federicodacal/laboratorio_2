
namespace WinFormsAppTask1
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
            this.btnSinParams = new System.Windows.Forms.Button();
            this.btnConParams = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinParams
            // 
            this.btnSinParams.Location = new System.Drawing.Point(12, 84);
            this.btnSinParams.Name = "btnSinParams";
            this.btnSinParams.Size = new System.Drawing.Size(127, 23);
            this.btnSinParams.TabIndex = 0;
            this.btnSinParams.Text = "Hilo sin parámetros";
            this.btnSinParams.UseVisualStyleBackColor = true;
            // 
            // btnConParams
            // 
            this.btnConParams.Location = new System.Drawing.Point(145, 84);
            this.btnConParams.Name = "btnConParams";
            this.btnConParams.Size = new System.Drawing.Size(132, 23);
            this.btnConParams.TabIndex = 1;
            this.btnConParams.Text = "Hilo con parámetros";
            this.btnConParams.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 31);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(51, 15);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 131);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnConParams);
            this.Controls.Add(this.btnSinParams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinParams;
        private System.Windows.Forms.Button btnConParams;
        private System.Windows.Forms.Label lblMensaje;
    }
}

