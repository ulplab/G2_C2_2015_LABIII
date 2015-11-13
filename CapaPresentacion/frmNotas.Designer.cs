namespace CapaPresentacion
{
    partial class frmNotas
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
            this.lblCursos = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.dgvEtapaDos = new System.Windows.Forms.DataGridView();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblTituloALumno = new System.Windows.Forms.Label();
            this.lvlVariableAlumno = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblVariableCurso = new System.Windows.Forms.Label();
            this.tbNota = new Controles.DecTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(954, 94);
            this.ousEncabezado.Titulo = "Registro de Notas";
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(33, 382);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(287, 39);
            this.lblCursos.TabIndex = 30;
            this.lblCursos.Text = "Cursos Inscriptos";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(33, 95);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(153, 39);
            this.lblAlumnos.TabIndex = 29;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // dgvEtapaDos
            // 
            this.dgvEtapaDos.AllowUserToAddRows = false;
            this.dgvEtapaDos.AllowUserToDeleteRows = false;
            this.dgvEtapaDos.AllowUserToOrderColumns = true;
            this.dgvEtapaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaDos.Location = new System.Drawing.Point(40, 424);
            this.dgvEtapaDos.Name = "dgvEtapaDos";
            this.dgvEtapaDos.ReadOnly = true;
            this.dgvEtapaDos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaDos.Size = new System.Drawing.Size(627, 235);
            this.dgvEtapaDos.TabIndex = 28;
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.AllowUserToOrderColumns = true;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaUno.Location = new System.Drawing.Point(40, 151);
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(627, 228);
            this.dgvEtapaUno.TabIndex = 27;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(690, 558);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(238, 101);
            this.btnContinuar.TabIndex = 31;
            this.btnContinuar.Text = "Registrar Cuota";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(685, 479);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(197, 29);
            this.lblNota.TabIndex = 33;
            this.lblNota.Text = "Ingrese una nota:";
            // 
            // lblTituloALumno
            // 
            this.lblTituloALumno.AutoSize = true;
            this.lblTituloALumno.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloALumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTituloALumno.ForeColor = System.Drawing.Color.White;
            this.lblTituloALumno.Location = new System.Drawing.Point(685, 294);
            this.lblTituloALumno.Name = "lblTituloALumno";
            this.lblTituloALumno.Size = new System.Drawing.Size(250, 29);
            this.lblTituloALumno.TabIndex = 34;
            this.lblTituloALumno.Text = "Alumno seleccionado:";
            // 
            // lvlVariableAlumno
            // 
            this.lvlVariableAlumno.AutoSize = true;
            this.lvlVariableAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lvlVariableAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lvlVariableAlumno.ForeColor = System.Drawing.Color.White;
            this.lvlVariableAlumno.Location = new System.Drawing.Point(684, 323);
            this.lvlVariableAlumno.Name = "lvlVariableAlumno";
            this.lvlVariableAlumno.Size = new System.Drawing.Size(230, 36);
            this.lvlVariableAlumno.TabIndex = 35;
            this.lvlVariableAlumno.Text = "Nombre Alumno";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(685, 391);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(233, 29);
            this.lblCurso.TabIndex = 36;
            this.lblCurso.Text = "Curso seleccionado:";
            // 
            // lblVariableCurso
            // 
            this.lblVariableCurso.AutoSize = true;
            this.lblVariableCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblVariableCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblVariableCurso.ForeColor = System.Drawing.Color.White;
            this.lblVariableCurso.Location = new System.Drawing.Point(684, 424);
            this.lblVariableCurso.Name = "lblVariableCurso";
            this.lblVariableCurso.Size = new System.Drawing.Size(208, 36);
            this.lblVariableCurso.TabIndex = 37;
            this.lblVariableCurso.Text = "Nombre Curso";
            // 
            // tbNota
            // 
            this.tbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbNota.Location = new System.Drawing.Point(690, 511);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(206, 32);
            this.tbNota.TabIndex = 38;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 703);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.lblVariableCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lvlVariableAlumno);
            this.Controls.Add(this.lblTituloALumno);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.dgvEtapaDos);
            this.Controls.Add(this.dgvEtapaUno);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.dgvEtapaDos, 0);
            this.Controls.SetChildIndex(this.lblAlumnos, 0);
            this.Controls.SetChildIndex(this.lblCursos, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.lblNota, 0);
            this.Controls.SetChildIndex(this.lblTituloALumno, 0);
            this.Controls.SetChildIndex(this.lvlVariableAlumno, 0);
            this.Controls.SetChildIndex(this.lblCurso, 0);
            this.Controls.SetChildIndex(this.lblVariableCurso, 0);
            this.Controls.SetChildIndex(this.tbNota, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.DataGridView dgvEtapaDos;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblVariableCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lvlVariableAlumno;
        private System.Windows.Forms.Label lblTituloALumno;
        private System.Windows.Forms.Label lblNota;
        private Controles.DecTextBox tbNota;
    }
}