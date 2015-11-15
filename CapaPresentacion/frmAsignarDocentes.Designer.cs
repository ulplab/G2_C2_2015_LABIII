namespace CapaPresentacion
{
    partial class frmAsignarDocentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarDocentes));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFiltroDni = new Controles.NumTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltroApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.btnQuitarCursos = new System.Windows.Forms.Button();
            this.btnAgregarCursos = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(913, 94);
            this.ousEncabezado.Titulo = "Asignar Docentes";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.panel3);
            this.gbFiltros.Controls.Add(this.panel2);
            this.gbFiltros.Controls.Add(this.panel1);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.White;
            this.gbFiltros.Location = new System.Drawing.Point(52, 130);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(802, 117);
            this.gbFiltros.TabIndex = 86;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(599, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 66);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Tag = "6";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tbFiltroDni);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(392, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 66);
            this.panel3.TabIndex = 77;
            // 
            // tbFiltroDni
            // 
            this.tbFiltroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFiltroDni.Location = new System.Drawing.Point(10, 31);
            this.tbFiltroDni.MaxLength = 8;
            this.tbFiltroDni.Name = "tbFiltroDni";
            this.tbFiltroDni.Size = new System.Drawing.Size(150, 26);
            this.tbFiltroDni.TabIndex = 69;
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
            this.tbFiltroApellido.TabIndex = 68;
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
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(79, 565);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(280, 16);
            this.lblAyuda.TabIndex = 85;
            this.lblAyuda.Text = "Selecciona un docente para editar sus cursos";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToResizeColumns = false;
            this.dgvDocentes.AllowUserToResizeRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocentes.Location = new System.Drawing.Point(52, 268);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(802, 294);
            this.dgvDocentes.TabIndex = 84;
            this.dgvDocentes.TabStop = false;
            // 
            // btnQuitarCursos
            // 
            this.btnQuitarCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarCursos.FlatAppearance.BorderSize = 0;
            this.btnQuitarCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitarCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarCursos.Image")));
            this.btnQuitarCursos.Location = new System.Drawing.Point(492, 610);
            this.btnQuitarCursos.Name = "btnQuitarCursos";
            this.btnQuitarCursos.Size = new System.Drawing.Size(169, 66);
            this.btnQuitarCursos.TabIndex = 109;
            this.btnQuitarCursos.Tag = "6";
            this.btnQuitarCursos.UseVisualStyleBackColor = false;
            this.btnQuitarCursos.Click += new System.EventHandler(this.btnQuitarCursos_Click);
            this.btnQuitarCursos.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnQuitarCursos.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // btnAgregarCursos
            // 
            this.btnAgregarCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCursos.FlatAppearance.BorderSize = 0;
            this.btnAgregarCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCursos.Image")));
            this.btnAgregarCursos.Location = new System.Drawing.Point(651, 610);
            this.btnAgregarCursos.Name = "btnAgregarCursos";
            this.btnAgregarCursos.Size = new System.Drawing.Size(169, 66);
            this.btnAgregarCursos.TabIndex = 108;
            this.btnAgregarCursos.Tag = "6";
            this.btnAgregarCursos.UseVisualStyleBackColor = false;
            this.btnAgregarCursos.Click += new System.EventHandler(this.btnAgregarCursos_Click);
            this.btnAgregarCursos.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnAgregarCursos.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // frmAsignarDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 711);
            this.Controls.Add(this.btnQuitarCursos);
            this.Controls.Add(this.btnAgregarCursos);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.dgvDocentes);
            this.Name = "frmAsignarDocentes";
            this.Text = "frmAsignarProfesores";
            this.Load += new System.EventHandler(this.frmAsignarProfesores_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.dgvDocentes, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.Controls.SetChildIndex(this.btnAgregarCursos, 0);
            this.Controls.SetChildIndex(this.btnQuitarCursos, 0);
            this.gbFiltros.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel3;
        private Controles.NumTextBox tbFiltroDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltroApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiltroNombre;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnQuitarCursos;
        private System.Windows.Forms.Button btnAgregarCursos;
    }
}