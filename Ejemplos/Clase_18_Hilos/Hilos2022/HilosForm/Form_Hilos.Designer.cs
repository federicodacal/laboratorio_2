
namespace HilosForm
{
    partial class Form_Hilos
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnSincronico = new System.Windows.Forms.Button();
            this.btnListarAsincronico = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(347, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(221, 214);
            this.listBox.TabIndex = 1;
            // 
            // btnSincronico
            // 
            this.btnSincronico.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSincronico.Location = new System.Drawing.Point(160, 12);
            this.btnSincronico.Name = "btnSincronico";
            this.btnSincronico.Size = new System.Drawing.Size(121, 65);
            this.btnSincronico.TabIndex = 2;
            this.btnSincronico.Text = "Listar Sincrónico";
            this.btnSincronico.UseVisualStyleBackColor = true;
            this.btnSincronico.Click += new System.EventHandler(this.btnSincronico_Click);
            // 
            // btnListarAsincronico
            // 
            this.btnListarAsincronico.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarAsincronico.Location = new System.Drawing.Point(160, 105);
            this.btnListarAsincronico.Name = "btnListarAsincronico";
            this.btnListarAsincronico.Size = new System.Drawing.Size(121, 65);
            this.btnListarAsincronico.TabIndex = 3;
            this.btnListarAsincronico.Text = "Listar Asincrónico";
            this.btnListarAsincronico.UseVisualStyleBackColor = true;
            this.btnListarAsincronico.Click += new System.EventHandler(this.btnListarAsincronico_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(449, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(160, 277);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 51);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form_Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListarAsincronico);
            this.Controls.Add(this.btnSincronico);
            this.Controls.Add(this.listBox);
            this.Name = "Form_Hilos";
            this.Text = "Form_Hilos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnSincronico;
        private System.Windows.Forms.Button btnListarAsincronico;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIniciar;
    }
}