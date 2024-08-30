namespace gnosis.Views.Reports.Persons
{
    partial class ViewGeneralPersons
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoría = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dataSet_ReportPerson = new gnosis.Views.Reports.Persons.DataSet_ReportPerson();
            this.tbPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPersonTableAdapter = new gnosis.Views.Reports.Persons.DataSet_ReportPersonTableAdapters.tbPersonTableAdapter();
            this.tbPersonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cmbCategoría);
            this.flowLayoutPanel1.Controls.Add(this.btnGenerarReporte);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbPersonBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gnosis.Views.Reports.Persons.ReportePersonas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(684, 561);
            this.reportViewer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 17, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una categoría";
            // 
            // cmbCategoría
            // 
            this.cmbCategoría.FormattingEnabled = true;
            this.cmbCategoría.Location = new System.Drawing.Point(148, 15);
            this.cmbCategoría.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cmbCategoría.Name = "cmbCategoría";
            this.cmbCategoría.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoría.TabIndex = 1;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(354, 14);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(118, 23);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // dataSet_ReportPerson
            // 
            this.dataSet_ReportPerson.DataSetName = "DataSet_ReportPerson";
            this.dataSet_ReportPerson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPersonBindingSource
            // 
            this.tbPersonBindingSource.DataMember = "tbPerson";
            this.tbPersonBindingSource.DataSource = this.dataSet_ReportPerson;
            // 
            // tbPersonTableAdapter
            // 
            this.tbPersonTableAdapter.ClearBeforeFill = true;
            // 
            // tbPersonBindingSource1
            // 
            this.tbPersonBindingSource1.DataMember = "tbPerson";
            this.tbPersonBindingSource1.DataSource = this.dataSet_ReportPerson;
            // 
            // ViewGeneralPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ViewGeneralPersons";
            this.Text = "ViewGeneralPersons";
            this.Load += new System.EventHandler(this.ViewGeneralPersons_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCategoría;
        public System.Windows.Forms.Button btnGenerarReporte;
        private DataSet_ReportPerson dataSet_ReportPerson;
        private System.Windows.Forms.BindingSource tbPersonBindingSource;
        private DataSet_ReportPersonTableAdapters.tbPersonTableAdapter tbPersonTableAdapter;
        private System.Windows.Forms.BindingSource tbPersonBindingSource1;
    }
}