namespace CapaPresentacion
{
    partial class frmRegistrarCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarCuota));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblCursos = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cachedcrReciboCobroMatricula1 = new CapaPresentacion.Reportes.CachedcrReciboCobroMatricula();
            this.label2 = new System.Windows.Forms.Label();
            this.chbParamAlumnos = new System.Windows.Forms.CheckBox();
            this.pnlBusquedaAlumnos = new System.Windows.Forms.Panel();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdTelefono = new System.Windows.Forms.RadioButton();
            this.rdDireccion = new System.Windows.Forms.RadioButton();
            this.rdDni = new System.Windows.Forms.RadioButton();
            this.rdApellido = new System.Windows.Forms.RadioButton();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbParamCursos = new System.Windows.Forms.CheckBox();
            this.pnlBusquedaCursos = new System.Windows.Forms.Panel();
            this.rdFechaFin = new System.Windows.Forms.RadioButton();
            this.rdFechaInicio = new System.Windows.Forms.RadioButton();
            this.rdDescripcion = new System.Windows.Forms.RadioButton();
            this.rdNombreCurso = new System.Windows.Forms.RadioButton();
            this.tbBuscarCurso = new System.Windows.Forms.TextBox();
            this.lblVariableCurso = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblVariableAlumno = new System.Windows.Forms.Label();
            this.lblTituloAlumno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarAlumnos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCuota = new System.Windows.Forms.Label();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.dgvEtapaDos = new System.Windows.Forms.DataGridView();
            this.pnlBusquedaAlumnos.SuspendLayout();
            this.pnlBusquedaCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.EnableMaximizar = true;
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1251, 94);
            this.ousEncabezado.Titulo = "Cuotas";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(21, 97);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(153, 39);
            this.lblAlumnos.TabIndex = 25;
            this.lblAlumnos.Text = "Alumnos";
            this.lblAlumnos.Click += new System.EventHandler(this.lblAlumnos_Click);
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(21, 369);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(271, 39);
            this.lblCursos.TabIndex = 26;
            this.lblCursos.Text = "Cursos Morosos";
            this.lblCursos.Click += new System.EventHandler(this.lblCursos_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(882, 674);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(318, 76);
            this.btnContinuar.TabIndex = 27;
            this.btnContinuar.Text = "Registrar Cuota";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(712, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Filtrar en los alumnos";
            // 
            // chbParamAlumnos
            // 
            this.chbParamAlumnos.AutoSize = true;
            this.chbParamAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.chbParamAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParamAlumnos.ForeColor = System.Drawing.Color.White;
            this.chbParamAlumnos.Location = new System.Drawing.Point(1071, 230);
            this.chbParamAlumnos.Name = "chbParamAlumnos";
            this.chbParamAlumnos.Size = new System.Drawing.Size(124, 28);
            this.chbParamAlumnos.TabIndex = 52;
            this.chbParamAlumnos.Text = "Parametros";
            this.chbParamAlumnos.UseVisualStyleBackColor = false;
            this.chbParamAlumnos.CheckedChanged += new System.EventHandler(this.chbParamAlumnos_CheckedChanged);
            // 
            // pnlBusquedaAlumnos
            // 
            this.pnlBusquedaAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaAlumnos.Controls.Add(this.rdEmail);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdTelefono);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdDireccion);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdDni);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdApellido);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdNombre);
            this.pnlBusquedaAlumnos.Location = new System.Drawing.Point(714, 264);
            this.pnlBusquedaAlumnos.Name = "pnlBusquedaAlumnos";
            this.pnlBusquedaAlumnos.Size = new System.Drawing.Size(449, 90);
            this.pnlBusquedaAlumnos.TabIndex = 51;
            this.pnlBusquedaAlumnos.Visible = false;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.BackColor = System.Drawing.Color.Transparent;
            this.rdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdEmail.ForeColor = System.Drawing.Color.White;
            this.rdEmail.Location = new System.Drawing.Point(5, 42);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(92, 33);
            this.rdEmail.TabIndex = 33;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = false;
            this.rdEmail.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdTelefono
            // 
            this.rdTelefono.AutoSize = true;
            this.rdTelefono.BackColor = System.Drawing.Color.Transparent;
            this.rdTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdTelefono.ForeColor = System.Drawing.Color.White;
            this.rdTelefono.Location = new System.Drawing.Point(285, 44);
            this.rdTelefono.Name = "rdTelefono";
            this.rdTelefono.Size = new System.Drawing.Size(128, 33);
            this.rdTelefono.TabIndex = 32;
            this.rdTelefono.TabStop = true;
            this.rdTelefono.Text = "Telefono";
            this.rdTelefono.UseVisualStyleBackColor = false;
            this.rdTelefono.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdDireccion
            // 
            this.rdDireccion.AutoSize = true;
            this.rdDireccion.BackColor = System.Drawing.Color.Transparent;
            this.rdDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDireccion.ForeColor = System.Drawing.Color.White;
            this.rdDireccion.Location = new System.Drawing.Point(285, 5);
            this.rdDireccion.Name = "rdDireccion";
            this.rdDireccion.Size = new System.Drawing.Size(133, 33);
            this.rdDireccion.TabIndex = 31;
            this.rdDireccion.TabStop = true;
            this.rdDireccion.Text = "Direccion";
            this.rdDireccion.UseVisualStyleBackColor = false;
            this.rdDireccion.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdDni
            // 
            this.rdDni.AutoSize = true;
            this.rdDni.BackColor = System.Drawing.Color.Transparent;
            this.rdDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDni.ForeColor = System.Drawing.Color.White;
            this.rdDni.Location = new System.Drawing.Point(149, 42);
            this.rdDni.Name = "rdDni";
            this.rdDni.Size = new System.Drawing.Size(72, 33);
            this.rdDni.TabIndex = 30;
            this.rdDni.TabStop = true;
            this.rdDni.Text = "DNI";
            this.rdDni.UseVisualStyleBackColor = false;
            this.rdDni.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdApellido
            // 
            this.rdApellido.AutoSize = true;
            this.rdApellido.BackColor = System.Drawing.Color.Transparent;
            this.rdApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdApellido.ForeColor = System.Drawing.Color.White;
            this.rdApellido.Location = new System.Drawing.Point(149, 5);
            this.rdApellido.Name = "rdApellido";
            this.rdApellido.Size = new System.Drawing.Size(120, 33);
            this.rdApellido.TabIndex = 29;
            this.rdApellido.TabStop = true;
            this.rdApellido.Text = "Apellido";
            this.rdApellido.UseVisualStyleBackColor = false;
            this.rdApellido.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdNombre
            // 
            this.rdNombre.AutoSize = true;
            this.rdNombre.BackColor = System.Drawing.Color.Transparent;
            this.rdNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdNombre.ForeColor = System.Drawing.Color.White;
            this.rdNombre.Location = new System.Drawing.Point(5, 3);
            this.rdNombre.Name = "rdNombre";
            this.rdNombre.Size = new System.Drawing.Size(119, 33);
            this.rdNombre.TabIndex = 24;
            this.rdNombre.TabStop = true;
            this.rdNombre.Text = "Nombre";
            this.rdNombre.UseVisualStyleBackColor = false;
            this.rdNombre.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscar.Location = new System.Drawing.Point(714, 186);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(354, 38);
            this.tbBuscar.TabIndex = 49;
            this.tbBuscar.Text = "Nombre";
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(714, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Filtrar en los cursos";
            // 
            // chbParamCursos
            // 
            this.chbParamCursos.AutoSize = true;
            this.chbParamCursos.BackColor = System.Drawing.Color.Transparent;
            this.chbParamCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParamCursos.ForeColor = System.Drawing.Color.White;
            this.chbParamCursos.Location = new System.Drawing.Point(1076, 503);
            this.chbParamCursos.Name = "chbParamCursos";
            this.chbParamCursos.Size = new System.Drawing.Size(124, 28);
            this.chbParamCursos.TabIndex = 57;
            this.chbParamCursos.Text = "Parametros";
            this.chbParamCursos.UseVisualStyleBackColor = false;
            this.chbParamCursos.CheckedChanged += new System.EventHandler(this.chbParamCursos_CheckedChanged);
            // 
            // pnlBusquedaCursos
            // 
            this.pnlBusquedaCursos.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCursos.Controls.Add(this.rdFechaFin);
            this.pnlBusquedaCursos.Controls.Add(this.rdFechaInicio);
            this.pnlBusquedaCursos.Controls.Add(this.rdDescripcion);
            this.pnlBusquedaCursos.Controls.Add(this.rdNombreCurso);
            this.pnlBusquedaCursos.Location = new System.Drawing.Point(719, 522);
            this.pnlBusquedaCursos.Name = "pnlBusquedaCursos";
            this.pnlBusquedaCursos.Size = new System.Drawing.Size(444, 100);
            this.pnlBusquedaCursos.TabIndex = 56;
            this.pnlBusquedaCursos.Visible = false;
            // 
            // rdFechaFin
            // 
            this.rdFechaFin.AutoSize = true;
            this.rdFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.rdFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdFechaFin.ForeColor = System.Drawing.Color.White;
            this.rdFechaFin.Location = new System.Drawing.Point(5, 42);
            this.rdFechaFin.Name = "rdFechaFin";
            this.rdFechaFin.Size = new System.Drawing.Size(195, 33);
            this.rdFechaFin.TabIndex = 33;
            this.rdFechaFin.TabStop = true;
            this.rdFechaFin.Text = "Fecha de inicio";
            this.rdFechaFin.UseVisualStyleBackColor = false;
            this.rdFechaFin.CheckedChanged += new System.EventHandler(this.rdNombreCurso_CheckedChanged);
            // 
            // rdFechaInicio
            // 
            this.rdFechaInicio.AutoSize = true;
            this.rdFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.rdFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdFechaInicio.ForeColor = System.Drawing.Color.White;
            this.rdFechaInicio.Location = new System.Drawing.Point(221, 42);
            this.rdFechaInicio.Name = "rdFechaInicio";
            this.rdFechaInicio.Size = new System.Drawing.Size(163, 33);
            this.rdFechaInicio.TabIndex = 31;
            this.rdFechaInicio.TabStop = true;
            this.rdFechaInicio.Text = "Fecha de fin";
            this.rdFechaInicio.UseVisualStyleBackColor = false;
            this.rdFechaInicio.CheckedChanged += new System.EventHandler(this.rdNombreCurso_CheckedChanged);
            // 
            // rdDescripcion
            // 
            this.rdDescripcion.AutoSize = true;
            this.rdDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.rdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDescripcion.ForeColor = System.Drawing.Color.White;
            this.rdDescripcion.Location = new System.Drawing.Point(221, 3);
            this.rdDescripcion.Name = "rdDescripcion";
            this.rdDescripcion.Size = new System.Drawing.Size(159, 33);
            this.rdDescripcion.TabIndex = 29;
            this.rdDescripcion.TabStop = true;
            this.rdDescripcion.Text = "Descripcion";
            this.rdDescripcion.UseVisualStyleBackColor = false;
            this.rdDescripcion.CheckedChanged += new System.EventHandler(this.rdNombreCurso_CheckedChanged);
            // 
            // rdNombreCurso
            // 
            this.rdNombreCurso.AutoSize = true;
            this.rdNombreCurso.BackColor = System.Drawing.Color.Transparent;
            this.rdNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdNombreCurso.ForeColor = System.Drawing.Color.White;
            this.rdNombreCurso.Location = new System.Drawing.Point(5, 3);
            this.rdNombreCurso.Name = "rdNombreCurso";
            this.rdNombreCurso.Size = new System.Drawing.Size(119, 33);
            this.rdNombreCurso.TabIndex = 24;
            this.rdNombreCurso.TabStop = true;
            this.rdNombreCurso.Text = "Nombre";
            this.rdNombreCurso.UseVisualStyleBackColor = false;
            this.rdNombreCurso.CheckedChanged += new System.EventHandler(this.rdNombreCurso_CheckedChanged);
            // 
            // tbBuscarCurso
            // 
            this.tbBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscarCurso.Location = new System.Drawing.Point(719, 459);
            this.tbBuscarCurso.Name = "tbBuscarCurso";
            this.tbBuscarCurso.Size = new System.Drawing.Size(354, 38);
            this.tbBuscarCurso.TabIndex = 54;
            this.tbBuscarCurso.Text = "Nombre";
            this.tbBuscarCurso.Enter += new System.EventHandler(this.tbBuscarCurso_Enter);
            // 
            // lblVariableCurso
            // 
            this.lblVariableCurso.AutoSize = true;
            this.lblVariableCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblVariableCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblVariableCurso.ForeColor = System.Drawing.Color.White;
            this.lblVariableCurso.Location = new System.Drawing.Point(622, 714);
            this.lblVariableCurso.Name = "lblVariableCurso";
            this.lblVariableCurso.Size = new System.Drawing.Size(208, 36);
            this.lblVariableCurso.TabIndex = 60;
            this.lblVariableCurso.Text = "Nombre Curso";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(623, 681);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(197, 29);
            this.lblCurso.TabIndex = 59;
            this.lblCurso.Text = "Al curso llamado:";
            // 
            // lblVariableAlumno
            // 
            this.lblVariableAlumno.AutoSize = true;
            this.lblVariableAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblVariableAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblVariableAlumno.ForeColor = System.Drawing.Color.White;
            this.lblVariableAlumno.Location = new System.Drawing.Point(254, 710);
            this.lblVariableAlumno.Name = "lblVariableAlumno";
            this.lblVariableAlumno.Size = new System.Drawing.Size(230, 36);
            this.lblVariableAlumno.TabIndex = 62;
            this.lblVariableAlumno.Text = "Nombre Alumno";
            // 
            // lblTituloAlumno
            // 
            this.lblTituloAlumno.AutoSize = true;
            this.lblTituloAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTituloAlumno.ForeColor = System.Drawing.Color.White;
            this.lblTituloAlumno.Location = new System.Drawing.Point(251, 681);
            this.lblTituloAlumno.Name = "lblTituloAlumno";
            this.lblTituloAlumno.Size = new System.Drawing.Size(233, 29);
            this.lblTituloAlumno.TabIndex = 61;
            this.lblTituloAlumno.Text = "Del alumno llamado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Total a pagar:";
            // 
            // btnBuscarAlumnos
            // 
            this.btnBuscarAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnBuscarAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumnos.Image")));
            this.btnBuscarAlumnos.Location = new System.Drawing.Point(1074, 172);
            this.btnBuscarAlumnos.Name = "btnBuscarAlumnos";
            this.btnBuscarAlumnos.Size = new System.Drawing.Size(146, 52);
            this.btnBuscarAlumnos.TabIndex = 86;
            this.btnBuscarAlumnos.Tag = "6";
            this.btnBuscarAlumnos.UseVisualStyleBackColor = false;
            this.btnBuscarAlumnos.Click += new System.EventHandler(this.btnBuscarAlumnos_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(1079, 445);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 52);
            this.btnBuscar.TabIndex = 87;
            this.btnBuscar.Tag = "6";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.BackColor = System.Drawing.Color.Transparent;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblCuota.ForeColor = System.Drawing.Color.White;
            this.lblCuota.Location = new System.Drawing.Point(44, 714);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(108, 36);
            this.lblCuota.TabIndex = 88;
            this.lblCuota.Text = "$00,00";
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.AllowUserToResizeColumns = false;
            this.dgvEtapaUno.AllowUserToResizeRows = false;
            this.dgvEtapaUno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtapaUno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtapaUno.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEtapaUno.Location = new System.Drawing.Point(28, 139);
            this.dgvEtapaUno.MultiSelect = false;
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.RowHeadersVisible = false;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(678, 215);
            this.dgvEtapaUno.TabIndex = 89;
            this.dgvEtapaUno.TabStop = false;
            this.dgvEtapaUno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_RowEnter);
            // 
            // dgvEtapaDos
            // 
            this.dgvEtapaDos.AllowUserToAddRows = false;
            this.dgvEtapaDos.AllowUserToDeleteRows = false;
            this.dgvEtapaDos.AllowUserToResizeColumns = false;
            this.dgvEtapaDos.AllowUserToResizeRows = false;
            this.dgvEtapaDos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtapaDos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEtapaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtapaDos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEtapaDos.Location = new System.Drawing.Point(28, 411);
            this.dgvEtapaDos.MultiSelect = false;
            this.dgvEtapaDos.Name = "dgvEtapaDos";
            this.dgvEtapaDos.ReadOnly = true;
            this.dgvEtapaDos.RowHeadersVisible = false;
            this.dgvEtapaDos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaDos.Size = new System.Drawing.Size(678, 215);
            this.dgvEtapaDos.TabIndex = 90;
            this.dgvEtapaDos.TabStop = false;
            this.dgvEtapaDos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvetapa2_RowEnter);
            // 
            // frmRegistrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 780);
            this.Controls.Add(this.dgvEtapaDos);
            this.Controls.Add(this.dgvEtapaUno);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBuscarAlumnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVariableAlumno);
            this.Controls.Add(this.lblTituloAlumno);
            this.Controls.Add(this.lblVariableCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbParamCursos);
            this.Controls.Add(this.pnlBusquedaCursos);
            this.Controls.Add(this.tbBuscarCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbParamAlumnos);
            this.Controls.Add(this.pnlBusquedaAlumnos);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.lblAlumnos);
            this.Name = "frmRegistrarCuota";
            this.Text = "frmRegistrarCuota";
            this.Load += new System.EventHandler(this.frmRegistrarCuota_Load);
            this.Controls.SetChildIndex(this.lblAlumnos, 0);
            this.Controls.SetChildIndex(this.lblCursos, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.pnlBusquedaAlumnos, 0);
            this.Controls.SetChildIndex(this.chbParamAlumnos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.tbBuscarCurso, 0);
            this.Controls.SetChildIndex(this.pnlBusquedaCursos, 0);
            this.Controls.SetChildIndex(this.chbParamCursos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblCurso, 0);
            this.Controls.SetChildIndex(this.lblVariableCurso, 0);
            this.Controls.SetChildIndex(this.lblTituloAlumno, 0);
            this.Controls.SetChildIndex(this.lblVariableAlumno, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnBuscarAlumnos, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblCuota, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.dgvEtapaDos, 0);
            this.pnlBusquedaAlumnos.ResumeLayout(false);
            this.pnlBusquedaAlumnos.PerformLayout();
            this.pnlBusquedaCursos.ResumeLayout(false);
            this.pnlBusquedaCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnContinuar;
        private Reportes.CachedcrReciboCobroMatricula cachedcrReciboCobroMatricula1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbParamAlumnos;
        private System.Windows.Forms.Panel pnlBusquedaAlumnos;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdTelefono;
        private System.Windows.Forms.RadioButton rdDireccion;
        private System.Windows.Forms.RadioButton rdDni;
        private System.Windows.Forms.RadioButton rdApellido;
        private System.Windows.Forms.RadioButton rdNombre;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbParamCursos;
        private System.Windows.Forms.Panel pnlBusquedaCursos;
        private System.Windows.Forms.RadioButton rdFechaFin;
        private System.Windows.Forms.RadioButton rdFechaInicio;
        private System.Windows.Forms.RadioButton rdDescripcion;
        private System.Windows.Forms.RadioButton rdNombreCurso;
        private System.Windows.Forms.TextBox tbBuscarCurso;
        private System.Windows.Forms.Label lblVariableCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblVariableAlumno;
        private System.Windows.Forms.Label lblTituloAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarAlumnos;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.DataGridView dgvEtapaDos;
    }
}