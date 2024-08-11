namespace gnosis.Views.Login
{
    partial class ViewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordHide = new System.Windows.Forms.PictureBox();
            this.PasswordVisible = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.linkRecuperarContra = new System.Windows.Forms.LinkLabel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnTest = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordVisible)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 375);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::gnosis.Properties.Resources.pikaso_texttoimage_digital_painting_Un_logo_para_una_bibioteca_bold_a;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(343, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sesión";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(70, 159);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(465, 33);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Engineer";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(70, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(465, 33);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Josue123$";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PasswordHide);
            this.panel2.Controls.Add(this.PasswordVisible);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.LblPassword);
            this.panel2.Controls.Add(this.LblUsername);
            this.panel2.Controls.Add(this.linkRecuperarContra);
            this.panel2.Controls.Add(this.BtnStart);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(359, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 375);
            this.panel2.TabIndex = 1;
            // 
            // PasswordHide
            // 
            this.PasswordHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordHide.Image = global::gnosis.Properties.Resources.hide;
            this.PasswordHide.Location = new System.Drawing.Point(502, 227);
            this.PasswordHide.Name = "PasswordHide";
            this.PasswordHide.Size = new System.Drawing.Size(28, 25);
            this.PasswordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordHide.TabIndex = 11;
            this.PasswordHide.TabStop = false;
            // 
            // PasswordVisible
            // 
            this.PasswordVisible.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordVisible.Image = global::gnosis.Properties.Resources.visible;
            this.PasswordVisible.Location = new System.Drawing.Point(502, 227);
            this.PasswordVisible.Name = "PasswordVisible";
            this.PasswordVisible.Size = new System.Drawing.Size(28, 25);
            this.PasswordVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordVisible.TabIndex = 10;
            this.PasswordVisible.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(70, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Recuerdame";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(36)))), ((int)(((byte)(21)))));
            this.LblPassword.Location = new System.Drawing.Point(67, 204);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(77, 17);
            this.LblPassword.TabIndex = 8;
            this.LblPassword.Text = "Contraseña";
            this.LblPassword.Visible = false;
            // 
            // LblUsername
            // 
            this.LblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(36)))), ((int)(((byte)(21)))));
            this.LblUsername.Location = new System.Drawing.Point(67, 139);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(55, 17);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Usuario";
            this.LblUsername.Visible = false;
            // 
            // linkRecuperarContra
            // 
            this.linkRecuperarContra.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkRecuperarContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkRecuperarContra.AutoSize = true;
            this.linkRecuperarContra.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkRecuperarContra.Location = new System.Drawing.Point(67, 299);
            this.linkRecuperarContra.Name = "linkRecuperarContra";
            this.linkRecuperarContra.Size = new System.Drawing.Size(143, 17);
            this.linkRecuperarContra.TabIndex = 6;
            this.linkRecuperarContra.TabStop = true;
            this.linkRecuperarContra.Text = "¿Olvido su contraseña?";
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(171)))), ((int)(((byte)(198)))));
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStart.Location = new System.Drawing.Point(349, 289);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(186, 37);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Ingresar";
            this.BtnStart.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnExit,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.BtnTest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnExit
            // 
            this.BtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnExit.Image = global::gnosis.Properties.Resources.Close;
            this.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 22);
            this.BtnExit.Text = "Cerrar programa";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::gnosis.Properties.Resources.pikaso_texttoimage_digital_painting_Un_logo_para_una_bibioteca_bold_a;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel1.Text = "Biblioteca Gnósis";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnTest
            // 
            this.BtnTest.Image = global::gnosis.Properties.Resources.Wi_Fi;
            this.BtnTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(114, 22);
            this.BtnTest.Text = "Probar conexión";
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(955, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordVisible)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripButton BtnExit;
        public System.Windows.Forms.Label LblPassword;
        public System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton BtnTest;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button BtnStart;
        public System.Windows.Forms.PictureBox PasswordVisible;
        public System.Windows.Forms.PictureBox PasswordHide;
        public System.Windows.Forms.LinkLabel linkRecuperarContra;
    }
}