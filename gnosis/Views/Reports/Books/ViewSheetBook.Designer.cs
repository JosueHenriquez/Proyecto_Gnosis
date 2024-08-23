namespace gnosis.Views.Reports.Books
{
    partial class ViewSheetBook
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
            this.rpwSheetBook = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpwSheetBook
            // 
            this.rpwSheetBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpwSheetBook.Location = new System.Drawing.Point(10, 10);
            this.rpwSheetBook.Name = "rpwSheetBook";
            this.rpwSheetBook.ServerReport.BearerToken = null;
            this.rpwSheetBook.Size = new System.Drawing.Size(776, 687);
            this.rpwSheetBook.TabIndex = 0;
            // 
            // ViewSheetBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.rpwSheetBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 750);
            this.MinimumSize = new System.Drawing.Size(816, 750);
            this.Name = "ViewSheetBook";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha técnica del libro";
            this.Load += new System.EventHandler(this.ViewSheetBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpwSheetBook;
    }
}