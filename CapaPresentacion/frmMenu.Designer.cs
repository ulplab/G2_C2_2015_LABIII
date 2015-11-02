namespace CapaPresentacion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAgregarAdministrador = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnInscribirAlumno = new System.Windows.Forms.Button();
            this.btnDarBajaInscripcion = new System.Windows.Forms.Button();
            this.btnAlumnosPorCurso = new System.Windows.Forms.Button();
            this.btnCursosPorAlumno = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnRegistrosCalificaciones = new System.Windows.Forms.Button();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1016, 93);
            this.ousEncabezado.Titulo = "Menu";
            this.ousEncabezado.Load += new System.EventHandler(this.ousEncabezado_Load);
            // 
            // btnAgregarAdministrador
            // 
            this.btnAgregarAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAgregarAdministrador.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAdministrador.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAdministrador.Image")));
            this.btnAgregarAdministrador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarAdministrador.Location = new System.Drawing.Point(762, 541);
            this.btnAgregarAdministrador.Name = "btnAgregarAdministrador";
            this.btnAgregarAdministrador.Size = new System.Drawing.Size(196, 187);
            this.btnAgregarAdministrador.TabIndex = 32;
            this.btnAgregarAdministrador.TabStop = false;
            this.btnAgregarAdministrador.Text = "Registrar Administrador";
            this.btnAgregarAdministrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarAdministrador.UseVisualStyleBackColor = false;
            this.btnAgregarAdministrador.Click += new System.EventHandler(this.btnAgregarAdministrador_Click);
            this.btnAgregarAdministrador.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnAgregarAdministrador.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAlumno.Image")));
            this.btnAgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(114, 119);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(196, 187);
            this.btnAgregarAlumno.TabIndex = 33;
            this.btnAgregarAlumno.TabStop = false;
            this.btnAgregarAlumno.Text = "Cargar \r\nAlumnos";
            this.btnAgregarAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarAlumno.UseVisualStyleBackColor = false;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            this.btnAgregarAlumno.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnAgregarAlumno.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCurso.FlatAppearance.BorderSize = 0;
            this.btnAgregarCurso.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCurso.Image")));
            this.btnAgregarCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCurso.Location = new System.Drawing.Point(536, 119);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(196, 187);
            this.btnAgregarCurso.TabIndex = 34;
            this.btnAgregarCurso.TabStop = false;
            this.btnAgregarCurso.Text = "Cargar \r\nCursos";
            this.btnAgregarCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCurso.UseVisualStyleBackColor = false;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            this.btnAgregarCurso.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnAgregarCurso.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnInscribirAlumno
            // 
            this.btnInscribirAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnInscribirAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscribirAlumno.FlatAppearance.BorderSize = 0;
            this.btnInscribirAlumno.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInscribirAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInscribirAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInscribirAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirAlumno.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirAlumno.ForeColor = System.Drawing.Color.White;
            this.btnInscribirAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnInscribirAlumno.Image")));
            this.btnInscribirAlumno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInscribirAlumno.Location = new System.Drawing.Point(114, 333);
            this.btnInscribirAlumno.Name = "btnInscribirAlumno";
            this.btnInscribirAlumno.Size = new System.Drawing.Size(196, 187);
            this.btnInscribirAlumno.TabIndex = 38;
            this.btnInscribirAlumno.TabStop = false;
            this.btnInscribirAlumno.Text = "Inscribir \r\nAlumnos";
            this.btnInscribirAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInscribirAlumno.UseVisualStyleBackColor = false;
            this.btnInscribirAlumno.Click += new System.EventHandler(this.btnInscribirAlumno_Click);
            this.btnInscribirAlumno.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnInscribirAlumno.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnDarBajaInscripcion
            // 
            this.btnDarBajaInscripcion.BackColor = System.Drawing.Color.Transparent;
            this.btnDarBajaInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarBajaInscripcion.FlatAppearance.BorderSize = 0;
            this.btnDarBajaInscripcion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDarBajaInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDarBajaInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDarBajaInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBajaInscripcion.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarBajaInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnDarBajaInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("btnDarBajaInscripcion.Image")));
            this.btnDarBajaInscripcion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDarBajaInscripcion.Location = new System.Drawing.Point(325, 333);
            this.btnDarBajaInscripcion.Name = "btnDarBajaInscripcion";
            this.btnDarBajaInscripcion.Size = new System.Drawing.Size(196, 187);
            this.btnDarBajaInscripcion.TabIndex = 39;
            this.btnDarBajaInscripcion.TabStop = false;
            this.btnDarBajaInscripcion.Text = "Dar Baja\r\nInscripción";
            this.btnDarBajaInscripcion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDarBajaInscripcion.UseVisualStyleBackColor = false;
            this.btnDarBajaInscripcion.Click += new System.EventHandler(this.btnDarBajaInscripcion_Click);
            this.btnDarBajaInscripcion.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnDarBajaInscripcion.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnAlumnosPorCurso
            // 
            this.btnAlumnosPorCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnosPorCurso.FlatAppearance.BorderSize = 0;
            this.btnAlumnosPorCurso.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlumnosPorCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnosPorCurso.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnosPorCurso.ForeColor = System.Drawing.Color.White;
            this.btnAlumnosPorCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnosPorCurso.Image")));
            this.btnAlumnosPorCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlumnosPorCurso.Location = new System.Drawing.Point(114, 541);
            this.btnAlumnosPorCurso.Name = "btnAlumnosPorCurso";
            this.btnAlumnosPorCurso.Size = new System.Drawing.Size(196, 187);
            this.btnAlumnosPorCurso.TabIndex = 40;
            this.btnAlumnosPorCurso.TabStop = false;
            this.btnAlumnosPorCurso.Text = "Alumnos por curso";
            this.btnAlumnosPorCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlumnosPorCurso.UseVisualStyleBackColor = false;
            this.btnAlumnosPorCurso.Click += new System.EventHandler(this.btnAlumnosPorCurso_Click);
            this.btnAlumnosPorCurso.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnAlumnosPorCurso.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnCursosPorAlumno
            // 
            this.btnCursosPorAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursosPorAlumno.FlatAppearance.BorderSize = 0;
            this.btnCursosPorAlumno.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCursosPorAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursosPorAlumno.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursosPorAlumno.ForeColor = System.Drawing.Color.White;
            this.btnCursosPorAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnCursosPorAlumno.Image")));
            this.btnCursosPorAlumno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCursosPorAlumno.Location = new System.Drawing.Point(325, 541);
            this.btnCursosPorAlumno.Name = "btnCursosPorAlumno";
            this.btnCursosPorAlumno.Size = new System.Drawing.Size(196, 187);
            this.btnCursosPorAlumno.TabIndex = 41;
            this.btnCursosPorAlumno.TabStop = false;
            this.btnCursosPorAlumno.Text = "Cursos por alumno";
            this.btnCursosPorAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCursosPorAlumno.UseVisualStyleBackColor = false;
            this.btnCursosPorAlumno.Click += new System.EventHandler(this.btnCursosPorAlumno_Click);
            this.btnCursosPorAlumno.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnCursosPorAlumno.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstadisticas.Location = new System.Drawing.Point(536, 541);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(196, 187);
            this.btnEstadisticas.TabIndex = 42;
            this.btnEstadisticas.TabStop = false;
            this.btnEstadisticas.Text = "Reportes Estadisticos";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            this.btnEstadisticas.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnEstadisticas.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnRegistrosCalificaciones
            // 
            this.btnRegistrosCalificaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrosCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrosCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnRegistrosCalificaciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrosCalificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrosCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrosCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrosCalificaciones.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrosCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnRegistrosCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrosCalificaciones.Image")));
            this.btnRegistrosCalificaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrosCalificaciones.Location = new System.Drawing.Point(536, 333);
            this.btnRegistrosCalificaciones.Name = "btnRegistrosCalificaciones";
            this.btnRegistrosCalificaciones.Size = new System.Drawing.Size(196, 187);
            this.btnRegistrosCalificaciones.TabIndex = 43;
            this.btnRegistrosCalificaciones.TabStop = false;
            this.btnRegistrosCalificaciones.Text = "Registros Calificaciones";
            this.btnRegistrosCalificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrosCalificaciones.UseVisualStyleBackColor = false;
            this.btnRegistrosCalificaciones.Click += new System.EventHandler(this.btnRegistrosCalificaciones_Click);
            this.btnRegistrosCalificaciones.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnRegistrosCalificaciones.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // btnAgregarDocentes
            // 
            this.btnAgregarDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDocentes.FlatAppearance.BorderSize = 0;
            this.btnAgregarDocentes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDocentes.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDocentes.Image")));
            this.btnAgregarDocentes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarDocentes.Location = new System.Drawing.Point(325, 119);
            this.btnAgregarDocentes.Name = "btnAgregarDocentes";
            this.btnAgregarDocentes.Size = new System.Drawing.Size(196, 187);
            this.btnAgregarDocentes.TabIndex = 44;
            this.btnAgregarDocentes.TabStop = false;
            this.btnAgregarDocentes.Text = "Cargar \r\nDocentes";
            this.btnAgregarDocentes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarDocentes.UseVisualStyleBackColor = false;
            this.btnAgregarDocentes.Click += new System.EventHandler(this.btnAgregarDocentes_Click);
            this.btnAgregarDocentes.MouseEnter += new System.EventHandler(this.btnListadoRegistros_MouseEnter);
            this.btnAgregarDocentes.MouseLeave += new System.EventHandler(this.btnListadoRegistros_MouseLeave);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 758);
            this.Controls.Add(this.btnAgregarDocentes);
            this.Controls.Add(this.btnRegistrosCalificaciones);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnCursosPorAlumno);
            this.Controls.Add(this.btnAlumnosPorCurso);
            this.Controls.Add(this.btnDarBajaInscripcion);
            this.Controls.Add(this.btnInscribirAlumno);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.btnAgregarAdministrador);
            this.Name = "frmMenu";
            this.Tag = "";
            this.Text = "frmAMBAlumnos";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.btnAgregarAdministrador, 0);
            this.Controls.SetChildIndex(this.btnAgregarAlumno, 0);
            this.Controls.SetChildIndex(this.btnAgregarCurso, 0);
            this.Controls.SetChildIndex(this.btnInscribirAlumno, 0);
            this.Controls.SetChildIndex(this.btnDarBajaInscripcion, 0);
            this.Controls.SetChildIndex(this.btnAlumnosPorCurso, 0);
            this.Controls.SetChildIndex(this.btnCursosPorAlumno, 0);
            this.Controls.SetChildIndex(this.btnEstadisticas, 0);
            this.Controls.SetChildIndex(this.btnRegistrosCalificaciones, 0);
            this.Controls.SetChildIndex(this.btnAgregarDocentes, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAdministrador;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnInscribirAlumno;
        private System.Windows.Forms.Button btnDarBajaInscripcion;
        private System.Windows.Forms.Button btnAlumnosPorCurso;
        private System.Windows.Forms.Button btnCursosPorAlumno;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnRegistrosCalificaciones;
        private System.Windows.Forms.Button btnAgregarDocentes;

    }
}