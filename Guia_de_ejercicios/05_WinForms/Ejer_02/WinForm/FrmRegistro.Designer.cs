
namespace WinForm
{
    partial class FrmRegistro
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
            this.gbDetallesUser = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbtNoBinario = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.lblPais = new System.Windows.Forms.Label();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.cbxJavascript = new System.Windows.Forms.CheckBox();
            this.cbxJava = new System.Windows.Forms.CheckBox();
            this.cbxCplusplus = new System.Windows.Forms.CheckBox();
            this.cbxCsharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbDetallesUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetallesUser
            // 
            this.gbDetallesUser.Controls.Add(this.nudEdad);
            this.gbDetallesUser.Controls.Add(this.txtDireccion);
            this.gbDetallesUser.Controls.Add(this.txtNombre);
            this.gbDetallesUser.Controls.Add(this.lblEdad);
            this.gbDetallesUser.Controls.Add(this.lblDireccion);
            this.gbDetallesUser.Controls.Add(this.lblNombre);
            this.gbDetallesUser.Location = new System.Drawing.Point(31, 52);
            this.gbDetallesUser.Name = "gbDetallesUser";
            this.gbDetallesUser.Size = new System.Drawing.Size(329, 215);
            this.gbDetallesUser.TabIndex = 0;
            this.gbDetallesUser.TabStop = false;
            this.gbDetallesUser.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(137, 149);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(155, 31);
            this.nudEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(154, 31);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 31);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(21, 151);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 25);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 99);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 25);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbtNoBinario);
            this.gbGenero.Controls.Add(this.rbtFemenino);
            this.gbGenero.Controls.Add(this.rbtMasculino);
            this.gbGenero.Location = new System.Drawing.Point(434, 52);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(190, 197);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            // 
            // rbtNoBinario
            // 
            this.rbtNoBinario.AutoSize = true;
            this.rbtNoBinario.Location = new System.Drawing.Point(23, 145);
            this.rbtNoBinario.Name = "rbtNoBinario";
            this.rbtNoBinario.Size = new System.Drawing.Size(120, 29);
            this.rbtNoBinario.TabIndex = 2;
            this.rbtNoBinario.TabStop = true;
            this.rbtNoBinario.Text = "No Binario";
            this.rbtNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(23, 93);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(115, 29);
            this.rbtFemenino.TabIndex = 1;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(23, 44);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(117, 29);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(46, 310);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(42, 25);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "Pais";
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.ItemHeight = 25;
            this.lstPaises.Location = new System.Drawing.Point(31, 338);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(329, 254);
            this.lstPaises.TabIndex = 3;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.cbxJavascript);
            this.gbCursos.Controls.Add(this.cbxJava);
            this.gbCursos.Controls.Add(this.cbxCplusplus);
            this.gbCursos.Controls.Add(this.cbxCsharp);
            this.gbCursos.Location = new System.Drawing.Point(434, 288);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(203, 234);
            this.gbCursos.TabIndex = 4;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // cbxJavascript
            // 
            this.cbxJavascript.AutoSize = true;
            this.cbxJavascript.Location = new System.Drawing.Point(17, 181);
            this.cbxJavascript.Name = "cbxJavascript";
            this.cbxJavascript.Size = new System.Drawing.Size(116, 29);
            this.cbxJavascript.TabIndex = 3;
            this.cbxJavascript.Text = "JavaScript";
            this.cbxJavascript.UseVisualStyleBackColor = true;
            // 
            // cbxJava
            // 
            this.cbxJava.AutoSize = true;
            this.cbxJava.Location = new System.Drawing.Point(17, 134);
            this.cbxJava.Name = "cbxJava";
            this.cbxJava.Size = new System.Drawing.Size(71, 29);
            this.cbxJava.TabIndex = 2;
            this.cbxJava.Text = "Java";
            this.cbxJava.UseVisualStyleBackColor = true;
            // 
            // cbxCplusplus
            // 
            this.cbxCplusplus.AutoSize = true;
            this.cbxCplusplus.Location = new System.Drawing.Point(17, 90);
            this.cbxCplusplus.Name = "cbxCplusplus";
            this.cbxCplusplus.Size = new System.Drawing.Size(73, 29);
            this.cbxCplusplus.TabIndex = 1;
            this.cbxCplusplus.Text = "C++";
            this.cbxCplusplus.UseVisualStyleBackColor = true;
            // 
            // cbxCsharp
            // 
            this.cbxCsharp.AutoSize = true;
            this.cbxCsharp.Location = new System.Drawing.Point(17, 45);
            this.cbxCsharp.Name = "cbxCsharp";
            this.cbxCsharp.Size = new System.Drawing.Size(60, 29);
            this.cbxCsharp.TabIndex = 0;
            this.cbxCsharp.Text = "C#";
            this.cbxCsharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(434, 555);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(203, 51);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 657);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetallesUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.gbDetallesUser.ResumeLayout(false);
            this.gbDetallesUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetallesUser;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbtNoBinario;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox lstPaises;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox cbxJavascript;
        private System.Windows.Forms.CheckBox cbxJava;
        private System.Windows.Forms.CheckBox cbxCplusplus;
        private System.Windows.Forms.CheckBox cbxCsharp;
        private System.Windows.Forms.Button btnIngresar;
    }
}

