namespace gnosis.Views.Administrador_de_usuarios
{
    partial class ViewAdministradorUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUserDisabled = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.contextDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRepGeneralUsuarios = new System.Windows.Forms.Button();
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFicha = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsdesahilitarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.contextDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.btnRepGeneralUsuarios);
            this.panel1.Controls.Add(this.chkUserDisabled);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 46);
            this.panel1.TabIndex = 2;
            // 
            // chkUserDisabled
            // 
            this.chkUserDisabled.AutoSize = true;
            this.chkUserDisabled.ForeColor = System.Drawing.Color.White;
            this.chkUserDisabled.Location = new System.Drawing.Point(653, 17);
            this.chkUserDisabled.Name = "chkUserDisabled";
            this.chkUserDisabled.Size = new System.Drawing.Size(136, 20);
            this.chkUserDisabled.TabIndex = 5;
            this.chkUserDisabled.Text = "Usuarios inactivos";
            this.chkUserDisabled.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(535, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar registro:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Location = new System.Drawing.Point(120, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(15, 6, 6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(371, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevo.Location = new System.Drawing.Point(1074, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(154, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 595);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPersonas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1240, 595);
            this.panel5.TabIndex = 2;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPersonas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.ContextMenuStrip = this.contextDataGrid;
            this.dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonas.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersVisible = false;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1240, 595);
            this.dgvPersonas.TabIndex = 0;
            // 
            // contextDataGrid
            // 
            this.contextDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsActualizar,
            this.cmsEliminar,
            this.cmsFicha,
            this.cmsdesahilitarUsuarioToolStripMenuItem,
            this.restablecerContraseñaToolStripMenuItem});
            this.contextDataGrid.Name = "contextDataGrid";
            this.contextDataGrid.Size = new System.Drawing.Size(196, 114);
            // 
            // btnRepGeneralUsuarios
            // 
            this.btnRepGeneralUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepGeneralUsuarios.Location = new System.Drawing.Point(891, 10);
            this.btnRepGeneralUsuarios.Name = "btnRepGeneralUsuarios";
            this.btnRepGeneralUsuarios.Size = new System.Drawing.Size(177, 30);
            this.btnRepGeneralUsuarios.TabIndex = 6;
            this.btnRepGeneralUsuarios.Text = "Rep. General de usuarios";
            this.btnRepGeneralUsuarios.UseVisualStyleBackColor = true;
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = global::gnosis.Properties.Resources.Refresh;
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(195, 22);
            this.cmsActualizar.Text = "Actualizar registro";
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Image = global::gnosis.Properties.Resources.Close;
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(195, 22);
            this.cmsEliminar.Text = "Eliminar registro";
            // 
            // cmsFicha
            // 
            this.cmsFicha.Image = global::gnosis.Properties.Resources.Male_User;
            this.cmsFicha.Name = "cmsFicha";
            this.cmsFicha.Size = new System.Drawing.Size(195, 22);
            this.cmsFicha.Text = "Ver ficha de empleado";
            // 
            // cmsdesahilitarUsuarioToolStripMenuItem
            // 
            this.cmsdesahilitarUsuarioToolStripMenuItem.Image = global::gnosis.Properties.Resources.icons8_eliminar_usuario_masculino_48;
            this.cmsdesahilitarUsuarioToolStripMenuItem.Name = "cmsdesahilitarUsuarioToolStripMenuItem";
            this.cmsdesahilitarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cmsdesahilitarUsuarioToolStripMenuItem.Text = "Desahilitar usuario";
            // 
            // restablecerContraseñaToolStripMenuItem
            // 
            this.restablecerContraseñaToolStripMenuItem.Image = global::gnosis.Properties.Resources.Access;
            this.restablecerContraseñaToolStripMenuItem.Name = "restablecerContraseñaToolStripMenuItem";
            this.restablecerContraseñaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.restablecerContraseñaToolStripMenuItem.Text = "Restablecer contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gnosis.Properties.Resources.icons8_búsqueda_25;
            this.pictureBox1.Location = new System.Drawing.Point(504, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ViewAdministradorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1250, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAdministradorUsuarios";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAdministradorUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.contextDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.DataGridView dgvPersonas;
        public System.Windows.Forms.ContextMenuStrip contextDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        public System.Windows.Forms.ToolStripMenuItem cmsFicha;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.CheckBox chkUserDisabled;
        public System.Windows.Forms.ToolStripMenuItem cmsdesahilitarUsuarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem restablecerContraseñaToolStripMenuItem;
        public System.Windows.Forms.Button btnRepGeneralUsuarios;
    }
}