namespace Task_07
{
    partial class FrmTask
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
            this.btn_iniciarLongTask = new System.Windows.Forms.Button();
            this.lb_informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_iniciarLongTask
            // 
            this.btn_iniciarLongTask.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_iniciarLongTask.Location = new System.Drawing.Point(361, 179);
            this.btn_iniciarLongTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_iniciarLongTask.Name = "btn_iniciarLongTask";
            this.btn_iniciarLongTask.Size = new System.Drawing.Size(257, 175);
            this.btn_iniciarLongTask.TabIndex = 0;
            this.btn_iniciarLongTask.Text = "Iniciar Long Task";
            this.btn_iniciarLongTask.UseVisualStyleBackColor = true;
            this.btn_iniciarLongTask.Click += new System.EventHandler(this.btn_iniciarLongTask_Click);
            // 
            // lb_informacion
            // 
            this.lb_informacion.AutoSize = true;
            this.lb_informacion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_informacion.Location = new System.Drawing.Point(256, 75);
            this.lb_informacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_informacion.Name = "lb_informacion";
            this.lb_informacion.Size = new System.Drawing.Size(527, 54);
            this.lb_informacion.TabIndex = 1;
            this.lb_informacion.Text = "ESPERANDO INFORMACION";
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 444);
            this.Controls.Add(this.lb_informacion);
            this.Controls.Add(this.btn_iniciarLongTask);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTask";
            this.Text = "Informacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciarLongTask;
        private System.Windows.Forms.Label lb_informacion;
    }
}
