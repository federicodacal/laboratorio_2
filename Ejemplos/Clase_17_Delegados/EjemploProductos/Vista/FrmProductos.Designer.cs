
namespace Vista
{
    partial class FrmProductos
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNroProductos = new System.Windows.Forms.Label();
            this.btnValidar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(12, 127);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(443, 69);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "Validar Stock";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(443, 31);
            this.txtCantidad.TabIndex = 1;
            // 
            // lblNroProductos
            // 
            this.lblNroProductos.AutoSize = true;
            this.lblNroProductos.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNroProductos.Location = new System.Drawing.Point(12, 20);
            this.lblNroProductos.Name = "lblNroProductos";
            this.lblNroProductos.Size = new System.Drawing.Size(96, 25);
            this.lblNroProductos.TabIndex = 2;
            this.lblNroProductos.Text = "Cantidad:";
            // 
            // btnValidar2
            // 
            this.btnValidar2.Location = new System.Drawing.Point(12, 202);
            this.btnValidar2.Name = "btnValidar2";
            this.btnValidar2.Size = new System.Drawing.Size(443, 69);
            this.btnValidar2.TabIndex = 3;
            this.btnValidar2.Text = "Validar Stock 2";
            this.btnValidar2.UseVisualStyleBackColor = true;
            this.btnValidar2.Click += new System.EventHandler(this.btnValidar2_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 283);
            this.Controls.Add(this.btnValidar2);
            this.Controls.Add(this.lblNroProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnValidar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblNroProductos;
        private System.Windows.Forms.Button btnValidar2;
    }
}

