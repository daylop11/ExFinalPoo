namespace ExFinal
{
    partial class frmMenu
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.LbelWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPartido = new System.Windows.Forms.Button();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEquipo);
            this.panel1.Controls.Add(this.LbelWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPartido);
            this.panel1.Controls.Add(this.btnJugador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 295);
            this.panel1.TabIndex = 0;
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(88)))), ((int)(((byte)(121)))));
            this.btnEquipo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEquipo.Location = new System.Drawing.Point(247, 193);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(99, 64);
            this.btnEquipo.TabIndex = 0;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.UseVisualStyleBackColor = false;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // LbelWelcome
            // 
            this.LbelWelcome.AutoSize = true;
            this.LbelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelWelcome.ForeColor = System.Drawing.Color.White;
            this.LbelWelcome.Location = new System.Drawing.Point(78, 107);
            this.LbelWelcome.Name = "LbelWelcome";
            this.LbelWelcome.Size = new System.Drawing.Size(465, 31);
            this.LbelWelcome.TabIndex = 6;
            this.LbelWelcome.Text = "BIENVENIDOS AL MENU DE INICIO";
            this.LbelWelcome.Click += new System.EventHandler(this.LbelWelcome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPartido
            // 
            this.btnPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(88)))), ((int)(((byte)(121)))));
            this.btnPartido.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPartido.Location = new System.Drawing.Point(387, 193);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(99, 64);
            this.btnPartido.TabIndex = 4;
            this.btnPartido.Text = "Partido";
            this.btnPartido.UseVisualStyleBackColor = false;
            this.btnPartido.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // btnJugador
            // 
            this.btnJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(88)))), ((int)(((byte)(121)))));
            this.btnJugador.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJugador.Location = new System.Drawing.Point(105, 193);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(99, 64);
            this.btnJugador.TabIndex = 3;
            this.btnJugador.Text = "Jugador";
            this.btnJugador.UseVisualStyleBackColor = false;
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(315, 73);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 64);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(185, 73);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 64);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 232);
            this.panel2.TabIndex = 6;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menú Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnPartido;
        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label LbelWelcome;
        private System.Windows.Forms.Panel panel2;
    }
}

