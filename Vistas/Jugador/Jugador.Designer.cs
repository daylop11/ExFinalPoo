namespace ExFinal.Vistas
{
    partial class frmJugador
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
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnGuardarPlayer = new System.Windows.Forms.Button();
            this.lblAggPlayer = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.LblPosition = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.LblTeam = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.Location = new System.Drawing.Point(295, 414);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(103, 62);
            this.btnDeletePlayer.TabIndex = 16;
            this.btnDeletePlayer.Text = "Eliminar";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGuardarPlayer
            // 
            this.btnGuardarPlayer.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPlayer.Location = new System.Drawing.Point(165, 414);
            this.btnGuardarPlayer.Name = "btnGuardarPlayer";
            this.btnGuardarPlayer.Size = new System.Drawing.Size(103, 62);
            this.btnGuardarPlayer.TabIndex = 14;
            this.btnGuardarPlayer.Text = "Guardar";
            this.btnGuardarPlayer.UseVisualStyleBackColor = false;
            this.btnGuardarPlayer.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblAggPlayer
            // 
            this.lblAggPlayer.AutoSize = true;
            this.lblAggPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggPlayer.ForeColor = System.Drawing.Color.White;
            this.lblAggPlayer.Location = new System.Drawing.Point(142, 72);
            this.lblAggPlayer.Name = "lblAggPlayer";
            this.lblAggPlayer.Size = new System.Drawing.Size(306, 31);
            this.lblAggPlayer.TabIndex = 13;
            this.lblAggPlayer.Text = "AGREGAR JUGADOR";
            this.lblAggPlayer.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.Silver;
            this.txtPosition.Location = new System.Drawing.Point(68, 241);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(454, 20);
            this.txtPosition.TabIndex = 12;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtCiudad_TextChanged);
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.BackColor = System.Drawing.Color.Silver;
            this.txtNamePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtNamePlayer.Location = new System.Drawing.Point(67, 195);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(454, 20);
            this.txtNamePlayer.TabIndex = 11;
            this.txtNamePlayer.TextChanged += new System.EventHandler(this.txtNameEq_TextChanged);
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPosition.ForeColor = System.Drawing.Color.White;
            this.LblPosition.Location = new System.Drawing.Point(64, 218);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(81, 20);
            this.LblPosition.TabIndex = 10;
            this.LblPosition.Text = "Posicion:";
            this.LblPosition.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer.ForeColor = System.Drawing.Color.White;
            this.lblNamePlayer.Location = new System.Drawing.Point(63, 161);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(170, 20);
            this.lblNamePlayer.TabIndex = 9;
            this.lblNamePlayer.Text = "Nombre del jugador:";
            this.lblNamePlayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblTeam
            // 
            this.LblTeam.AutoSize = true;
            this.LblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTeam.ForeColor = System.Drawing.Color.White;
            this.LblTeam.Location = new System.Drawing.Point(64, 273);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(70, 20);
            this.LblTeam.TabIndex = 17;
            this.LblTeam.Text = "Equipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // frmJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblTeam);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnGuardarPlayer);
            this.Controls.Add(this.lblAggPlayer);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtNamePlayer);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.lblNamePlayer);
            this.Name = "frmJugador";
            this.Text = "Jugador";
            this.Load += new System.EventHandler(this.frmJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnGuardarPlayer;
        private System.Windows.Forms.Label lblAggPlayer;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label LblTeam;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}