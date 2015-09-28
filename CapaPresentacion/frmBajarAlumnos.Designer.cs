namespace CapaPresentacion
{
    partial class frmBajarAlumnos
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rdCursos = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.rdAlumnos = new System.Windows.Forms.RadioButton();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(837, 42);
            this.lblTitulo.Text = "Seleccione un Alumno o Curso para continuar";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(1225, 79);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(1039, 0);
            // 
            // pbLinea
            // 
            this.pbLinea.Size = new System.Drawing.Size(1225, 10);
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
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(922, 592);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(267, 73);
            this.btnContinuar.TabIndex = 23;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(525, 187);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 38);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // rdCursos
            // 
            this.rdCursos.AutoSize = true;
            this.rdCursos.BackColor = System.Drawing.Color.Transparent;
            this.rdCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdCursos.ForeColor = System.Drawing.Color.White;
            this.rdCursos.Location = new System.Drawing.Point(300, 127);
            this.rdCursos.Name = "rdCursos";
            this.rdCursos.Size = new System.Drawing.Size(107, 33);
            this.rdCursos.TabIndex = 39;
            this.rdCursos.TabStop = true;
            this.rdCursos.Text = "Cursos";
            this.rdCursos.UseVisualStyleBackColor = false;
            this.rdCursos.CheckedChanged += new System.EventHandler(this.rdCursos_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscar.Location = new System.Drawing.Point(60, 186);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(459, 38);
            this.tbBuscar.TabIndex = 41;
            // 
            // rdAlumnos
            // 
            this.rdAlumnos.AutoSize = true;
            this.rdAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.rdAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdAlumnos.ForeColor = System.Drawing.Color.White;
            this.rdAlumnos.Location = new System.Drawing.Point(60, 127);
            this.rdAlumnos.Name = "rdAlumnos";
            this.rdAlumnos.Size = new System.Drawing.Size(124, 33);
            this.rdAlumnos.TabIndex = 38;
            this.rdAlumnos.TabStop = true;
            this.rdAlumnos.Text = "Alumnos";
            this.rdAlumnos.UseVisualStyleBackColor = false;
            this.rdAlumnos.CheckedChanged += new System.EventHandler(this.rdAlumnos_CheckedChanged);
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaUno.Location = new System.Drawing.Point(61, 230);
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(1130, 356);
            this.dgvEtapaUno.TabIndex = 40;
            this.dgvEtapaUno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapa1_RowEnter);
            this.dgvEtapaUno.DoubleClick += new System.EventHandler(this.dgvEtapaUno_DoubleClick);
            // 
            // frmBajarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 677);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rdCursos);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.rdAlumnos);
            this.Controls.Add(this.dgvEtapaUno);
            this.Controls.Add(this.btnContinuar);
            this.Name = "frmBajarAlumnos";
            this.Text = "frmBajarAlumnos";
            this.Load += new System.EventHandler(this.frmBajarAlumnos_Load);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.pnlTitulo, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.rdAlumnos, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.rdCursos, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rdCursos;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.RadioButton rdAlumnos;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
    }
}