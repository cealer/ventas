﻿namespace Ventas
{
    partial class Empleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxApellidosLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNombresLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mtbDNI = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefonoDatos = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDireccionDatos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxApellidosDatos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNombresDatos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 72);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage1.Controls.Add(this.tbxDNI);
            this.tabPage1.Controls.Add(this.dgvLista);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.tbxApellidosLista);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbxNombresLista);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tabPage1.Size = new System.Drawing.Size(1208, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de empleados";
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLista.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.Location = new System.Drawing.Point(21, 167);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.dgvLista.Name = "dgvLista";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(1007, 300);
            this.dgvLista.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1047, 83);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 54);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxApellidosLista
            // 
            this.tbxApellidosLista.Location = new System.Drawing.Point(409, 97);
            this.tbxApellidosLista.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tbxApellidosLista.Name = "tbxApellidosLista";
            this.tbxApellidosLista.Size = new System.Drawing.Size(327, 32);
            this.tbxApellidosLista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(402, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // tbxNombresLista
            // 
            this.tbxNombresLista.Location = new System.Drawing.Point(21, 97);
            this.tbxNombresLista.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tbxNombresLista.Name = "tbxNombresLista";
            this.tbxNombresLista.Size = new System.Drawing.Size(327, 32);
            this.tbxNombresLista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Controls.Add(this.mtbDNI);
            this.tabPage2.Controls.Add(this.mtbTelefonoDatos);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbxDireccionDatos);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbxApellidosDatos);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbxNombresDatos);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tabPage2.Size = new System.Drawing.Size(1208, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos de empleados";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(601, 383);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 32);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(442, 383);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 32);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mtbDNI
            // 
            this.mtbDNI.Location = new System.Drawing.Point(591, 92);
            this.mtbDNI.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.mtbDNI.Mask = "99999999";
            this.mtbDNI.Name = "mtbDNI";
            this.mtbDNI.Size = new System.Drawing.Size(84, 32);
            this.mtbDNI.TabIndex = 10;
            // 
            // mtbTelefonoDatos
            // 
            this.mtbTelefonoDatos.Location = new System.Drawing.Point(460, 268);
            this.mtbTelefonoDatos.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.mtbTelefonoDatos.Mask = "(999)000-0000";
            this.mtbTelefonoDatos.Name = "mtbTelefonoDatos";
            this.mtbTelefonoDatos.Size = new System.Drawing.Size(245, 32);
            this.mtbTelefonoDatos.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(460, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefono";
            // 
            // tbxDireccionDatos
            // 
            this.tbxDireccionDatos.Location = new System.Drawing.Point(839, 92);
            this.tbxDireccionDatos.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tbxDireccionDatos.Name = "tbxDireccionDatos";
            this.tbxDireccionDatos.Size = new System.Drawing.Size(279, 32);
            this.tbxDireccionDatos.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(835, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(587, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // tbxApellidosDatos
            // 
            this.tbxApellidosDatos.Location = new System.Drawing.Point(284, 92);
            this.tbxApellidosDatos.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tbxApellidosDatos.Name = "tbxApellidosDatos";
            this.tbxApellidosDatos.Size = new System.Drawing.Size(207, 32);
            this.tbxApellidosDatos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // tbxNombresDatos
            // 
            this.tbxNombresDatos.Location = new System.Drawing.Point(47, 92);
            this.tbxNombresDatos.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.tbxNombresDatos.Name = "tbxNombresDatos";
            this.tbxNombresDatos.Size = new System.Drawing.Size(192, 32);
            this.tbxNombresDatos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1315, 48);
            this.label8.TabIndex = 1;
            this.label8.Text = ":: Registro de empleado ::";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(1954, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 48);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(802, 97);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(177, 32);
            this.tbxDNI.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(798, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "DNI";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem1,
            this.modificarToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombres";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellidos";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DNI";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefono";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1315, 648);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Empleados";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxNombresLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxApellidosLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDireccionDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxApellidosDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNombresDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDNI;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}