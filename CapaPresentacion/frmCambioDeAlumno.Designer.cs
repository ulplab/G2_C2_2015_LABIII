namespace CapaPresentacion
{
    partial class frmCambioDeAlumno
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
            this.chbParamAlumnos = new System.Windows.Forms.CheckBox();
            this.pnlBusquedaAlumnos = new System.Windows.Forms.Panel();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdTelefono = new System.Windows.Forms.RadioButton();
            this.rdDireccion = new System.Windows.Forms.RadioButton();
            this.rdDni = new System.Windows.Forms.RadioButton();
            this.rdApellido = new System.Windows.Forms.RadioButton();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chbParametros = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblNombreAnterior = new System.Windows.Forms.Label();
            this.tbNombreAnterior = new System.Windows.Forms.TextBox();
            this.lblAlumnoNuevo = new System.Windows.Forms.Label();
            this.tbAlumnoNuevo = new System.Windows.Forms.TextBox();
            this.pnlBusquedaAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(943, 94);
            // 
            // chbParamAlumnos
            // 
            this.chbParamAlumnos.AutoSize = true;
            this.chbParamAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.chbParamAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParamAlumnos.ForeColor = System.Drawing.Color.White;
            this.chbParamAlumnos.Location = new System.Drawing.Point(981, 183);
            this.chbParamAlumnos.Name = "chbParamAlumnos";
            this.chbParamAlumnos.Size = new System.Drawing.Size(124, 28);
            this.chbParamAlumnos.TabIndex = 51;
            this.chbParamAlumnos.Text = "Parametros";
            this.chbParamAlumnos.UseVisualStyleBackColor = false;
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
            this.pnlBusquedaAlumnos.Location = new System.Drawing.Point(52, 473);
            this.pnlBusquedaAlumnos.Name = "pnlBusquedaAlumnos";
            this.pnlBusquedaAlumnos.Size = new System.Drawing.Size(449, 90);
            this.pnlBusquedaAlumnos.TabIndex = 50;
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
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackColor = System.Drawing.Color.Black;
            this.btnBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBuscarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(979, 139);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(126, 38);
            this.btnBuscarAlumno.TabIndex = 49;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscar.Location = new System.Drawing.Point(52, 402);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(354, 38);
            this.tbBuscar.TabIndex = 48;
            this.tbBuscar.Text = "Nombre";
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(29, 97);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(153, 39);
            this.lblAlumnos.TabIndex = 47;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.AllowUserToOrderColumns = true;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaUno.Location = new System.Drawing.Point(52, 139);
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(486, 228);
            this.dgvEtapaUno.TabIndex = 52;
            this.dgvEtapaUno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Filtrar en los alumnos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(412, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 44;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbParametros
            // 
            this.chbParametros.AutoSize = true;
            this.chbParametros.BackColor = System.Drawing.Color.Transparent;
            this.chbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParametros.ForeColor = System.Drawing.Color.White;
            this.chbParametros.Location = new System.Drawing.Point(414, 439);
            this.chbParametros.Name = "chbParametros";
            this.chbParametros.Size = new System.Drawing.Size(124, 28);
            this.chbParametros.TabIndex = 46;
            this.chbParametros.Text = "Parametros";
            this.chbParametros.UseVisualStyleBackColor = false;
            this.chbParametros.CheckedChanged += new System.EventHandler(this.chbParametros_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(52, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 90);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(725, 566);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(197, 90);
            this.btnContinuar.TabIndex = 55;
            this.btnContinuar.Text = "Confirmar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblNombreAnterior
            // 
            this.lblNombreAnterior.AutoSize = true;
            this.lblNombreAnterior.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAnterior.ForeColor = System.Drawing.Color.White;
            this.lblNombreAnterior.Location = new System.Drawing.Point(544, 139);
            this.lblNombreAnterior.Name = "lblNombreAnterior";
            this.lblNombreAnterior.Size = new System.Drawing.Size(188, 29);
            this.lblNombreAnterior.TabIndex = 92;
            this.lblNombreAnterior.Text = "Alumno anterior:";
            // 
            // tbNombreAnterior
            // 
            this.tbNombreAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreAnterior.Location = new System.Drawing.Point(549, 171);
            this.tbNombreAnterior.Name = "tbNombreAnterior";
            this.tbNombreAnterior.ReadOnly = true;
            this.tbNombreAnterior.Size = new System.Drawing.Size(362, 35);
            this.tbNombreAnterior.TabIndex = 91;
            // 
            // lblAlumnoNuevo
            // 
            this.lblAlumnoNuevo.AutoSize = true;
            this.lblAlumnoNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoNuevo.ForeColor = System.Drawing.Color.White;
            this.lblAlumnoNuevo.Location = new System.Drawing.Point(544, 209);
            this.lblAlumnoNuevo.Name = "lblAlumnoNuevo";
            this.lblAlumnoNuevo.Size = new System.Drawing.Size(171, 29);
            this.lblAlumnoNuevo.TabIndex = 94;
            this.lblAlumnoNuevo.Text = "Alumno nuevo:";
            // 
            // tbAlumnoNuevo
            // 
            this.tbAlumnoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlumnoNuevo.Location = new System.Drawing.Point(549, 241);
            this.tbAlumnoNuevo.Name = "tbAlumnoNuevo";
            this.tbAlumnoNuevo.ReadOnly = true;
            this.tbAlumnoNuevo.Size = new System.Drawing.Size(362, 35);
            this.tbAlumnoNuevo.TabIndex = 93;
            // 
            // frmCambioDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 668);
            this.Controls.Add(this.lblAlumnoNuevo);
            this.Controls.Add(this.tbAlumnoNuevo);
            this.Controls.Add(this.lblNombreAnterior);
            this.Controls.Add(this.tbNombreAnterior);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEtapaUno);
            this.Controls.Add(this.chbParamAlumnos);
            this.Controls.Add(this.chbParametros);
            this.Controls.Add(this.pnlBusquedaAlumnos);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lblAlumnos);
            this.Name = "frmCambioDeAlumno";
            this.Text = "frmCambioDeAlumno";
            this.Load += new System.EventHandler(this.frmCambioDeAlumno_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.lblAlumnos, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnBuscarAlumno, 0);
            this.Controls.SetChildIndex(this.pnlBusquedaAlumnos, 0);
            this.Controls.SetChildIndex(this.chbParametros, 0);
            this.Controls.SetChildIndex(this.chbParamAlumnos, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.tbNombreAnterior, 0);
            this.Controls.SetChildIndex(this.lblNombreAnterior, 0);
            this.Controls.SetChildIndex(this.tbAlumnoNuevo, 0);
            this.Controls.SetChildIndex(this.lblAlumnoNuevo, 0);
            this.pnlBusquedaAlumnos.ResumeLayout(false);
            this.pnlBusquedaAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbParamAlumnos;
        private System.Windows.Forms.Panel pnlBusquedaAlumnos;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdTelefono;
        private System.Windows.Forms.RadioButton rdDireccion;
        private System.Windows.Forms.RadioButton rdDni;
        private System.Windows.Forms.RadioButton rdApellido;
        private System.Windows.Forms.RadioButton rdNombre;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbParametros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblAlumnoNuevo;
        private System.Windows.Forms.TextBox tbAlumnoNuevo;
        private System.Windows.Forms.Label lblNombreAnterior;
        private System.Windows.Forms.TextBox tbNombreAnterior;
    }
}