namespace CapaPresentacion
{
    partial class frmDocentesPorCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentesPorCurso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCursosPorProfesor = new System.Windows.Forms.Button();
            this.btnProfesoresPorCurso = new System.Windows.Forms.Button();
            this.btnCursosPorAlumno = new System.Windows.Forms.Button();
            this.btnAlumnosPorCurso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1019, 94);
            this.ousEncabezado.Titulo = "Docentes por Curso";
            // 
            // btnCursosPorProfesor
            // 
            this.btnCursosPorProfesor.BackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursosPorProfesor.FlatAppearance.BorderSize = 0;
            this.btnCursosPorProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursosPorProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursosPorProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnCursosPorProfesor.Image")));
            this.btnCursosPorProfesor.Location = new System.Drawing.Point(754, 110);
            this.btnCursosPorProfesor.Name = "btnCursosPorProfesor";
            this.btnCursosPorProfesor.Size = new System.Drawing.Size(170, 90);
            this.btnCursosPorProfesor.TabIndex = 92;
            this.btnCursosPorProfesor.Tag = "6";
            this.btnCursosPorProfesor.Text = "Cursos por \r\nDocente";
            this.btnCursosPorProfesor.UseVisualStyleBackColor = false;
            this.btnCursosPorProfesor.Click += new System.EventHandler(this.btnCursosPorProfesor_Click);
            this.btnCursosPorProfesor.MouseEnter += new System.EventHandler(this.btnAlumnosPorCurso_MouseEnter);
            this.btnCursosPorProfesor.MouseLeave += new System.EventHandler(this.btnAlumnosPorCurso_MouseLeave);
            // 
            // btnProfesoresPorCurso
            // 
            this.btnProfesoresPorCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnProfesoresPorCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesoresPorCurso.FlatAppearance.BorderSize = 0;
            this.btnProfesoresPorCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProfesoresPorCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProfesoresPorCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesoresPorCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesoresPorCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesoresPorCurso.Image")));
            this.btnProfesoresPorCurso.Location = new System.Drawing.Point(529, 110);
            this.btnProfesoresPorCurso.Name = "btnProfesoresPorCurso";
            this.btnProfesoresPorCurso.Size = new System.Drawing.Size(170, 90);
            this.btnProfesoresPorCurso.TabIndex = 91;
            this.btnProfesoresPorCurso.Tag = "6";
            this.btnProfesoresPorCurso.Text = "Docentes por \r\nCurso";
            this.btnProfesoresPorCurso.UseVisualStyleBackColor = false;
            this.btnProfesoresPorCurso.Click += new System.EventHandler(this.btnProfesoresPorCurso_Click);
            this.btnProfesoresPorCurso.MouseEnter += new System.EventHandler(this.btnAlumnosPorCurso_MouseEnter);
            this.btnProfesoresPorCurso.MouseLeave += new System.EventHandler(this.btnAlumnosPorCurso_MouseLeave);
            // 
            // btnCursosPorAlumno
            // 
            this.btnCursosPorAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursosPorAlumno.FlatAppearance.BorderSize = 0;
            this.btnCursosPorAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursosPorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursosPorAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnCursosPorAlumno.Image")));
            this.btnCursosPorAlumno.Location = new System.Drawing.Point(313, 110);
            this.btnCursosPorAlumno.Name = "btnCursosPorAlumno";
            this.btnCursosPorAlumno.Size = new System.Drawing.Size(170, 90);
            this.btnCursosPorAlumno.TabIndex = 90;
            this.btnCursosPorAlumno.Tag = "6";
            this.btnCursosPorAlumno.Text = "Cursos por \r\nAlumno";
            this.btnCursosPorAlumno.UseVisualStyleBackColor = false;
            this.btnCursosPorAlumno.Click += new System.EventHandler(this.btnCursosPorAlumno_Click);
            this.btnCursosPorAlumno.MouseEnter += new System.EventHandler(this.btnAlumnosPorCurso_MouseEnter);
            this.btnCursosPorAlumno.MouseLeave += new System.EventHandler(this.btnAlumnosPorCurso_MouseLeave);
            // 
            // btnAlumnosPorCurso
            // 
            this.btnAlumnosPorCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnosPorCurso.FlatAppearance.BorderSize = 0;
            this.btnAlumnosPorCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnosPorCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnosPorCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnosPorCurso.Image")));
            this.btnAlumnosPorCurso.Location = new System.Drawing.Point(90, 110);
            this.btnAlumnosPorCurso.Name = "btnAlumnosPorCurso";
            this.btnAlumnosPorCurso.Size = new System.Drawing.Size(170, 90);
            this.btnAlumnosPorCurso.TabIndex = 89;
            this.btnAlumnosPorCurso.Tag = "6";
            this.btnAlumnosPorCurso.Text = "Alumnos por \r\nCurso";
            this.btnAlumnosPorCurso.UseVisualStyleBackColor = false;
            this.btnAlumnosPorCurso.Click += new System.EventHandler(this.btnAlumnosPorCurso_Click);
            this.btnAlumnosPorCurso.MouseEnter += new System.EventHandler(this.btnAlumnosPorCurso_MouseEnter);
            this.btnAlumnosPorCurso.MouseLeave += new System.EventHandler(this.btnAlumnosPorCurso_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 719);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "Docentes que estan asignados al curso seleccionado";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(137, 361);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(50, 16);
            this.lblAyuda.TabIndex = 96;
            this.lblAyuda.Text = "Cursos";
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            this.dgvProfesores.AllowUserToDeleteRows = false;
            this.dgvProfesores.AllowUserToResizeColumns = false;
            this.dgvProfesores.AllowUserToResizeRows = false;
            this.dgvProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfesores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfesores.Location = new System.Drawing.Point(91, 559);
            this.dgvProfesores.MultiSelect = false;
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.ReadOnly = true;
            this.dgvProfesores.RowHeadersVisible = false;
            this.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesores.Size = new System.Drawing.Size(833, 157);
            this.dgvProfesores.TabIndex = 95;
            this.dgvProfesores.TabStop = false;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.panel3);
            this.gbFiltros.Controls.Add(this.panel2);
            this.gbFiltros.Controls.Add(this.panel1);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.White;
            this.gbFiltros.Location = new System.Drawing.Point(91, 223);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(833, 117);
            this.gbFiltros.TabIndex = 94;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(640, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 66);
            this.btnBuscar.TabIndex = 78;
            this.btnBuscar.Tag = "6";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnAlumnosPorCurso_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnAlumnosPorCurso_MouseLeave);
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
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCursos.Location = new System.Drawing.Point(91, 380);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(833, 157);
            this.dgvCursos.TabIndex = 93;
            this.dgvCursos.TabStop = false;
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // frmDocentesPorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 780);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnCursosPorProfesor);
            this.Controls.Add(this.btnProfesoresPorCurso);
            this.Controls.Add(this.btnCursosPorAlumno);
            this.Controls.Add(this.btnAlumnosPorCurso);
            this.Name = "frmDocentesPorCurso";
            this.Text = "frmDocentesPorCurso";
            this.Load += new System.EventHandler(this.frmDocentesPorCurso_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.btnAlumnosPorCurso, 0);
            this.Controls.SetChildIndex(this.btnCursosPorAlumno, 0);
            this.Controls.SetChildIndex(this.btnProfesoresPorCurso, 0);
            this.Controls.SetChildIndex(this.btnCursosPorProfesor, 0);
            this.Controls.SetChildIndex(this.dgvCursos, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.Controls.SetChildIndex(this.dgvProfesores, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCursosPorProfesor;
        private System.Windows.Forms.Button btnProfesoresPorCurso;
        private System.Windows.Forms.Button btnCursosPorAlumno;
        private System.Windows.Forms.Button btnAlumnosPorCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnBuscar;
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
    }
}