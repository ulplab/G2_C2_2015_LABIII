namespace CapaPresentacion
{
    partial class frmCargarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarAlumnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltroApellido = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFiltroDni = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnDesactivarFiltro = new System.Windows.Forms.Button();
            this.btnActivarFiltro = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(306, 42);
            this.lblTitulo.Text = "Cargar Alumnos";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(1083, 79);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(897, 0);
            // 
            // pbLinea
            // 
            this.pbLinea.Size = new System.Drawing.Size(1083, 10);
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
            this.btnMaximizar.Enabled = false;
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
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(677, 572);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 35);
            this.tbEmail.TabIndex = 38;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(550, 578);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 29);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(677, 519);
            this.tbTelefono.MaxLength = 15;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(200, 35);
            this.tbTelefono.TabIndex = 37;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(550, 525);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(116, 29);
            this.lblTelefono.TabIndex = 43;
            this.lblTelefono.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(677, 464);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(200, 35);
            this.tbDireccion.TabIndex = 36;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(550, 470);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(121, 29);
            this.lblDireccion.TabIndex = 42;
            this.lblDireccion.Text = "Direccion:";
            // 
            // tbDni
            // 
            this.tbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDni.Location = new System.Drawing.Point(294, 572);
            this.tbDni.MaxLength = 8;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(200, 35);
            this.tbDni.TabIndex = 35;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(181, 578);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 29);
            this.lblDni.TabIndex = 41;
            this.lblDni.Text = "Dni:";
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(294, 518);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 35);
            this.tbApellido.TabIndex = 34;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(180, 525);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(108, 29);
            this.lblApellido.TabIndex = 40;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(294, 464);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 35);
            this.tbNombre.TabIndex = 33;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(181, 470);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre:";
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
            this.btnAgregar.Location = new System.Drawing.Point(671, 643);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(169, 68);
            this.btnAgregar.TabIndex = 46;
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
            this.btnCancelar.Location = new System.Drawing.Point(279, 643);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 68);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Tag = "7";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.Location = new System.Drawing.Point(76, 231);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(922, 183);
            this.dgvAlumnos.TabIndex = 64;
            this.dgvAlumnos.TabStop = false;
            this.dgvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellDoubleClick);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(103, 417);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(389, 16);
            this.lblAyuda.TabIndex = 65;
            this.lblAyuda.Text = "Haga doble click en una fila para modificar los datos del alumno";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbFiltroNombre);
            this.panel1.Location = new System.Drawing.Point(16, 34);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbFiltroApellido);
            this.panel2.Location = new System.Drawing.Point(203, 34);
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
            this.tbFiltroApellido.TextChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbFiltroDni);
            this.panel3.Location = new System.Drawing.Point(392, 34);
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
            this.tbFiltroDni.TextChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            this.tbFiltroDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cbFiltroEstado);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(579, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 66);
            this.panel4.TabIndex = 79;
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
            this.gbFiltros.Location = new System.Drawing.Point(76, 94);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(922, 117);
            this.gbFiltros.TabIndex = 66;
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
            this.btnDesactivarFiltro.Location = new System.Drawing.Point(829, 32);
            this.btnDesactivarFiltro.Name = "btnDesactivarFiltro";
            this.btnDesactivarFiltro.Size = new System.Drawing.Size(77, 68);
            this.btnDesactivarFiltro.TabIndex = 80;
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
            this.btnActivarFiltro.Location = new System.Drawing.Point(746, 32);
            this.btnActivarFiltro.Name = "btnActivarFiltro";
            this.btnActivarFiltro.Size = new System.Drawing.Size(77, 68);
            this.btnActivarFiltro.TabIndex = 67;
            this.btnActivarFiltro.Tag = "6";
            this.btnActivarFiltro.Text = "Activar Filtro";
            this.btnActivarFiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivarFiltro.UseVisualStyleBackColor = false;
            this.btnActivarFiltro.Click += new System.EventHandler(this.btnActivarFiltro_Click);
            // 
            // frmCargarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 735);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmCargarAlumnos";
            this.Text = "frmCargarAlumnos";
            this.Load += new System.EventHandler(this.frmCargarAlumnos_Load);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.tbApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.tbDni, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.tbDireccion, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.Controls.SetChildIndex(this.tbTelefono, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.dgvAlumnos, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.Controls.SetChildIndex(this.pnlTitulo, 0);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiltroNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltroApellido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFiltroDni;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbFiltroEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnDesactivarFiltro;
        private System.Windows.Forms.Button btnActivarFiltro;
    }
}