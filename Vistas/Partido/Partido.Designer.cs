namespace ExFinal.Vistas
{
    partial class frmPartido
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxEq1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletePatido = new System.Windows.Forms.Button();
            this.btnEditarPartido = new System.Windows.Forms.Button();
            this.btnGuardarPartido = new System.Windows.Forms.Button();
            this.lblAggPartido = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEq2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gestion_EqDeportivosDataSet = new ExFinal.Gestion_EqDeportivosDataSet();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoTableAdapter = new ExFinal.Gestion_EqDeportivosDataSetTableAdapters.EquipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_EqDeportivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEq1
            // 
            this.comboBoxEq1.BackColor = System.Drawing.Color.Silver;
            this.comboBoxEq1.FormattingEnabled = true;
            this.comboBoxEq1.Items.AddRange(new object[] {
            "Aurora Celeste",
            "Centellas Doradas",
            "Halcones de Brisa",
            "Luz de Titán",
            "Leones de Cristal"});
            this.comboBoxEq1.Location = new System.Drawing.Point(70, 305);
            this.comboBoxEq1.Name = "comboBoxEq1";
            this.comboBoxEq1.Size = new System.Drawing.Size(452, 21);
            this.comboBoxEq1.TabIndex = 28;
            this.comboBoxEq1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEq1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Equipo 1:";
            // 
            // btnDeletePatido
            // 
            this.btnDeletePatido.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePatido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePatido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatido.Location = new System.Drawing.Point(408, 413);
            this.btnDeletePatido.Name = "btnDeletePatido";
            this.btnDeletePatido.Size = new System.Drawing.Size(81, 46);
            this.btnDeletePatido.TabIndex = 26;
            this.btnDeletePatido.Text = "Eliminar";
            this.btnDeletePatido.UseVisualStyleBackColor = false;
            this.btnDeletePatido.Click += new System.EventHandler(this.btnDeletePatido_Click);
            // 
            // btnEditarPartido
            // 
            this.btnEditarPartido.BackColor = System.Drawing.Color.Silver;
            this.btnEditarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPartido.Location = new System.Drawing.Point(277, 413);
            this.btnEditarPartido.Name = "btnEditarPartido";
            this.btnEditarPartido.Size = new System.Drawing.Size(81, 46);
            this.btnEditarPartido.TabIndex = 25;
            this.btnEditarPartido.Text = "Editar";
            this.btnEditarPartido.UseVisualStyleBackColor = false;
            this.btnEditarPartido.Click += new System.EventHandler(this.btnEditarPartido_Click);
            // 
            // btnGuardarPartido
            // 
            this.btnGuardarPartido.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPartido.Location = new System.Drawing.Point(148, 413);
            this.btnGuardarPartido.Name = "btnGuardarPartido";
            this.btnGuardarPartido.Size = new System.Drawing.Size(81, 46);
            this.btnGuardarPartido.TabIndex = 24;
            this.btnGuardarPartido.Text = "Guardar";
            this.btnGuardarPartido.UseVisualStyleBackColor = false;
            this.btnGuardarPartido.Click += new System.EventHandler(this.btnGuardarPartido_Click);
            // 
            // lblAggPartido
            // 
            this.lblAggPartido.AutoSize = true;
            this.lblAggPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggPartido.ForeColor = System.Drawing.Color.White;
            this.lblAggPartido.Location = new System.Drawing.Point(142, 71);
            this.lblAggPartido.Name = "lblAggPartido";
            this.lblAggPartido.Size = new System.Drawing.Size(294, 31);
            this.lblAggPartido.TabIndex = 23;
            this.lblAggPartido.Text = "AGREGAR PARTIDO";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Silver;
            this.txtResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtResultado.Location = new System.Drawing.Point(67, 194);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(454, 20);
            this.txtResultado.TabIndex = 21;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtNameTeam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha:";
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer.ForeColor = System.Drawing.Color.White;
            this.lblNamePlayer.Location = new System.Drawing.Point(63, 160);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(96, 20);
            this.lblNamePlayer.TabIndex = 19;
            this.lblNamePlayer.Text = "Resultado:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker.Location = new System.Drawing.Point(67, 249);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(455, 20);
            this.dateTimePicker.TabIndex = 29;
            // 
            // comboBoxEq2
            // 
            this.comboBoxEq2.BackColor = System.Drawing.Color.Silver;
            this.comboBoxEq2.FormattingEnabled = true;
            this.comboBoxEq2.Items.AddRange(new object[] {
            "Tormenta Carmes",
            "Relámpagos del Sur",
            "Furia Esmeralda",
            "Titanes del Alba",
            "Dragones de Acero"});
            this.comboBoxEq2.Location = new System.Drawing.Point(70, 367);
            this.comboBoxEq2.Name = "comboBoxEq2";
            this.comboBoxEq2.Size = new System.Drawing.Size(452, 21);
            this.comboBoxEq2.TabIndex = 31;
            this.comboBoxEq2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEq2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Equipo 2:";
            // 
            // gestion_EqDeportivosDataSet
            // 
            this.gestion_EqDeportivosDataSet.DataSetName = "Gestion_EqDeportivosDataSet";
            this.gestion_EqDeportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.gestion_EqDeportivosDataSet;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(this.comboBoxEq1);
            this.Controls.Add(this.comboBoxEq2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePatido);
            this.Controls.Add(this.btnEditarPartido);
            this.Controls.Add(this.btnGuardarPartido);
            this.Controls.Add(this.lblAggPartido);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamePlayer);
            this.Name = "frmPartido";
            this.Text = "Partido";
            this.Load += new System.EventHandler(this.frmPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_EqDeportivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEq1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletePatido;
        private System.Windows.Forms.Button btnEditarPartido;
        private System.Windows.Forms.Button btnGuardarPartido;
        private System.Windows.Forms.Label lblAggPartido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxEq2;
        private System.Windows.Forms.Label label3;
        private Gestion_EqDeportivosDataSet gestion_EqDeportivosDataSet;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private Gestion_EqDeportivosDataSetTableAdapters.EquipoTableAdapter equipoTableAdapter;
    }
}