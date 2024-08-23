namespace gnosis.Views.Reports.Users
{
    partial class ViewReportsUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_ReportGeneralUsers = new gnosis.Views.Reports.Users.DataSet_ReportGeneralUsers();
            this.dataSetReportGeneralUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPersonTableAdapter = new gnosis.Views.Reports.Users.DataSet_ReportGeneralUsersTableAdapters.tbPersonTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportGeneralUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportGeneralUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(401, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbPersonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gnosis.Views.Reports.Users.ReportGeneralUser.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 400);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataSet_ReportGeneralUsers
            // 
            this.dataSet_ReportGeneralUsers.DataSetName = "DataSet_ReportGeneralUsers";
            this.dataSet_ReportGeneralUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReportGeneralUsersBindingSource
            // 
            this.dataSetReportGeneralUsersBindingSource.DataSource = this.dataSet_ReportGeneralUsers;
            this.dataSetReportGeneralUsersBindingSource.Position = 0;
            // 
            // tbPersonBindingSource
            // 
            this.tbPersonBindingSource.DataMember = "tbPerson";
            this.tbPersonBindingSource.DataSource = this.dataSet_ReportGeneralUsers;
            // 
            // tbPersonTableAdapter
            // 
            this.tbPersonTableAdapter.ClearBeforeFill = true;
            // 
            // ViewReportsUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewReportsUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de usuarios";
            this.Load += new System.EventHandler(this.ViewReportsUsers_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportGeneralUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportGeneralUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_ReportGeneralUsers dataSet_ReportGeneralUsers;
        private System.Windows.Forms.BindingSource dataSetReportGeneralUsersBindingSource;
        private System.Windows.Forms.BindingSource tbPersonBindingSource;
        private DataSet_ReportGeneralUsersTableAdapters.tbPersonTableAdapter tbPersonTableAdapter;
    }
}