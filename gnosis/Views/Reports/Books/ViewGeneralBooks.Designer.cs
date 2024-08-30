namespace gnosis.Views.Reports.Books
{
    partial class ViewGeneralBooks
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
            this.reportBooks = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet_ReportBooks = new gnosis.Views.Reports.Books.DataSet_ReportBooks();
            this.dataSetReportBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBookTableAdapter = new gnosis.Views.Reports.Books.DataSet_ReportBooksTableAdapters.tbBookTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // reportBooks
            // 
            this.reportBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbBookBindingSource;
            this.reportBooks.LocalReport.DataSources.Add(reportDataSource1);
            this.reportBooks.LocalReport.ReportEmbeddedResource = "gnosis.Views.Reports.Books.ReporteLibros.rdlc";
            this.reportBooks.Location = new System.Drawing.Point(0, 50);
            this.reportBooks.Name = "reportBooks";
            this.reportBooks.ServerReport.BearerToken = null;
            this.reportBooks.Size = new System.Drawing.Size(684, 561);
            this.reportBooks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría del libro:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(289, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataSet_ReportBooks
            // 
            this.dataSet_ReportBooks.DataSetName = "DataSet_ReportBooks";
            this.dataSet_ReportBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReportBooksBindingSource
            // 
            this.dataSetReportBooksBindingSource.DataSource = this.dataSet_ReportBooks;
            this.dataSetReportBooksBindingSource.Position = 0;
            // 
            // tbBookBindingSource
            // 
            this.tbBookBindingSource.DataMember = "tbBook";
            this.tbBookBindingSource.DataSource = this.dataSetReportBooksBindingSource;
            // 
            // tbBookTableAdapter
            // 
            this.tbBookTableAdapter.ClearBeforeFill = true;
            // 
            // ViewGeneralBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.reportBooks);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewGeneralBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewGeneralBooks";
            this.Load += new System.EventHandler(this.ViewGeneralBooks_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public Microsoft.Reporting.WinForms.ReportViewer reportBooks;
        private System.Windows.Forms.BindingSource dataSetReportBooksBindingSource;
        private DataSet_ReportBooks dataSet_ReportBooks;
        private System.Windows.Forms.BindingSource tbBookBindingSource;
        private DataSet_ReportBooksTableAdapters.tbBookTableAdapter tbBookTableAdapter;
    }
}