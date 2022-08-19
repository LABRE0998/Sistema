namespace CapaPresentaciones.Reportes
{
    partial class FrmReporteCategoias
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
            this.spbuscarcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentaciones.DsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spbuscar_categoriaTableAdapter = new CapaPresentaciones.DsPrincipalTableAdapters.spbuscar_categoriaTableAdapter();
            this.spbuscar_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarcategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spbuscarcategoriaBindingSource
            // 
            this.spbuscarcategoriaBindingSource.DataMember = "spbuscar_categoria";
            this.spbuscarcategoriaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscar_categoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentaciones.Reportes.ReporteCategorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // spbuscar_categoriaTableAdapter
            // 
            this.spbuscar_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // spbuscar_categoriaBindingSource
            // 
            this.spbuscar_categoriaBindingSource.DataMember = "spbuscar_categoria";
            this.spbuscar_categoriaBindingSource.DataSource = this.dsPrincipal;
            // 
            // FrmReporteCategoias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCategoias";
            this.Text = "FrmReporteCategoias";
            this.Load += new System.EventHandler(this.FrmReporteCategoias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarcategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource spbuscarcategoriaBindingSource;
        private DsPrincipalTableAdapters.spbuscar_categoriaTableAdapter spbuscar_categoriaTableAdapter;
        private System.Windows.Forms.BindingSource spbuscar_categoriaBindingSource;
    }
}