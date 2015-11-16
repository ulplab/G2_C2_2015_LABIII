namespace CapaPresentacion
{
    partial class frmCambiarCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.chbParamCursos = new System.Windows.Forms.CheckBox();
            this.pnlBusquedaCursos = new System.Windows.Forms.Panel();
            this.rdFechaFin = new System.Windows.Forms.RadioButton();
            this.rdFechaInicio = new System.Windows.Forms.RadioButton();
            this.rdDescripcion = new System.Windows.Forms.RadioButton();
            this.rdNombreCurso = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscarCurso = new System.Windows.Forms.TextBox();
            this.lblCursos = new System.Windows.Forms.Label();
            this.dgvEtapaDos = new System.Windows.Forms.DataGridView();
            this.lblAlumnoNuevo = new System.Windows.Forms.Label();
            this.tbCursoNuevo = new System.Windows.Forms.TextBox();
            this.lblNombreAnterior = new System.Windows.Forms.Label();
            this.tbCursoAnterior = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBusquedaCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(968, 94);
            this.ousEncabezado.Titulo = "Cambiar Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Filtrar en los cursos";
            // 
            // chbParamCursos
            // 
            this.chbParamCursos.AutoSize = true;
            this.chbParamCursos.BackColor = System.Drawing.Color.Transparent;
            this.chbParamCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParamCursos.ForeColor = System.Drawing.Color.White;
            this.chbParamCursos.Location = new System.Drawing.Point(411, 455);
            this.chbParamCursos.Name = "chbParamCursos";
            this.chbParamCursos.Size = new System.Drawing.Size(124, 28);
            this.chbParamCursos.TabIndex = 53;
            this.chbParamCursos.Text = "Parametros";
            this.chbParamCursos.UseVisualStyleBackColor = false;
            // 
            // pnlBusquedaCursos
            // 
            this.pnlBusquedaCursos.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCursos.Controls.Add(this.rdFechaFin);
            this.pnlBusquedaCursos.Controls.Add(this.rdFechaInicio);
            this.pnlBusquedaCursos.Controls.Add(this.rdDescripcion);
            this.pnlBusquedaCursos.Controls.Add(this.rdNombreCurso);
            this.pnlBusquedaCursos.Location = new System.Drawing.Point(54, 489);
            this.pnlBusquedaCursos.Name = "pnlBusquedaCursos";
            this.pnlBusquedaCursos.Size = new System.Drawing.Size(444, 100);
            this.pnlBusquedaCursos.TabIndex = 52;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(409, 411);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 38);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscarCurso
            // 
            this.tbBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscarCurso.Location = new System.Drawing.Point(54, 411);
            this.tbBuscarCurso.Name = "tbBuscarCurso";
            this.tbBuscarCurso.Size = new System.Drawing.Size(354, 38);
            this.tbBuscarCurso.TabIndex = 50;
            this.tbBuscarCurso.Text = "Nombre";
            this.tbBuscarCurso.Enter += new System.EventHandler(this.tbBuscarCurso_Enter);
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(47, 95);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(287, 39);
            this.lblCursos.TabIndex = 49;
            this.lblCursos.Text = "Cursos Inscriptos";
            // 
            // dgvEtapaDos
            // 
            this.dgvEtapaDos.AllowUserToAddRows = false;
            this.dgvEtapaDos.AllowUserToDeleteRows = false;
            this.dgvEtapaDos.AllowUserToOrderColumns = true;
            this.dgvEtapaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaDos.Location = new System.Drawing.Point(54, 137);
            this.dgvEtapaDos.Name = "dgvEtapaDos";
            this.dgvEtapaDos.ReadOnly = true;
            this.dgvEtapaDos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaDos.Size = new System.Drawing.Size(524, 235);
            this.dgvEtapaDos.TabIndex = 48;
            this.dgvEtapaDos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaDos_CellClick);
            // 
            // lblAlumnoNuevo
            // 
            this.lblAlumnoNuevo.AutoSize = true;
            this.lblAlumnoNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoNuevo.ForeColor = System.Drawing.Color.White;
            this.lblAlumnoNuevo.Location = new System.Drawing.Point(579, 206);
            this.lblAlumnoNuevo.Name = "lblAlumnoNuevo";
            this.lblAlumnoNuevo.Size = new System.Drawing.Size(154, 29);
            this.lblAlumnoNuevo.TabIndex = 98;
            this.lblAlumnoNuevo.Text = "Curso nuevo:";
            // 
            // tbCursoNuevo
            // 
            this.tbCursoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCursoNuevo.Location = new System.Drawing.Point(584, 238);
            this.tbCursoNuevo.Name = "tbCursoNuevo";
            this.tbCursoNuevo.ReadOnly = true;
            this.tbCursoNuevo.Size = new System.Drawing.Size(362, 35);
            this.tbCursoNuevo.TabIndex = 97;
            // 
            // lblNombreAnterior
            // 
            this.lblNombreAnterior.AutoSize = true;
            this.lblNombreAnterior.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAnterior.ForeColor = System.Drawing.Color.White;
            this.lblNombreAnterior.Location = new System.Drawing.Point(579, 136);
            this.lblNombreAnterior.Name = "lblNombreAnterior";
            this.lblNombreAnterior.Size = new System.Drawing.Size(171, 29);
            this.lblNombreAnterior.TabIndex = 96;
            this.lblNombreAnterior.Text = "Curso anterior:";
            // 
            // tbCursoAnterior
            // 
            this.tbCursoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCursoAnterior.Location = new System.Drawing.Point(584, 168);
            this.tbCursoAnterior.Name = "tbCursoAnterior";
            this.tbCursoAnterior.ReadOnly = true;
            this.tbCursoAnterior.Size = new System.Drawing.Size(362, 35);
            this.tbCursoAnterior.TabIndex = 95;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(749, 595);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(197, 90);
            this.btnContinuar.TabIndex = 100;
            this.btnContinuar.Text = "Confirmar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(59, 595);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 90);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambiarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 704);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAlumnoNuevo);
            this.Controls.Add(this.tbCursoNuevo);
            this.Controls.Add(this.lblNombreAnterior);
            this.Controls.Add(this.tbCursoAnterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbParamCursos);
            this.Controls.Add(this.pnlBusquedaCursos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscarCurso);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.dgvEtapaDos);
            this.Name = "frmCambiarCurso";
            this.Text = "frmCambiarCurso";
            this.Load += new System.EventHandler(this.frmCambiarCurso_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.dgvEtapaDos, 0);
            this.Controls.SetChildIndex(this.lblCursos, 0);
            this.Controls.SetChildIndex(this.tbBuscarCurso, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.pnlBusquedaCursos, 0);
            this.Controls.SetChildIndex(this.chbParamCursos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbCursoAnterior, 0);
            this.Controls.SetChildIndex(this.lblNombreAnterior, 0);
            this.Controls.SetChildIndex(this.tbCursoNuevo, 0);
            this.Controls.SetChildIndex(this.lblAlumnoNuevo, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.pnlBusquedaCursos.ResumeLayout(false);
            this.pnlBusquedaCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbParamCursos;
        private System.Windows.Forms.Panel pnlBusquedaCursos;
        private System.Windows.Forms.RadioButton rdFechaFin;
        private System.Windows.Forms.RadioButton rdFechaInicio;
        private System.Windows.Forms.RadioButton rdDescripcion;
        private System.Windows.Forms.RadioButton rdNombreCurso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscarCurso;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.DataGridView dgvEtapaDos;
        private System.Windows.Forms.Label lblAlumnoNuevo;
        private System.Windows.Forms.TextBox tbCursoNuevo;
        private System.Windows.Forms.Label lblNombreAnterior;
        private System.Windows.Forms.TextBox tbCursoAnterior;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
    }
}