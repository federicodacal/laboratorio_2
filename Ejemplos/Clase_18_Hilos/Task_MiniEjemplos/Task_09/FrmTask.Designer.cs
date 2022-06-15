namespace Task_09
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
            this.btn_longTask = new System.Windows.Forms.Button();
            this.btn_cancelarTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_longTask
            // 
            this.btn_longTask.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_longTask.Location = new System.Drawing.Point(92, 215);
            this.btn_longTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_longTask.Name = "btn_longTask";
            this.btn_longTask.Size = new System.Drawing.Size(381, 168);
            this.btn_longTask.TabIndex = 0;
            this.btn_longTask.Text = "Iniciar Long Task";
            this.btn_longTask.UseVisualStyleBackColor = true;
            this.btn_longTask.Click += new System.EventHandler(this.btn_longTask_Click);
            // 
            // btn_cancelarTarea
            // 
            this.btn_cancelarTarea.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarTarea.Location = new System.Drawing.Point(630, 215);
            this.btn_cancelarTarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelarTarea.Name = "btn_cancelarTarea";
            this.btn_cancelarTarea.Size = new System.Drawing.Size(381, 168);
            this.btn_cancelarTarea.TabIndex = 1;
            this.btn_cancelarTarea.Text = "Cancelar Tarea";
            this.btn_cancelarTarea.UseVisualStyleBackColor = true;
            this.btn_cancelarTarea.Click += new System.EventHandler(this.btn_cancelarTarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label";
            // 
            // lb_informacion
            // 
            this.lb_informacion.AutoSize = true;
            this.lb_informacion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_informacion.Location = new System.Drawing.Point(433, 100);
            this.lb_informacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_informacion.Name = "lb_informacion";
            this.lb_informacion.Size = new System.Drawing.Size(235, 54);
            this.lb_informacion.TabIndex = 3;
            this.lb_informacion.Text = "Informacion";
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 437);
            this.Controls.Add(this.lb_informacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelarTarea);
            this.Controls.Add(this.btn_longTask);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTask";
            this.Text = "Informacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_longTask;
        private System.Windows.Forms.Button btn_cancelarTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_informacion;
    }
}
