
namespace Vista
{
    partial class FrmEntrada
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
            this.txtNombreEspectador = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbObra = new System.Windows.Forms.ComboBox();
            this.btnReservarEntrada = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEspectador
            // 
            this.txtNombreEspectador.Location = new System.Drawing.Point(56, 64);
            this.txtNombreEspectador.Name = "txtNombreEspectador";
            this.txtNombreEspectador.PlaceholderText = "Ingrese nombre";
            this.txtNombreEspectador.Size = new System.Drawing.Size(318, 31);
            this.txtNombreEspectador.TabIndex = 0;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(56, 135);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese DNI";
            this.txtDni.Size = new System.Drawing.Size(318, 31);
            this.txtDni.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(56, 210);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Ingrese Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(318, 31);
            this.txtTelefono.TabIndex = 2;
            // 
            // cmbObra
            // 
            this.cmbObra.FormattingEnabled = true;
            this.cmbObra.Location = new System.Drawing.Point(56, 273);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(318, 33);
            this.cmbObra.TabIndex = 3;
            // 
            // btnReservarEntrada
            // 
            this.btnReservarEntrada.Location = new System.Drawing.Point(56, 494);
            this.btnReservarEntrada.Name = "btnReservarEntrada";
            this.btnReservarEntrada.Size = new System.Drawing.Size(318, 75);
            this.btnReservarEntrada.TabIndex = 4;
            this.btnReservarEntrada.Text = "Reservar";
            this.btnReservarEntrada.UseVisualStyleBackColor = true;
            this.btnReservarEntrada.Click += new System.EventHandler(this.btnReservarEntrada_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(56, 348);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(318, 31);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(56, 609);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 6;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(117, 436);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(180, 31);
            this.nudCantidad.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(157, 399);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 25);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 655);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnReservarEntrada);
            this.Controls.Add(this.cmbObra);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombreEspectador);
            this.Name = "FrmEntrada";
            this.Text = "FrmEntrada";
            this.Load += new System.EventHandler(this.FrmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEspectador;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbObra;
        private System.Windows.Forms.Button btnReservarEntrada;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}