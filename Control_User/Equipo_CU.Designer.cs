namespace ExFinal.Vistas
{
    partial class Equipo_CU
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(3, 25);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar1.TabIndex = 0;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(84, 25);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(174, 20);
            this.txtBox1.TabIndex = 1;
            // 
            // Equipo_CU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnGuardar1);
            this.Name = "Equipo_CU";
            this.Size = new System.Drawing.Size(277, 73);
            this.Load += new System.EventHandler(this.Equipo_CU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox txtBox1;
    }
}
