namespace gnosis.Views.Reports.Books
{
    partial class ViewReportBooks
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
            this.tbBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Book = new gnosis.Views.Reports.Books.DataSet_Book();
            this.tbBookTableAdapter = new gnosis.Views.Reports.Books.DataSet_BookTableAdapters.tbBookTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvBooks = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.tbBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Book)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBookBindingSource
            // 
            this.tbBookBindingSource.DataMember = "tbBook";
            this.tbBookBindingSource.DataSource = this.dataSet_Book;
            // 
            // dataSet_Book
            // 
            this.dataSet_Book.DataSetName = "DataSet_Book";
            this.dataSet_Book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBookTableAdapter
            // 
            this.tbBookTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cmbCategoria);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvBooks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 611);
            this.panel1.TabIndex = 1;
            // 
            // rpvBooks
            // 
            this.rpvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbBookBindingSource1;
            this.rpvBooks.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBooks.LocalReport.ReportEmbeddedResource = "gnosis.Views.Reports.Books.ReportBook.rdlc";
            this.rpvBooks.Location = new System.Drawing.Point(0, 0);
            this.rpvBooks.Name = "rpvBooks";
            this.rpvBooks.ServerReport.BearerToken = null;
            this.rpvBooks.Size = new System.Drawing.Size(984, 611);
            this.rpvBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar libros por categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(173, 18);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(186, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // tbBookBindingSource1
            // 
            this.tbBookBindingSource1.DataMember = "tbBook";
            this.tbBookBindingSource1.DataSource = this.dataSet_Book;
            // 
            // ViewReportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ViewReportBooks";
            this.Text = "ViewReportBooks";
            ((System.ComponentModel.ISupportInitialize)(this.tbBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Book)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbBookBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCategoria;
        public DataSet_Book dataSet_Book;
        public System.Windows.Forms.BindingSource tbBookBindingSource;
        public DataSet_BookTableAdapters.tbBookTableAdapter tbBookTableAdapter;
        public System.Windows.Forms.BindingSource tbBookBindingSource1;
        public Microsoft.Reporting.WinForms.ReportViewer rpvBooks;
    }
}