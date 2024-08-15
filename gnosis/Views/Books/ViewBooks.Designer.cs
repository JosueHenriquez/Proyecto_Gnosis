namespace gnosis.Views.Books
{
    partial class ViewBooks
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
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormContents = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.panelAuxiliar = new System.Windows.Forms.Panel();
            this.panelContentsFormsAuxiliar = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picAgregarAlmacenamiento = new System.Windows.Forms.PictureBox();
            this.picAgregarAutor = new System.Windows.Forms.PictureBox();
            this.picAgregarProveedor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelFormContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.panelAuxiliar.SuspendLayout();
            this.panelContentsFormsAuxiliar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarAlmacenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProveedor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.textBox2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(12);
            this.panelTop.Size = new System.Drawing.Size(1250, 46);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar libro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Libro";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(671, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 21);
            this.textBox2.TabIndex = 1;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.panelFormContents);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForm.Location = new System.Drawing.Point(0, 46);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(408, 605);
            this.panelForm.TabIndex = 1;
            // 
            // panelFormContents
            // 
            this.panelFormContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.panelFormContents.Controls.Add(this.button4);
            this.panelFormContents.Controls.Add(this.button3);
            this.panelFormContents.Controls.Add(this.button2);
            this.panelFormContents.Controls.Add(this.picAgregarAlmacenamiento);
            this.panelFormContents.Controls.Add(this.picAgregarAutor);
            this.panelFormContents.Controls.Add(this.picAgregarProveedor);
            this.panelFormContents.Controls.Add(this.comboBox3);
            this.panelFormContents.Controls.Add(this.comboBox2);
            this.panelFormContents.Controls.Add(this.comboBox1);
            this.panelFormContents.Controls.Add(this.checkBox1);
            this.panelFormContents.Controls.Add(this.label8);
            this.panelFormContents.Controls.Add(this.numericUpDown1);
            this.panelFormContents.Controls.Add(this.label7);
            this.panelFormContents.Controls.Add(this.label5);
            this.panelFormContents.Controls.Add(this.label6);
            this.panelFormContents.Controls.Add(this.label4);
            this.panelFormContents.Controls.Add(this.label3);
            this.panelFormContents.Controls.Add(this.textBox4);
            this.panelFormContents.Controls.Add(this.textBox3);
            this.panelFormContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormContents.ForeColor = System.Drawing.Color.White;
            this.panelFormContents.Location = new System.Drawing.Point(0, 0);
            this.panelFormContents.Name = "panelFormContents";
            this.panelFormContents.Size = new System.Drawing.Size(408, 605);
            this.panelFormContents.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(332, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Disponible para prestamo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 21);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad de libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del libro";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(134, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(365, 21);
            this.textBox3.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvLibros);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(408, 46);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(842, 605);
            this.panelGrid.TabIndex = 2;
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(0, 0);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(842, 605);
            this.dgvLibros.TabIndex = 0;
            // 
            // panelAuxiliar
            // 
            this.panelAuxiliar.BackColor = System.Drawing.Color.White;
            this.panelAuxiliar.Controls.Add(this.panelContentsFormsAuxiliar);
            this.panelAuxiliar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAuxiliar.Location = new System.Drawing.Point(1069, 46);
            this.panelAuxiliar.Name = "panelAuxiliar";
            this.panelAuxiliar.Padding = new System.Windows.Forms.Padding(5);
            this.panelAuxiliar.Size = new System.Drawing.Size(181, 605);
            this.panelAuxiliar.TabIndex = 3;
            // 
            // panelContentsFormsAuxiliar
            // 
            this.panelContentsFormsAuxiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.panelContentsFormsAuxiliar.Controls.Add(this.toolStrip1);
            this.panelContentsFormsAuxiliar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentsFormsAuxiliar.Location = new System.Drawing.Point(5, 5);
            this.panelContentsFormsAuxiliar.Name = "panelContentsFormsAuxiliar";
            this.panelContentsFormsAuxiliar.Size = new System.Drawing.Size(171, 595);
            this.panelContentsFormsAuxiliar.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Almacenamiento";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(14, 264);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(332, 23);
            this.comboBox3.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::gnosis.Properties.Resources.icons8_basura_llena_25;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(263, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Eliminar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::gnosis.Properties.Resources.icons8_17372_0_73111_reproducir_derecha_43_flechas_25;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(145, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Actualizar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::gnosis.Properties.Resources.icons8_save_35;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(27, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picAgregarAlmacenamiento
            // 
            this.picAgregarAlmacenamiento.Image = global::gnosis.Properties.Resources.icons8_añadir_20;
            this.picAgregarAlmacenamiento.Location = new System.Drawing.Point(352, 262);
            this.picAgregarAlmacenamiento.Name = "picAgregarAlmacenamiento";
            this.picAgregarAlmacenamiento.Size = new System.Drawing.Size(25, 25);
            this.picAgregarAlmacenamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregarAlmacenamiento.TabIndex = 5;
            this.picAgregarAlmacenamiento.TabStop = false;
            // 
            // picAgregarAutor
            // 
            this.picAgregarAutor.Image = global::gnosis.Properties.Resources.icons8_añadir_20;
            this.picAgregarAutor.Location = new System.Drawing.Point(352, 208);
            this.picAgregarAutor.Name = "picAgregarAutor";
            this.picAgregarAutor.Size = new System.Drawing.Size(25, 25);
            this.picAgregarAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregarAutor.TabIndex = 5;
            this.picAgregarAutor.TabStop = false;
            // 
            // picAgregarProveedor
            // 
            this.picAgregarProveedor.Image = global::gnosis.Properties.Resources.icons8_añadir_20;
            this.picAgregarProveedor.Location = new System.Drawing.Point(352, 154);
            this.picAgregarProveedor.Name = "picAgregarProveedor";
            this.picAgregarProveedor.Size = new System.Drawing.Size(25, 25);
            this.picAgregarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregarProveedor.TabIndex = 5;
            this.picAgregarProveedor.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::gnosis.Properties.Resources.icons8_búsqueda_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(509, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(171, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::gnosis.Properties.Resources.Close;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(132, 22);
            this.toolStripButton1.Text = "Cerrar panel auxiliar";
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 651);
            this.Controls.Add(this.panelAuxiliar);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooks";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelFormContents.ResumeLayout(false);
            this.panelFormContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.panelAuxiliar.ResumeLayout(false);
            this.panelContentsFormsAuxiliar.ResumeLayout(false);
            this.panelContentsFormsAuxiliar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarAlmacenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProveedor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Panel panelAuxiliar;
        private System.Windows.Forms.Panel panelFormContents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelContentsFormsAuxiliar;
        private System.Windows.Forms.PictureBox picAgregarAutor;
        private System.Windows.Forms.PictureBox picAgregarProveedor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picAgregarAlmacenamiento;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}