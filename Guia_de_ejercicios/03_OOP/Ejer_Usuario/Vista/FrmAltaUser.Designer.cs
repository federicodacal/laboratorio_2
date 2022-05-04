
namespace Vista
{
    partial class FrmAltaUser
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(113, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Ingrese nombre de usuario";
            this.txtUsername.Size = new System.Drawing.Size(412, 31);
            this.txtUsername.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 174);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Ingrese telefono";
            this.txtTelefono.Size = new System.Drawing.Size(412, 31);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Ingrese password";
            this.txtPassword.Size = new System.Drawing.Size(412, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(113, 234);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Ingrese direccion";
            this.txtDireccion.Size = new System.Drawing.Size(412, 31);
            this.txtDireccion.TabIndex = 3;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(113, 309);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(171, 67);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(354, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 67);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmAltaUser";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.FrmAltaUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
    }
}