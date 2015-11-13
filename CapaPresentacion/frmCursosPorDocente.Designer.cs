namespace CapaPresentacion
{
    partial class frmCursosPorDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursosPorDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCursosPorProfesor = new System.Windows.Forms.Button();
            this.btnProfesoresPorCurso = new System.Windows.Forms.Button();
            this.btnCursosPorAlumno = new System.Windows.Forms.Button();
            this.btnAlumnosPorCurso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFiltroDni = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltroApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1019, 94);
            this.ousEncabezado.Titulo = "Cursos Por Docente";
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
            this.btnCursosPorProfesor.Location = new System.Drawing.Point(755, 110);
            this.btnCursosPorProfesor.Name = "btnCursosPorProfesor";
            this.btnCursosPorProfesor.Size = new System.Drawing.Size(170, 90);
            this.btnCursosPorProfesor.TabIndex = 96;
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
            this.btnProfesoresPorCurso.Location = new System.Drawing.Point(530, 110);
            this.btnProfesoresPorCurso.Name = "btnProfesoresPorCurso";
            this.btnProfesoresPorCurso.Size = new System.Drawing.Size(170, 90);
            this.btnProfesoresPorCurso.TabIndex = 95;
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
            this.btnCursosPorAlumno.Location = new System.Drawing.Point(314, 110);
            this.btnCursosPorAlumno.Name = "btnCursosPorAlumno";
            this.btnCursosPorAlumno.Size = new System.Drawing.Size(170, 90);
            this.btnCursosPorAlumno.TabIndex = 94;
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
            this.btnAlumnosPorCurso.Location = new System.Drawing.Point(91, 110);
            this.btnAlumnosPorCurso.Name = "btnAlumnosPorCurso";
            this.btnAlumnosPorCurso.Size = new System.Drawing.Size(170, 90);
            this.btnAlumnosPorCurso.TabIndex = 93;
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
            this.label5.Location = new System.Drawing.Point(120, 722);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Cursos donde esta asignado el docente seleccionado";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(138, 364);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(66, 16);
            this.lblAyuda.TabIndex = 101;
            this.lblAyuda.Text = "Docentes";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCursos.Location = new System.Drawing.Point(92, 562);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(833, 157);
            this.dgvCursos.TabIndex = 100;
            this.dgvCursos.TabStop = false;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToResizeColumns = false;
            this.dgvDocentes.AllowUserToResizeRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocentes.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDocentes.Location = new System.Drawing.Point(92, 383);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(833, 157);
            this.dgvDocentes.TabIndex = 98;
            this.dgvDocentes.TabStop = false;
            this.dgvDocentes.SelectionChanged += new System.EventHandler(this.dgvDocentes_SelectionChanged);
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
            this.gbFiltros.Location = new System.Drawing.Point(92, 231);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(833, 117);
            this.gbFiltros.TabIndex = 103;
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
            this.btnBuscar.Location = new System.Drawing.Point(633, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 66);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Tag = "6";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnAlumnosPorCurso_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnAlumnosPorCurso_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbFiltroDni);
            this.panel3.Location = new System.Drawing.Point(420, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 66);
            this.panel3.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "DNI:";
            // 
            // tbFiltroDni
            // 
            this.tbFiltroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroDni.Location = new System.Drawing.Point(12, 31);
            this.tbFiltroDni.Name = "tbFiltroDni";
            this.tbFiltroDni.Size = new System.Drawing.Size(150, 26);
            this.tbFiltroDni.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbFiltroApellido);
            this.panel2.Location = new System.Drawing.Point(231, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 66);
            this.panel2.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Apellido:";
            // 
            // tbFiltroApellido
            // 
            this.tbFiltroApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroApellido.Location = new System.Drawing.Point(12, 31);
            this.tbFiltroApellido.Name = "tbFiltroApellido";
            this.tbFiltroApellido.Size = new System.Drawing.Size(150, 26);
            this.tbFiltroApellido.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbFiltroNombre);
            this.panel1.Location = new System.Drawing.Point(44, 34);
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
            // frmCursosPorDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 780);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.btnCursosPorProfesor);
            this.Controls.Add(this.btnProfesoresPorCurso);
            this.Controls.Add(this.btnCursosPorAlumno);
            this.Controls.Add(this.btnAlumnosPorCurso);
            this.Name = "frmCursosPorDocente";
            this.Text = "CursosPorDocentes";
            this.Load += new System.EventHandler(this.frmCursosPorDocente_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.btnAlumnosPorCurso, 0);
            this.Controls.SetChildIndex(this.btnCursosPorAlumno, 0);
            this.Controls.SetChildIndex(this.btnProfesoresPorCurso, 0);
            this.Controls.SetChildIndex(this.btnCursosPorProfesor, 0);
            this.Controls.SetChildIndex(this.dgvDocentes, 0);
            this.Controls.SetChildIndex(this.dgvCursos, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFiltroDni;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltroApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiltroNombre;
    }
}