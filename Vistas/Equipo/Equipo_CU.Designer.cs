namespace ExFinal.Vistas.Equipo
{
    partial class frmEquiposReport
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
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEqDeportivosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_EqDeportivosDataSet = new ExFinal.Gestion_EqDeportivosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.equipoTableAdapter = new ExFinal.Gestion_EqDeportivosDataSetTableAdapters.EquipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEqDeportivosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_EqDeportivosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.gestionEqDeportivosDataSetBindingSource;
            // 
            // gestionEqDeportivosDataSetBindingSource
            // 
            this.gestionEqDeportivosDataSetBindingSource.DataSource = this.gestion_EqDeportivosDataSet;
            this.gestionEqDeportivosDataSetBindingSource.Position = 0;
            // 
            // gestion_EqDeportivosDataSet
            // 
            this.gestion_EqDeportivosDataSet.DataSetName = "Gestion_EqDeportivosDataSet";
            this.gestion_EqDeportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.equipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExFinal.Vistas.Inform.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(588, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // frmEquiposReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEquiposReport";
            this.Text = "Formulario de Equipos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEqDeportivosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_EqDeportivosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gestionEqDeportivosDataSetBindingSource;
        private Gestion_EqDeportivosDataSet gestion_EqDeportivosDataSet;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private Gestion_EqDeportivosDataSetTableAdapters.EquipoTableAdapter equipoTableAdapter;
    }
}