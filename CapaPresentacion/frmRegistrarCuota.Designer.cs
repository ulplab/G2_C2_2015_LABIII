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
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.dgvEtapaDos = new System.Windows.Forms.DataGridView();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblCursos = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cachedcrReciboCobroMatricula1 = new CapaPresentacion.Reportes.CachedcrReciboCobroMatricula();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1090, 94);
            this.ousEncabezado.Titulo = "Cuotas";
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.AllowUserToOrderColumns = true;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaUno.Location = new System.Drawing.Point(28, 153);
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(678, 228);
            this.dgvEtapaUno.TabIndex = 23;
            this.dgvEtapaUno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_RowEnter);
            // 
            // dgvEtapaDos
            // 
            this.dgvEtapaDos.AllowUserToAddRows = false;
            this.dgvEtapaDos.AllowUserToDeleteRows = false;
            this.dgvEtapaDos.AllowUserToOrderColumns = true;
            this.dgvEtapaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaDos.Location = new System.Drawing.Point(28, 426);
            this.dgvEtapaDos.Name = "dgvEtapaDos";
            this.dgvEtapaDos.ReadOnly = true;
            this.dgvEtapaDos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaDos.Size = new System.Drawing.Size(678, 235);
            this.dgvEtapaDos.TabIndex = 24;
            this.dgvEtapaDos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvetapa2_RowEnter);
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
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(21, 384);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(271, 39);
            this.lblCursos.TabIndex = 26;
            this.lblCursos.Text = "Cursos Morosos";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(729, 585);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(318, 76);
            this.btnContinuar.TabIndex = 27;
            this.btnContinuar.Text = "Registrar Cuota";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmRegistrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 693);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.dgvEtapaDos);
            this.Controls.Add(this.dgvEtapaUno);
            this.Name = "frmRegistrarCuota";
            this.Text = "frmRegistrarCuota";
            this.Load += new System.EventHandler(this.frmRegistrarCuota_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.dgvEtapaDos, 0);
            this.Controls.SetChildIndex(this.lblAlumnos, 0);
            this.Controls.SetChildIndex(this.lblCursos, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.DataGridView dgvEtapaDos;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnContinuar;
        private Reportes.CachedcrReciboCobroMatricula cachedcrReciboCobroMatricula1;
    }
}