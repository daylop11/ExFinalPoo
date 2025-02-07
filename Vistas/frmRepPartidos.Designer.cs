namespace ExFinal.Vistas
{
    partial class frmRepPartidos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gestion_EqDeportivosDataSet1 = new ExFinal.Gestion_EqDeportivosDataSet1();
            this.gestionEqDeportivosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_EqDeportivosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEqDeportivosDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gestionEqDeportivosDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExFinal.Vistas.Partido.Fechas_Partidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(560, 304);
            this.reportViewer1.TabIndex = 0;
            // 
            // gestion_EqDeportivosDataSet1
            // 
            this.gestion_EqDeportivosDataSet1.DataSetName = "Gestion_EqDeportivosDataSet1";
            this.gestion_EqDeportivosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionEqDeportivosDataSet1BindingSource
            // 
            this.gestionEqDeportivosDataSet1BindingSource.DataSource = this.gestion_EqDeportivosDataSet1;
            this.gestionEqDeportivosDataSet1BindingSource.Position = 0;
            // 
            // frmRepPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepPartidos";
            this.Text = "frmRepPartidos";
            this.Load += new System.EventHandler(this.frmRepPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_EqDeportivosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEqDeportivosDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gestionEqDeportivosDataSet1BindingSource;
        private Gestion_EqDeportivosDataSet1 gestion_EqDeportivosDataSet1;
    }
}