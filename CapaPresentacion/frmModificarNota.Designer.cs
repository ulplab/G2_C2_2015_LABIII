namespace CapaPresentacion
{
    partial class frmModificarNota
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnCambiarNota = new System.Windows.Forms.Button();
            this.btnCambiarCurso = new System.Windows.Forms.Button();
            this.btnCambiarAlumno = new System.Windows.Forms.Button();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbCalificacion = new Controles.DecTextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(830, 94);
            this.ousEncabezado.Titulo = "Modificar Calificación";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.tbCalificacion);
            this.gbDatos.Controls.Add(this.btnCambiarNota);
            this.gbDatos.Controls.Add(this.btnCambiarCurso);
            this.gbDatos.Controls.Add(this.btnCambiarAlumno);
            this.gbDatos.Controls.Add(this.tbCurso);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.lblCurso);
            this.gbDatos.Controls.Add(this.lblNota);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.White;
            this.gbDatos.Location = new System.Drawing.Point(43, 114);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(662, 378);
            this.gbDatos.TabIndex = 105;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de la calificacion";
            // 
            // btnCambiarNota
            // 
            this.btnCambiarNota.BackColor = System.Drawing.Color.Black;
            this.btnCambiarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCambiarNota.ForeColor = System.Drawing.Color.White;
            this.btnCambiarNota.Location = new System.Drawing.Point(456, 289);
            this.btnCambiarNota.Name = "btnCambiarNota";
            this.btnCambiarNota.Size = new System.Drawing.Size(200, 67);
            this.btnCambiarNota.TabIndex = 100;
            this.btnCambiarNota.Text = "Cambiar calificación";
            this.btnCambiarNota.UseVisualStyleBackColor = false;
            this.btnCambiarNota.Click += new System.EventHandler(this.btnCambiarNota_Click);
            // 
            // btnCambiarCurso
            // 
            this.btnCambiarCurso.BackColor = System.Drawing.Color.Black;
            this.btnCambiarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCambiarCurso.ForeColor = System.Drawing.Color.White;
            this.btnCambiarCurso.Location = new System.Drawing.Point(456, 200);
            this.btnCambiarCurso.Name = "btnCambiarCurso";
            this.btnCambiarCurso.Size = new System.Drawing.Size(200, 38);
            this.btnCambiarCurso.TabIndex = 99;
            this.btnCambiarCurso.Text = "Cambiar curso";
            this.btnCambiarCurso.UseVisualStyleBackColor = false;
            this.btnCambiarCurso.Click += new System.EventHandler(this.btnCambiarCurso_Click);
            // 
            // btnCambiarAlumno
            // 
            this.btnCambiarAlumno.BackColor = System.Drawing.Color.Black;
            this.btnCambiarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCambiarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnCambiarAlumno.Location = new System.Drawing.Point(456, 101);
            this.btnCambiarAlumno.Name = "btnCambiarAlumno";
            this.btnCambiarAlumno.Size = new System.Drawing.Size(200, 38);
            this.btnCambiarAlumno.TabIndex = 98;
            this.btnCambiarAlumno.Text = "Cambiar alumno";
            this.btnCambiarAlumno.UseVisualStyleBackColor = false;
            this.btnCambiarAlumno.Click += new System.EventHandler(this.btnCambiarAlumno_Click);
            // 
            // tbCurso
            // 
            this.tbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurso.Location = new System.Drawing.Point(272, 159);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.ReadOnly = true;
            this.tbCurso.Size = new System.Drawing.Size(384, 35);
            this.tbCurso.TabIndex = 85;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(34, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(232, 29);
            this.lblNombre.TabIndex = 90;
            this.lblNombre.Text = "Nombre del alumno:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(272, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(384, 35);
            this.tbNombre.TabIndex = 84;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(34, 165);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(212, 29);
            this.lblCurso.TabIndex = 91;
            this.lblCurso.Text = "Nombre del curso:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(34, 254);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(143, 29);
            this.lblNota.TabIndex = 95;
            this.lblNota.Text = "Calificación:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(621, 661);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(197, 90);
            this.btnContinuar.TabIndex = 106;
            this.btnContinuar.Text = "Aplicar cambio";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(43, 661);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 90);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbCalificacion
            // 
            this.tbCalificacion.Location = new System.Drawing.Point(272, 248);
            this.tbCalificacion.Name = "tbCalificacion";
            this.tbCalificacion.Size = new System.Drawing.Size(384, 35);
            this.tbCalificacion.TabIndex = 101;
            // 
            // frmModificarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 763);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmModificarNota";
            this.Text = "frmModificarNota";
            this.Load += new System.EventHandler(this.frmModificarNota_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnCambiarNota;
        private System.Windows.Forms.Button btnCambiarCurso;
        private System.Windows.Forms.Button btnCambiarAlumno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private Controles.DecTextBox tbCalificacion;
    }
}