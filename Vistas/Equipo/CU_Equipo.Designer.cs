namespace ExFinal.Vistas.Equipo
{
    partial class frmCU_Equipo
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
            this.LblBuscar = new System.Windows.Forms.Label();
            this.btnBuscarCU = new System.Windows.Forms.Button();
            this.txtCuEquipo = new System.Windows.Forms.TextBox();
            this.btnCancelarCU = new System.Windows.Forms.Button();
            this.PnlBuscar1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwEquipo = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(9, 28);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(73, 16);
            this.LblBuscar.TabIndex = 8;
            this.LblBuscar.Text = "BUSCAR;";
            // 
            // btnBuscarCU
            // 
            this.btnBuscarCU.Location = new System.Drawing.Point(466, 47);
            this.btnBuscarCU.Name = "btnBuscarCU";
            this.btnBuscarCU.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCU.TabIndex = 7;
            this.btnBuscarCU.Text = "Buscar";
            this.btnBuscarCU.UseVisualStyleBackColor = true;
            this.btnBuscarCU.Click += new System.EventHandler(this.btnBuscarCU_Click);
            // 
            // txtCuEquipo
            // 
            this.txtCuEquipo.Location = new System.Drawing.Point(12, 47);
            this.txtCuEquipo.Name = "txtCuEquipo";
            this.txtCuEquipo.Size = new System.Drawing.Size(367, 20);
            this.txtCuEquipo.TabIndex = 6;
            this.txtCuEquipo.TextChanged += new System.EventHandler(this.txtCuEquipo_TextChanged);
            // 
            // btnCancelarCU
            // 
            this.btnCancelarCU.Location = new System.Drawing.Point(385, 47);
            this.btnCancelarCU.Name = "btnCancelarCU";
            this.btnCancelarCU.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCU.TabIndex = 5;
            this.btnCancelarCU.Text = "Cancelar";
            this.btnCancelarCU.UseVisualStyleBackColor = true;
            this.btnCancelarCU.Click += new System.EventHandler(this.btnAgregarCU_Click);
            // 
            // PnlBuscar1
            // 
            this.PnlBuscar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBuscar1.Location = new System.Drawing.Point(0, 0);
            this.PnlBuscar1.Name = "PnlBuscar1";
            this.PnlBuscar1.Size = new System.Drawing.Size(568, 100);
            this.PnlBuscar1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwEquipo);
            this.panel2.Location = new System.Drawing.Point(-6, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 395);
            this.panel2.TabIndex = 10;
            // 
            // dgwEquipo
            // 
            this.dgwEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwEquipo.Location = new System.Drawing.Point(0, 0);
            this.dgwEquipo.Name = "dgwEquipo";
            this.dgwEquipo.Size = new System.Drawing.Size(574, 395);
            this.dgwEquipo.TabIndex = 2;
            // 
            // frmCU_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(568, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.btnBuscarCU);
            this.Controls.Add(this.txtCuEquipo);
            this.Controls.Add(this.btnCancelarCU);
            this.Controls.Add(this.PnlBuscar1);
            this.Name = "frmCU_Equipo";
            this.Text = "CU_Equipo";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button btnBuscarCU;
        private System.Windows.Forms.TextBox txtCuEquipo;
        private System.Windows.Forms.Button btnCancelarCU;
        private System.Windows.Forms.Panel PnlBuscar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwEquipo;
    }
}