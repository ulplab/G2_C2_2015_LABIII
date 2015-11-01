namespace CapaPresentacion
{
    partial class frmCargarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarCursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaIncio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaIncio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnDesactivarFiltro = new System.Windows.Forms.Button();
            this.btnActivarFiltro = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lblAyuda = new System.Windows.Forms.Label();
            this.gbFiltros.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1096, 79);
            this.ousEncabezado.Titulo = "Cargar Cursos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(622, 625);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(169, 68);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Tag = "6";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(316, 625);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 68);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Tag = "7";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(295, 543);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(175, 35);
            this.tbDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(140, 549);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblDescripcion.TabIndex = 74;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(507, 546);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(126, 29);
            this.lblFechaFin.TabIndex = 73;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaIncio
            // 
            this.lblFechaIncio.AutoSize = true;
            this.lblFechaIncio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIncio.ForeColor = System.Drawing.Color.White;
            this.lblFechaIncio.Location = new System.Drawing.Point(505, 489);
            this.lblFechaIncio.Name = "lblFechaIncio";
            this.lblFechaIncio.Size = new System.Drawing.Size(143, 29);
            this.lblFechaIncio.TabIndex = 72;
            this.lblFechaIncio.Text = "Fecha Incio:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(295, 483);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(175, 35);
            this.tbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(140, 489);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Nombre:";
            // 
            // dtpFechaIncio
            // 
            this.dtpFechaIncio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFechaIncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIncio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIncio.Location = new System.Drawing.Point(654, 483);
            this.dtpFechaIncio.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFechaIncio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIncio.Name = "dtpFechaIncio";
            this.dtpFechaIncio.Size = new System.Drawing.Size(271, 35);
            this.dtpFechaIncio.TabIndex = 2;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(654, 540);
            this.dtpFechaFin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(272, 35);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.btnDesactivarFiltro);
            this.gbFiltros.Controls.Add(this.btnActivarFiltro);
            this.gbFiltros.Controls.Add(this.panel4);
            this.gbFiltros.Controls.Add(this.panel3);
            this.gbFiltros.Controls.Add(this.panel2);
            this.gbFiltros.Controls.Add(this.panel1);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.White;
            this.gbFiltros.Location = new System.Drawing.Point(59, 99);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(966, 117);
            this.gbFiltros.TabIndex = 79;
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
            this.btnDesactivarFiltro.Location = new System.Drawing.Point(875, 34);
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
            this.btnActivarFiltro.Location = new System.Drawing.Point(792, 34);
            this.btnActivarFiltro.Name = "btnActivarFiltro";
            this.btnActivarFiltro.Size = new System.Drawing.Size(77, 68);
            this.btnActivarFiltro.TabIndex = 81;
            this.btnActivarFiltro.Tag = "6";
            this.btnActivarFiltro.Text = "Activar Filtro";
            this.btnActivarFiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivarFiltro.UseVisualStyleBackColor = false;
            this.btnActivarFiltro.Click += new System.EventHandler(this.btnActivarFiltro_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cbFiltroEstado);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(631, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 66);
            this.panel4.TabIndex = 78;
            // 
            // cbFiltroEstado
            // 
            this.cbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroEstado.FormattingEnabled = true;
            this.cbFiltroEstado.Location = new System.Drawing.Point(13, 29);
            this.cbFiltroEstado.Name = "cbFiltroEstado";
            this.cbFiltroEstado.Size = new System.Drawing.Size(121, 28);
            this.cbFiltroEstado.TabIndex = 71;
            this.cbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Estado:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursos.Location = new System.Drawing.Point(59, 238);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(966, 183);
            this.dgvCursos.TabIndex = 78;
            this.dgvCursos.TabStop = false;
            this.dgvCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellDoubleClick);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(97, 424);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(378, 16);
            this.lblAyuda.TabIndex = 80;
            this.lblAyuda.Text = "Haga doble click en una fila para modificar los datos del curso";
            // 
            // frmCargarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 730);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaIncio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIncio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmCargarCursos";
            this.Text = "frmCargarCursos";
            this.Load += new System.EventHandler(this.frmCargarCursos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.lblFechaIncio, 0);
            this.Controls.SetChildIndex(this.lblFechaFin, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.tbDescripcion, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.dtpFechaIncio, 0);
            this.Controls.SetChildIndex(this.dtpFechaFin, 0);
            this.Controls.SetChildIndex(this.dgvCursos, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.gbFiltros.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaIncio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaIncio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiltroNombre;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbFiltroEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDesactivarFiltro;
        private System.Windows.Forms.Button btnActivarFiltro;
        private System.Windows.Forms.CheckBox ckbFiltroFechaFin;
        private System.Windows.Forms.CheckBox ckbFiltroFechaInicio;
    }
}