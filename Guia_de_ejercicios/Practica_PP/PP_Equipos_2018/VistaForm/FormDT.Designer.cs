
namespace VistaForm
{
    partial class FormDT
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.nudDni = new System.Windows.Forms.NumericUpDown();
            this.nudExp = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 31);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 154);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(256, 31);
            this.txtApellido.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(169, 228);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 25);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(178, 307);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(43, 25);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(152, 396);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(99, 25);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Experiencia";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(113, 256);
            this.nudEdad.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(180, 31);
            this.nudEdad.TabIndex = 5;
            this.nudEdad.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // nudDni
            // 
            this.nudDni.Location = new System.Drawing.Point(113, 335);
            this.nudDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDni.Minimum = new decimal(new int[] {
            11111,
            0,
            0,
            0});
            this.nudDni.Name = "nudDni";
            this.nudDni.Size = new System.Drawing.Size(180, 31);
            this.nudDni.TabIndex = 6;
            this.nudDni.Value = new decimal(new int[] {
            11111,
            0,
            0,
            0});
            // 
            // nudExp
            // 
            this.nudExp.Location = new System.Drawing.Point(113, 424);
            this.nudExp.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(180, 31);
            this.nudExp.TabIndex = 7;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(84, 520);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(112, 62);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(228, 520);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(112, 62);
            this.btnValidar.TabIndex = 9;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 642);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.nudExp);
            this.Controls.Add(this.nudDni);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.NumericUpDown nudDni;
        private System.Windows.Forms.NumericUpDown nudExp;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
    }
}

