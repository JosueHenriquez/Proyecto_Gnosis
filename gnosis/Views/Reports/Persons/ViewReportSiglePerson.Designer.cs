namespace gnosis.Views.Reports.Persons
{
    partial class ViewReportSiglePerson
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbPersonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_InfoBussines = new gnosis.Views.Reports.InfoBussines.DataSet_InfoBussines();
            this.tbInfoBussinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbInfoBussinesTableAdapter = new gnosis.Views.Reports.InfoBussines.DataSet_InfoBussinesTableAdapters.tbInfoBussinesTableAdapter();
            this.dataSet_ReportPerson = new gnosis.Views.Reports.Persons.DataSet_ReportPerson();
            this.tbPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPersonTableAdapter = new gnosis.Views.Reports.Persons.DataSet_ReportPersonTableAdapters.tbPersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_InfoBussines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInfoBussinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbInfoBussinesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tbPersonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gnosis.Views.Reports.Persons.Report_SinglePerson.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(684, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_InfoBussines
            // 
            this.dataSet_InfoBussines.DataSetName = "DataSet_InfoBussines";
            this.dataSet_InfoBussines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbInfoBussinesBindingSource
            // 
            this.tbInfoBussinesBindingSource.DataMember = "tbInfoBussines";
            this.tbInfoBussinesBindingSource.DataSource = this.dataSet_InfoBussines;
            // 
            // tbInfoBussinesTableAdapter
            // 
            this.tbInfoBussinesTableAdapter.ClearBeforeFill = true;
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
            // ViewReportSiglePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewReportSiglePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de persona";
            this.Load += new System.EventHandler(this.ViewReportSiglePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_InfoBussines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInfoBussinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tbPersonBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InfoBussines.DataSet_InfoBussines dataSet_InfoBussines;
        private System.Windows.Forms.BindingSource tbInfoBussinesBindingSource;
        private InfoBussines.DataSet_InfoBussinesTableAdapters.tbInfoBussinesTableAdapter tbInfoBussinesTableAdapter;
        private DataSet_ReportPerson dataSet_ReportPerson;
        private System.Windows.Forms.BindingSource tbPersonBindingSource;
        private DataSet_ReportPersonTableAdapters.tbPersonTableAdapter tbPersonTableAdapter;
    }
}