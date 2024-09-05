namespace gnosis.Views.Server
{
    partial class ViewAdminConnection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabConfigurarValores = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbConf = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rdHabilitarWindows = new System.Windows.Forms.RadioButton();
            this.rdDeshabilitarWindows = new System.Windows.Forms.RadioButton();
            this.panelAuth = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSqlAuth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSqlPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabConfigurarValores.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbConf.SuspendLayout();
            this.panelAuth.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 358);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::gnosis.Properties.Resources.wp9283568;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabConfigurarValores
            // 
            this.tabConfigurarValores.Controls.Add(this.panel4);
            this.tabConfigurarValores.Controls.Add(this.panel3);
            this.tabConfigurarValores.Controls.Add(this.panel2);
            this.tabConfigurarValores.Location = new System.Drawing.Point(4, 22);
            this.tabConfigurarValores.Name = "tabConfigurarValores";
            this.tabConfigurarValores.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigurarValores.Size = new System.Drawing.Size(531, 332);
            this.tabConfigurarValores.TabIndex = 1;
            this.tabConfigurarValores.Text = "Valores de conexión";
            this.tabConfigurarValores.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtDatabase);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtServer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 134);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor URL:";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(17, 38);
            this.txtServer.MaxLength = 40;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(493, 23);
            this.txtServer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Base de datos:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(17, 91);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(493, 23);
            this.txtDatabase.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 192);
            this.panel3.TabIndex = 9;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbConf);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(525, 192);
            this.tabControl2.TabIndex = 0;
            // 
            // tbConf
            // 
            this.tbConf.BackColor = System.Drawing.SystemColors.Control;
            this.tbConf.Controls.Add(this.panelAuth);
            this.tbConf.Controls.Add(this.rdDeshabilitarWindows);
            this.tbConf.Controls.Add(this.rdHabilitarWindows);
            this.tbConf.Controls.Add(this.label3);
            this.tbConf.Location = new System.Drawing.Point(4, 22);
            this.tbConf.Name = "tbConf";
            this.tbConf.Padding = new System.Windows.Forms.Padding(3);
            this.tbConf.Size = new System.Drawing.Size(517, 166);
            this.tbConf.TabIndex = 0;
            this.tbConf.Text = "Configuración local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seguridad integrada de Windows:";
            // 
            // rdHabilitarWindows
            // 
            this.rdHabilitarWindows.AutoSize = true;
            this.rdHabilitarWindows.Checked = true;
            this.rdHabilitarWindows.Location = new System.Drawing.Point(13, 46);
            this.rdHabilitarWindows.Name = "rdHabilitarWindows";
            this.rdHabilitarWindows.Size = new System.Drawing.Size(221, 17);
            this.rdHabilitarWindows.TabIndex = 10;
            this.rdHabilitarWindows.TabStop = true;
            this.rdHabilitarWindows.Text = "Habilitar seguridad integrada de Windows";
            this.rdHabilitarWindows.UseVisualStyleBackColor = true;
            // 
            // rdDeshabilitarWindows
            // 
            this.rdDeshabilitarWindows.AutoSize = true;
            this.rdDeshabilitarWindows.Location = new System.Drawing.Point(13, 69);
            this.rdDeshabilitarWindows.Name = "rdDeshabilitarWindows";
            this.rdDeshabilitarWindows.Size = new System.Drawing.Size(240, 17);
            this.rdDeshabilitarWindows.TabIndex = 10;
            this.rdDeshabilitarWindows.Text = "Desahibilitar seguridad integrada de Windows";
            this.rdDeshabilitarWindows.UseVisualStyleBackColor = true;
            // 
            // panelAuth
            // 
            this.panelAuth.Controls.Add(this.txtSqlPass);
            this.panelAuth.Controls.Add(this.label7);
            this.panelAuth.Controls.Add(this.txtSqlAuth);
            this.panelAuth.Controls.Add(this.label6);
            this.panelAuth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAuth.Location = new System.Drawing.Point(277, 3);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(237, 160);
            this.panelAuth.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "SQL Authentication";
            // 
            // txtSqlAuth
            // 
            this.txtSqlAuth.Location = new System.Drawing.Point(16, 34);
            this.txtSqlAuth.Name = "txtSqlAuth";
            this.txtSqlAuth.Size = new System.Drawing.Size(204, 20);
            this.txtSqlAuth.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password Authentication";
            // 
            // txtSqlPass
            // 
            this.txtSqlPass.Location = new System.Drawing.Point(16, 79);
            this.txtSqlPass.Name = "txtSqlPass";
            this.txtSqlPass.Size = new System.Drawing.Size(204, 20);
            this.txtSqlPass.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 51);
            this.panel4.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(350, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 44);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar configuración";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConfigurarValores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(379, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 358);
            this.tabControl1.TabIndex = 4;
            // 
            // ViewAdminConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 358);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewAdminConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAdminConnection";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabConfigurarValores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbConf.ResumeLayout(false);
            this.tbConf.PerformLayout();
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabConfigurarValores;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbConf;
        public System.Windows.Forms.Panel panelAuth;
        public System.Windows.Forms.TextBox txtSqlPass;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSqlAuth;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton rdDeshabilitarWindows;
        public System.Windows.Forms.RadioButton rdHabilitarWindows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}