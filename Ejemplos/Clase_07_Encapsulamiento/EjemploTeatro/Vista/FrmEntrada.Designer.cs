
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstFechas = new System.Windows.Forms.ListBox();
            this.lblFuncionesDisponibles = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEntradasDisponibles = new System.Windows.Forms.Label();
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
            this.txtNombreEspectador.TabStop = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(56, 135);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese DNI";
            this.txtDni.Size = new System.Drawing.Size(318, 31);
            this.txtDni.TabIndex = 1;
            this.txtDni.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(56, 210);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Ingrese Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(318, 31);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TabStop = false;
            // 
            // cmbObra
            // 
            this.cmbObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObra.FormattingEnabled = true;
            this.cmbObra.Location = new System.Drawing.Point(56, 273);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(318, 33);
            this.cmbObra.TabIndex = 3;
            this.cmbObra.TabStop = false;
            this.cmbObra.SelectedIndexChanged += new System.EventHandler(this.cmbObra_SelectedIndexChanged);
            // 
            // btnReservarEntrada
            // 
            this.btnReservarEntrada.Location = new System.Drawing.Point(56, 495);
            this.btnReservarEntrada.Name = "btnReservarEntrada";
            this.btnReservarEntrada.Size = new System.Drawing.Size(742, 75);
            this.btnReservarEntrada.TabIndex = 4;
            this.btnReservarEntrada.Text = "Reservar";
            this.btnReservarEntrada.UseVisualStyleBackColor = true;
            this.btnReservarEntrada.Click += new System.EventHandler(this.btnReservarEntrada_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(56, 681);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 6;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(122, 382);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(180, 31);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(162, 345);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 25);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lstFechas
            // 
            this.lstFechas.FormattingEnabled = true;
            this.lstFechas.ItemHeight = 25;
            this.lstFechas.Location = new System.Drawing.Point(437, 64);
            this.lstFechas.Name = "lstFechas";
            this.lstFechas.Size = new System.Drawing.Size(361, 354);
            this.lstFechas.TabIndex = 9;
            this.lstFechas.SelectedIndexChanged += new System.EventHandler(this.lstFechas_SelectedIndexChanged);
            // 
            // lblFuncionesDisponibles
            // 
            this.lblFuncionesDisponibles.AutoSize = true;
            this.lblFuncionesDisponibles.Location = new System.Drawing.Point(427, 24);
            this.lblFuncionesDisponibles.Name = "lblFuncionesDisponibles";
            this.lblFuncionesDisponibles.Size = new System.Drawing.Size(189, 25);
            this.lblFuncionesDisponibles.TabIndex = 10;
            this.lblFuncionesDisponibles.Text = "Funciones Disponibles";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(56, 588);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(742, 75);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEntradasDisponibles
            // 
            this.lblEntradasDisponibles.AutoSize = true;
            this.lblEntradasDisponibles.Location = new System.Drawing.Point(437, 434);
            this.lblEntradasDisponibles.Name = "lblEntradasDisponibles";
            this.lblEntradasDisponibles.Size = new System.Drawing.Size(0, 25);
            this.lblEntradasDisponibles.TabIndex = 12;
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 730);
            this.Controls.Add(this.lblEntradasDisponibles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFuncionesDisponibles);
            this.Controls.Add(this.lstFechas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnReservarEntrada);
            this.Controls.Add(this.cmbObra);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombreEspectador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntrada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEntrada_FormClosing);
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
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListBox lstFechas;
        private System.Windows.Forms.Label lblFuncionesDisponibles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEntradasDisponibles;
    }
}