namespace CapaPresentacion
{
    partial class frmAlumnosPorCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnosPorCurso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnDesactivarFiltro = new System.Windows.Forms.Button();
            this.btnActivarFiltro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckbFiltroFechaFin = new System.Windows.Forms.CheckBox();
            this.dtpFiltroFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbFiltroFechaInicio = new System.Windows.Forms.CheckBox();
            this.dtpFiltroFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(367, 42);
            this.lblTitulo.Text = "Alumnos Por Curso";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(1019, 79);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(833, 0);
            // 
            // pbLinea
            // 
            this.pbLinea.Size = new System.Drawing.Size(1019, 10);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.btnDesactivarFiltro);
            this.gbFiltros.Controls.Add(this.btnActivarFiltro);
            this.gbFiltros.Controls.Add(this.panel3);
            this.gbFiltros.Controls.Add(this.panel2);
            this.gbFiltros.Controls.Add(this.panel1);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.White;
            this.gbFiltros.Location = new System.Drawing.Point(95, 105);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(833, 117);
            this.gbFiltros.TabIndex = 81;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btnDesactivarFiltro
            // 
            this.btnDesactivarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnDesactivarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDesactivarFiltro.FlatAppearance.BorderSize = 2;
            this.btnDesactivarFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDesactivarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDesactivarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnDesactivarFiltro.Image")));
            this.btnDesactivarFiltro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesactivarFiltro.Location = new System.Drawing.Point(721, 32);
            this.btnDesactivarFiltro.Name = "btnDesactivarFiltro";
            this.btnDesactivarFiltro.Size = new System.Drawing.Size(77, 68);
            this.btnDesactivarFiltro.TabIndex = 82;
            this.btnDesactivarFiltro.Tag = "6";
            this.btnDesactivarFiltro.Text = "Desactivar Filtro";
            this.btnDesactivarFiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesactivarFiltro.UseVisualStyleBackColor = false;
            this.btnDesactivarFiltro.Click += new System.EventHandler(this.btnDesactivarFiltro_Click);
            // 
            // btnActivarFiltro
            // 
            this.btnActivarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnActivarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnActivarFiltro.FlatAppearance.BorderSize = 2;
            this.btnActivarFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnActivarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnActivarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnActivarFiltro.Image")));
            this.btnActivarFiltro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActivarFiltro.Location = new System.Drawing.Point(638, 32);
            this.btnActivarFiltro.Name = "btnActivarFiltro";
            this.btnActivarFiltro.Size = new System.Drawing.Size(77, 68);
            this.btnActivarFiltro.TabIndex = 81;
            this.btnActivarFiltro.Tag = "6";
            this.btnActivarFiltro.Text = "Activar Filtro";
            this.btnActivarFiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivarFiltro.UseVisualStyleBackColor = false;
            this.btnActivarFiltro.Click += new System.EventHandler(this.btnActivarFiltro_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ckbFiltroFechaFin);
            this.panel3.Controls.Add(this.dtpFiltroFechaFin);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(412, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 66);
            this.panel3.TabIndex = 77;
            // 
            // ckbFiltroFechaFin
            // 
            this.ckbFiltroFechaFin.AutoSize = true;
            this.ckbFiltroFechaFin.Location = new System.Drawing.Point(145, 11);
            this.ckbFiltroFechaFin.Name = "ckbFiltroFechaFin";
            this.ckbFiltroFechaFin.Size = new System.Drawing.Size(15, 14);
            this.ckbFiltroFechaFin.TabIndex = 80;
            this.ckbFiltroFechaFin.UseVisualStyleBackColor = true;
            this.ckbFiltroFechaFin.CheckedChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // dtpFiltroFechaFin
            // 
            this.dtpFiltroFechaFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFiltroFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroFechaFin.Location = new System.Drawing.Point(13, 31);
            this.dtpFiltroFechaFin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFiltroFechaFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFechaFin.Name = "dtpFiltroFechaFin";
            this.dtpFiltroFechaFin.Size = new System.Drawing.Size(181, 24);
            this.dtpFiltroFechaFin.TabIndex = 79;
            this.dtpFiltroFechaFin.ValueChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha Fin:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ckbFiltroFechaInicio);
            this.panel2.Controls.Add(this.dtpFiltroFechaInicio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(193, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 66);
            this.panel2.TabIndex = 76;
            // 
            // ckbFiltroFechaInicio
            // 
            this.ckbFiltroFechaInicio.AutoSize = true;
            this.ckbFiltroFechaInicio.Location = new System.Drawing.Point(156, 11);
            this.ckbFiltroFechaInicio.Name = "ckbFiltroFechaInicio";
            this.ckbFiltroFechaInicio.Size = new System.Drawing.Size(15, 14);
            this.ckbFiltroFechaInicio.TabIndex = 79;
            this.ckbFiltroFechaInicio.UseVisualStyleBackColor = true;
            this.ckbFiltroFechaInicio.CheckedChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // dtpFiltroFechaInicio
            // 
            this.dtpFiltroFechaInicio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFiltroFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroFechaInicio.Location = new System.Drawing.Point(15, 31);
            this.dtpFiltroFechaInicio.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFiltroFechaInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFechaInicio.Name = "dtpFiltroFechaInicio";
            this.dtpFiltroFechaInicio.Size = new System.Drawing.Size(182, 24);
            this.dtpFiltroFechaInicio.TabIndex = 78;
            this.dtpFiltroFechaInicio.ValueChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Fecha Inicio:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbFiltroNombre);
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 66);
            this.panel1.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nombre:";
            // 
            // tbFiltroNombre
            // 
            this.tbFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroNombre.Location = new System.Drawing.Point(12, 31);
            this.tbFiltroNombre.Name = "tbFiltroNombre";
            this.tbFiltroNombre.Size = new System.Drawing.Size(150, 26);
            this.tbFiltroNombre.TabIndex = 67;
            this.tbFiltroNombre.TextChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCursos.Location = new System.Drawing.Point(95, 268);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(833, 183);
            this.dgvCursos.TabIndex = 80;
            this.dgvCursos.TabStop = false;
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAlumnos.Location = new System.Drawing.Point(95, 520);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(833, 183);
            this.dgvAlumnos.TabIndex = 82;
            this.dgvAlumnos.TabStop = false;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(142, 249);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(50, 16);
            this.lblAyuda.TabIndex = 83;
            this.lblAyuda.Text = "Cursos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Alumnos inscriptos en el curso seleccionado";
            // 
            // frmAlumnosPorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 747);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvCursos);
            this.Name = "frmAlumnosPorCurso";
            this.Text = "frmListadosRegistros";
            this.Load += new System.EventHandler(this.frmListadosRegistros_Load);
            this.Controls.SetChildIndex(this.pnlTitulo, 0);
            this.Controls.SetChildIndex(this.dgvCursos, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.Controls.SetChildIndex(this.dgvAlumnos, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnDesactivarFiltro;
        private System.Windows.Forms.Button btnActivarFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckbFiltroFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckbFiltroFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiltroNombre;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label label5;
    }
}