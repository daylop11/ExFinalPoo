namespace ExFinal.Vistas
{
    partial class Jugador
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
            this.btnEditarPlayer = new System.Windows.Forms.Button();
            this.btnGuardarPlayer = new System.Windows.Forms.Button();
            this.lblAggPlayer = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.Location = new System.Drawing.Point(408, 414);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(81, 46);
            this.btnDeletePlayer.TabIndex = 16;
            this.btnDeletePlayer.Text = "Eliminar";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditarPlayer
            // 
            this.btnEditarPlayer.BackColor = System.Drawing.Color.Silver;
            this.btnEditarPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlayer.Location = new System.Drawing.Point(277, 414);
            this.btnEditarPlayer.Name = "btnEditarPlayer";
            this.btnEditarPlayer.Size = new System.Drawing.Size(81, 46);
            this.btnEditarPlayer.TabIndex = 15;
            this.btnEditarPlayer.Text = "Editar";
            this.btnEditarPlayer.UseVisualStyleBackColor = false;
            this.btnEditarPlayer.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardarPlayer
            // 
            this.btnGuardarPlayer.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPlayer.Location = new System.Drawing.Point(148, 414);
            this.btnGuardarPlayer.Name = "btnGuardarPlayer";
            this.btnGuardarPlayer.Size = new System.Drawing.Size(81, 46);
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
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.Silver;
            this.txtCiudad.Location = new System.Drawing.Point(68, 241);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(454, 20);
            this.txtCiudad.TabIndex = 12;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtCiudad_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Posicion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Equipo:";
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
            // Jugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnEditarPlayer);
            this.Controls.Add(this.btnGuardarPlayer);
            this.Controls.Add(this.lblAggPlayer);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtNamePlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamePlayer);
            this.Name = "Jugador";
            this.Text = "Jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnEditarPlayer;
        private System.Windows.Forms.Button btnGuardarPlayer;
        private System.Windows.Forms.Label lblAggPlayer;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}