namespace CapaPresentacion
{
    partial class frmRegistroCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCalificaciones));
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chbParamAlumnos = new System.Windows.Forms.CheckBox();
            this.pnlBusquedaAlumnos = new System.Windows.Forms.Panel();
            this.rdFecha = new System.Windows.Forms.RadioButton();
            this.rdCurso = new System.Windows.Forms.RadioButton();
            this.rdApellido = new System.Windows.Forms.RadioButton();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.pnlBusquedaAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1033, 93);
            this.ousEncabezado.Titulo = "Registro Calificaciones";
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.AllowUserToResizeColumns = false;
            this.dgvEtapaUno.AllowUserToResizeRows = false;
            this.dgvEtapaUno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtapaUno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtapaUno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEtapaUno.Location = new System.Drawing.Point(59, 228);
            this.dgvEtapaUno.MultiSelect = false;
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.RowHeadersVisible = false;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(922, 267);
            this.dgvEtapaUno.TabIndex = 67;
            this.dgvEtapaUno.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 72;
            this.label2.Text = "Filtrar en los alumnos";
            // 
            // chbParamAlumnos
            // 
            this.chbParamAlumnos.AutoSize = true;
            this.chbParamAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.chbParamAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParamAlumnos.ForeColor = System.Drawing.Color.White;
            this.chbParamAlumnos.Location = new System.Drawing.Point(571, 144);
            this.chbParamAlumnos.Name = "chbParamAlumnos";
            this.chbParamAlumnos.Size = new System.Drawing.Size(124, 28);
            this.chbParamAlumnos.TabIndex = 71;
            this.chbParamAlumnos.Text = "Parametros";
            this.chbParamAlumnos.UseVisualStyleBackColor = false;
            this.chbParamAlumnos.CheckedChanged += new System.EventHandler(this.chbParamAlumnos_CheckedChanged);
            // 
            // pnlBusquedaAlumnos
            // 
            this.pnlBusquedaAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaAlumnos.Controls.Add(this.rdFecha);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdCurso);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdApellido);
            this.pnlBusquedaAlumnos.Controls.Add(this.rdNombre);
            this.pnlBusquedaAlumnos.Location = new System.Drawing.Point(59, 178);
            this.pnlBusquedaAlumnos.Name = "pnlBusquedaAlumnos";
            this.pnlBusquedaAlumnos.Size = new System.Drawing.Size(475, 44);
            this.pnlBusquedaAlumnos.TabIndex = 70;
            this.pnlBusquedaAlumnos.Visible = false;
            // 
            // rdFecha
            // 
            this.rdFecha.AutoSize = true;
            this.rdFecha.BackColor = System.Drawing.Color.Transparent;
            this.rdFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdFecha.ForeColor = System.Drawing.Color.White;
            this.rdFecha.Location = new System.Drawing.Point(376, 3);
            this.rdFecha.Name = "rdFecha";
            this.rdFecha.Size = new System.Drawing.Size(98, 33);
            this.rdFecha.TabIndex = 32;
            this.rdFecha.TabStop = true;
            this.rdFecha.Text = "Fecha";
            this.rdFecha.UseVisualStyleBackColor = false;
            this.rdFecha.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdCurso
            // 
            this.rdCurso.AutoSize = true;
            this.rdCurso.BackColor = System.Drawing.Color.Transparent;
            this.rdCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdCurso.ForeColor = System.Drawing.Color.White;
            this.rdCurso.Location = new System.Drawing.Point(275, 5);
            this.rdCurso.Name = "rdCurso";
            this.rdCurso.Size = new System.Drawing.Size(95, 33);
            this.rdCurso.TabIndex = 30;
            this.rdCurso.TabStop = true;
            this.rdCurso.Text = "Curso";
            this.rdCurso.UseVisualStyleBackColor = false;
            this.rdCurso.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
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
            this.rdNombre.Location = new System.Drawing.Point(24, 3);
            this.rdNombre.Name = "rdNombre";
            this.rdNombre.Size = new System.Drawing.Size(119, 33);
            this.rdNombre.TabIndex = 24;
            this.rdNombre.TabStop = true;
            this.rdNombre.Text = "Nombre";
            this.rdNombre.UseVisualStyleBackColor = false;
            this.rdNombre.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscar.Location = new System.Drawing.Point(59, 134);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(354, 38);
            this.tbBuscar.TabIndex = 68;
            this.tbBuscar.Text = "Nombre";
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
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
            this.btnBuscar.Location = new System.Drawing.Point(419, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 52);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Tag = "6";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(818, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 86;
            this.label1.Text = "Calificaciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRegistroCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbParamAlumnos);
            this.Controls.Add(this.pnlBusquedaAlumnos);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.dgvEtapaUno);
            this.Name = "frmRegistroCalificaciones";
            this.Text = "frmRegistroCalificaciones";
            this.Load += new System.EventHandler(this.frmRegistroCalificaciones_Load);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.pnlBusquedaAlumnos, 0);
            this.Controls.SetChildIndex(this.chbParamAlumnos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.pnlBusquedaAlumnos.ResumeLayout(false);
            this.pnlBusquedaAlumnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbParamAlumnos;
        private System.Windows.Forms.Panel pnlBusquedaAlumnos;
        private System.Windows.Forms.RadioButton rdApellido;
        private System.Windows.Forms.RadioButton rdNombre;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdFecha;
        private System.Windows.Forms.RadioButton rdCurso;
    }
}