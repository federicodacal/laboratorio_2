
namespace VistaForm
{
    partial class FrmCurso
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
            this.gbDatosCurso = new System.Windows.Forms.GroupBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.txtDocProfesor = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.dtpIngrso = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.nudAnioAlumno = new System.Windows.Forms.NumericUpDown();
            this.txtLegajoAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApellidoAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblDivAlumno = new System.Windows.Forms.Label();
            this.lblAnioAlumno = new System.Windows.Forms.Label();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.gbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCurso
            // 
            this.gbDatosCurso.Controls.Add(this.dtpIngreso);
            this.gbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gbDatosCurso.Controls.Add(this.txtDocProfesor);
            this.gbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gbDatosCurso.Controls.Add(this.btnMostrar);
            this.gbDatosCurso.Controls.Add(this.btnCrearCurso);
            this.gbDatosCurso.Controls.Add(this.dtpIngrso);
            this.gbDatosCurso.Controls.Add(this.lblDni);
            this.gbDatosCurso.Controls.Add(this.lblApellido);
            this.gbDatosCurso.Controls.Add(this.lblNombre);
            this.gbDatosCurso.Controls.Add(this.lblDivision);
            this.gbDatosCurso.Controls.Add(this.lblAnio);
            this.gbDatosCurso.Location = new System.Drawing.Point(29, 12);
            this.gbDatosCurso.Name = "gbDatosCurso";
            this.gbDatosCurso.Size = new System.Drawing.Size(560, 439);
            this.gbDatosCurso.TabIndex = 0;
            this.gbDatosCurso.TabStop = false;
            this.gbDatosCurso.Text = "Datos Curso";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(337, 291);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(190, 31);
            this.dtpIngreso.TabIndex = 13;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(337, 94);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(190, 33);
            this.cmbDivisionCurso.TabIndex = 12;
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(337, 47);
            this.nudAnioCurso.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAnioCurso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(190, 31);
            this.nudAnioCurso.TabIndex = 11;
            this.nudAnioCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDocProfesor
            // 
            this.txtDocProfesor.Location = new System.Drawing.Point(337, 244);
            this.txtDocProfesor.Name = "txtDocProfesor";
            this.txtDocProfesor.Size = new System.Drawing.Size(190, 31);
            this.txtDocProfesor.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(337, 195);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(190, 31);
            this.txtApellidoProfe.TabIndex = 9;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(337, 141);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(190, 31);
            this.txtNombreProfe.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(337, 343);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(190, 55);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(24, 343);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(190, 55);
            this.btnCrearCurso.TabIndex = 6;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // dtpIngrso
            // 
            this.dtpIngrso.AutoSize = true;
            this.dtpIngrso.Location = new System.Drawing.Point(24, 296);
            this.dtpIngrso.Name = "dtpIngrso";
            this.dtpIngrso.Size = new System.Drawing.Size(72, 25);
            this.dtpIngrso.TabIndex = 5;
            this.dtpIngrso.Text = "Ingreso";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(24, 247);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(43, 25);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 198);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 25);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(24, 97);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(75, 25);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Text = "Division";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(24, 47);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(45, 25);
            this.lblAnio.TabIndex = 0;
            this.lblAnio.Text = "Año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDivisionAlumno);
            this.groupBox1.Controls.Add(this.nudAnioAlumno);
            this.groupBox1.Controls.Add(this.txtLegajoAlumno);
            this.groupBox1.Controls.Add(this.txtApellidoAlumno);
            this.groupBox1.Controls.Add(this.txtNombreAlumno);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblLegajo);
            this.groupBox1.Controls.Add(this.lblApellidoAlumno);
            this.groupBox1.Controls.Add(this.lblNombreAlumno);
            this.groupBox1.Controls.Add(this.lblDivAlumno);
            this.groupBox1.Controls.Add(this.lblAnioAlumno);
            this.groupBox1.Location = new System.Drawing.Point(612, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Curso";
            // 
            // cmbDivisionAlumno
            // 
            this.cmbDivisionAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivisionAlumno.FormattingEnabled = true;
            this.cmbDivisionAlumno.Location = new System.Drawing.Point(337, 94);
            this.cmbDivisionAlumno.Name = "cmbDivisionAlumno";
            this.cmbDivisionAlumno.Size = new System.Drawing.Size(190, 33);
            this.cmbDivisionAlumno.TabIndex = 12;
            // 
            // nudAnioAlumno
            // 
            this.nudAnioAlumno.Location = new System.Drawing.Point(337, 47);
            this.nudAnioAlumno.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAnioAlumno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnioAlumno.Name = "nudAnioAlumno";
            this.nudAnioAlumno.Size = new System.Drawing.Size(190, 31);
            this.nudAnioAlumno.TabIndex = 11;
            this.nudAnioAlumno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLegajoAlumno
            // 
            this.txtLegajoAlumno.Location = new System.Drawing.Point(337, 244);
            this.txtLegajoAlumno.Name = "txtLegajoAlumno";
            this.txtLegajoAlumno.Size = new System.Drawing.Size(190, 31);
            this.txtLegajoAlumno.TabIndex = 10;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(337, 195);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(190, 31);
            this.txtApellidoAlumno.TabIndex = 9;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(337, 141);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(190, 31);
            this.txtNombreAlumno.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(337, 343);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(190, 55);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(24, 247);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(64, 25);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblApellidoAlumno
            // 
            this.lblApellidoAlumno.AutoSize = true;
            this.lblApellidoAlumno.Location = new System.Drawing.Point(24, 198);
            this.lblApellidoAlumno.Name = "lblApellidoAlumno";
            this.lblApellidoAlumno.Size = new System.Drawing.Size(78, 25);
            this.lblApellidoAlumno.TabIndex = 3;
            this.lblApellidoAlumno.Text = "Apellido";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(24, 144);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(78, 25);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // lblDivAlumno
            // 
            this.lblDivAlumno.AutoSize = true;
            this.lblDivAlumno.Location = new System.Drawing.Point(24, 97);
            this.lblDivAlumno.Name = "lblDivAlumno";
            this.lblDivAlumno.Size = new System.Drawing.Size(75, 25);
            this.lblDivAlumno.TabIndex = 1;
            this.lblDivAlumno.Text = "Division";
            // 
            // lblAnioAlumno
            // 
            this.lblAnioAlumno.AutoSize = true;
            this.lblAnioAlumno.Location = new System.Drawing.Point(24, 47);
            this.lblAnioAlumno.Name = "lblAnioAlumno";
            this.lblAnioAlumno.Size = new System.Drawing.Size(45, 25);
            this.lblAnioAlumno.TabIndex = 0;
            this.lblAnioAlumno.Text = "Año";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(12, 457);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(1179, 302);
            this.rtbInfo.TabIndex = 2;
            this.rtbInfo.Text = "";
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 757);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosCurso);
            this.MaximizeBox = false;
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista del Curso";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            this.gbDatosCurso.ResumeLayout(false);
            this.gbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCurso;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.TextBox txtDocProfesor;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Label dtpIngrso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDivisionAlumno;
        private System.Windows.Forms.NumericUpDown nudAnioAlumno;
        private System.Windows.Forms.TextBox txtLegajoAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellidoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblDivAlumno;
        private System.Windows.Forms.Label lblAnioAlumno;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}

