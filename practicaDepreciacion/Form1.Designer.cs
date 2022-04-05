namespace practicaDepreciacion
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txutil = new System.Windows.Forms.TextBox();
            this.txvalorr = new System.Windows.Forms.TextBox();
            this.txvalor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(757, 166);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID para borrar o actualizar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(271, 47);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.cboEmpleado);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txutil);
            this.panel1.Controls.Add(this.txvalorr);
            this.panel1.Controls.Add(this.txvalor);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(20, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 247);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "vida util";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "valor residual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "valor";
            // 
            // txutil
            // 
            this.txutil.Location = new System.Drawing.Point(86, 112);
            this.txutil.Margin = new System.Windows.Forms.Padding(2);
            this.txutil.Name = "txutil";
            this.txutil.Size = new System.Drawing.Size(68, 20);
            this.txutil.TabIndex = 8;
            this.txutil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txutil_KeyPress);
            // 
            // txvalorr
            // 
            this.txvalorr.Location = new System.Drawing.Point(86, 81);
            this.txvalorr.Margin = new System.Windows.Forms.Padding(2);
            this.txvalorr.Name = "txvalorr";
            this.txvalorr.Size = new System.Drawing.Size(68, 20);
            this.txvalorr.TabIndex = 7;
            this.txvalorr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txvalorr_KeyPress);
            // 
            // txvalor
            // 
            this.txvalor.Location = new System.Drawing.Point(86, 51);
            this.txvalor.Margin = new System.Windows.Forms.Padding(2);
            this.txvalor.Name = "txvalor";
            this.txvalor.Size = new System.Drawing.Size(68, 20);
            this.txvalor.TabIndex = 6;
            this.txvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txvalor_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoActivoToolStripMenuItem,
            this.borrarActivoToolStripMenuItem,
            this.actualizarActivoToolStripMenuItem,
            this.salirDeLaAplicacionToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoActivoToolStripMenuItem
            // 
            this.nuevoActivoToolStripMenuItem.Name = "nuevoActivoToolStripMenuItem";
            this.nuevoActivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoActivoToolStripMenuItem.Text = "nuevo activo";
            this.nuevoActivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoActivoToolStripMenuItem_Click);
            // 
            // borrarActivoToolStripMenuItem
            // 
            this.borrarActivoToolStripMenuItem.Name = "borrarActivoToolStripMenuItem";
            this.borrarActivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarActivoToolStripMenuItem.Text = "borrar activo";
            this.borrarActivoToolStripMenuItem.Click += new System.EventHandler(this.borrarActivoToolStripMenuItem_Click);
            // 
            // actualizarActivoToolStripMenuItem
            // 
            this.actualizarActivoToolStripMenuItem.Name = "actualizarActivoToolStripMenuItem";
            this.actualizarActivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarActivoToolStripMenuItem.Text = "actualizar activo";
            this.actualizarActivoToolStripMenuItem.Click += new System.EventHandler(this.actualizarActivoToolStripMenuItem_Click);
            // 
            // salirDeLaAplicacionToolStripMenuItem
            // 
            this.salirDeLaAplicacionToolStripMenuItem.Name = "salirDeLaAplicacionToolStripMenuItem";
            this.salirDeLaAplicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDeLaAplicacionToolStripMenuItem.Text = "salir de la aplicacion";
            this.salirDeLaAplicacionToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicacionToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Empleado";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(315, 88);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 23;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(315, 143);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboEmpleado.TabIndex = 24;
            this.cboEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboEmpleado_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 144);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 82);
            this.txtDescripcion.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AcivoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txutil;
        private System.Windows.Forms.TextBox txvalorr;
        private System.Windows.Forms.TextBox txvalor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

