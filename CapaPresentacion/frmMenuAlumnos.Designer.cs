namespace CapaPresentacion
{
    partial class frmMenuAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAlumnos));
            this.ousPie = new Controles.usPie();
            this.btnDarBajaInscripcion = new System.Windows.Forms.Button();
            this.btnInscribirAlumno = new System.Windows.Forms.Button();
            this.btnRegistrosCalificaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(833, 94);
            this.ousEncabezado.Titulo = "Menu";
            this.ousEncabezado.Load += new System.EventHandler(this.ousEncabezado_Load);
            // 
            // ousPie
            // 
            this.ousPie.BackColor = System.Drawing.Color.Transparent;
            this.ousPie.FontColor = System.Drawing.Color.White;
            this.ousPie.Location = new System.Drawing.Point(38, 415);
            this.ousPie.Name = "ousPie";
            this.ousPie.Size = new System.Drawing.Size(756, 50);
            this.ousPie.TabIndex = 54;
            this.ousPie.Usuario = null;
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
            this.btnDarBajaInscripcion.Location = new System.Drawing.Point(304, 156);
            this.btnDarBajaInscripcion.Name = "btnDarBajaInscripcion";
            this.btnDarBajaInscripcion.Size = new System.Drawing.Size(196, 187);
            this.btnDarBajaInscripcion.TabIndex = 56;
            this.btnDarBajaInscripcion.TabStop = false;
            this.btnDarBajaInscripcion.Text = "Dar Baja\r\nInscripción";
            this.btnDarBajaInscripcion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDarBajaInscripcion.UseVisualStyleBackColor = false;
            this.btnDarBajaInscripcion.Click += new System.EventHandler(this.btnDarBajaInscripcion_Click);
            this.btnDarBajaInscripcion.MouseEnter += new System.EventHandler(this.btnRegistrosCalificaciones_MouseEnter);
            this.btnDarBajaInscripcion.MouseLeave += new System.EventHandler(this.btnRegistrosCalificaciones_MouseLeave);
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
            this.btnInscribirAlumno.Location = new System.Drawing.Point(72, 156);
            this.btnInscribirAlumno.Name = "btnInscribirAlumno";
            this.btnInscribirAlumno.Size = new System.Drawing.Size(196, 187);
            this.btnInscribirAlumno.TabIndex = 55;
            this.btnInscribirAlumno.TabStop = false;
            this.btnInscribirAlumno.Text = "Inscribirse a un Curso";
            this.btnInscribirAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInscribirAlumno.UseVisualStyleBackColor = false;
            this.btnInscribirAlumno.Click += new System.EventHandler(this.btnInscribirAlumno_Click);
            this.btnInscribirAlumno.MouseEnter += new System.EventHandler(this.btnRegistrosCalificaciones_MouseEnter);
            this.btnInscribirAlumno.MouseLeave += new System.EventHandler(this.btnRegistrosCalificaciones_MouseLeave);
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
            this.btnRegistrosCalificaciones.Location = new System.Drawing.Point(541, 156);
            this.btnRegistrosCalificaciones.Name = "btnRegistrosCalificaciones";
            this.btnRegistrosCalificaciones.Size = new System.Drawing.Size(196, 187);
            this.btnRegistrosCalificaciones.TabIndex = 57;
            this.btnRegistrosCalificaciones.TabStop = false;
            this.btnRegistrosCalificaciones.Text = "Registros Calificaciones";
            this.btnRegistrosCalificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrosCalificaciones.UseVisualStyleBackColor = false;
            this.btnRegistrosCalificaciones.Click += new System.EventHandler(this.btnRegistrosCalificaciones_Click);
            this.btnRegistrosCalificaciones.MouseEnter += new System.EventHandler(this.btnRegistrosCalificaciones_MouseEnter);
            this.btnRegistrosCalificaciones.MouseLeave += new System.EventHandler(this.btnRegistrosCalificaciones_MouseLeave);
            // 
            // frmMenuAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 477);
            this.Controls.Add(this.btnRegistrosCalificaciones);
            this.Controls.Add(this.btnDarBajaInscripcion);
            this.Controls.Add(this.btnInscribirAlumno);
            this.Controls.Add(this.ousPie);
            this.Name = "frmMenuAlumnos";
            this.Tag = "1";
            this.Text = "frmMenuAlumnos";
            this.Load += new System.EventHandler(this.frmMenuAlumnos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.ousPie, 0);
            this.Controls.SetChildIndex(this.btnInscribirAlumno, 0);
            this.Controls.SetChildIndex(this.btnDarBajaInscripcion, 0);
            this.Controls.SetChildIndex(this.btnRegistrosCalificaciones, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.usPie ousPie;
        private System.Windows.Forms.Button btnDarBajaInscripcion;
        private System.Windows.Forms.Button btnInscribirAlumno;
        private System.Windows.Forms.Button btnRegistrosCalificaciones;
    }
}