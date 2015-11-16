namespace CapaPresentacion
{
    partial class frmAlumnosMorosos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnosMorosos));
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chbParamAlumnos = new System.Windows.Forms.CheckBox();
            this.pnlBusquedaAlumnos = new System.Windows.Forms.Panel();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdTelefono = new System.Windows.Forms.RadioButton();
            this.rdDireccion = new System.Windows.Forms.RadioButton();
            this.rdDni = new System.Windows.Forms.RadioButton();
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
            this.ousEncabezado.Size = new System.Drawing.Size(808, 94);
            this.ousEncabezado.Titulo = "Alumnos Morosos";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Black;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(580, 678);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(205, 62);
            this.btnGenerarReporte.TabIndex = 26;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
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
            this.dgvEtapaUno.Location = new System.Drawing.Point(47, 269);
            this.dgvEtapaUno.MultiSelect = false;
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.RowHeadersVisible = false;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(738, 403);
            this.dgvEtapaUno.TabIndex = 68;
            this.dgvEtapaUno.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 29);
            this.label2.TabIndex = 73;
            this.label2.Text = "Filtrar en los alumnos morosos";
            // 
            // chbParamAlumnos
            // 
            this.chbParamAlumnos.AutoSize = true;
            this.chbParamAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.chbParamAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParamAlumnos.ForeColor = System.Drawing.Color.White;
            this.chbParamAlumnos.Location = new System.Drawing.Point(407, 174);
            this.chbParamAlumnos.Name = "chbParamAlumnos";
            this.chbParamAlumnos.Size = new System.Drawing.Size(124, 28);
            this.chbParamAlumnos.TabIndex = 72;
            this.chbParamAlumnos.Text = "Parametros";
            this.chbParamAlumnos.UseVisualStyleBackColor = false;
            this.chbParamAlumnos.CheckedChanged += new System.EventHandler(this.chbParamAlumnos_CheckedChanged);
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
            this.pnlBusquedaAlumnos.Location = new System.Drawing.Point(44, 208);
            this.pnlBusquedaAlumnos.Name = "pnlBusquedaAlumnos";
            this.pnlBusquedaAlumnos.Size = new System.Drawing.Size(354, 55);
            this.pnlBusquedaAlumnos.TabIndex = 71;
            this.pnlBusquedaAlumnos.Visible = false;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.BackColor = System.Drawing.Color.Transparent;
            this.rdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdEmail.ForeColor = System.Drawing.Color.White;
            this.rdEmail.Location = new System.Drawing.Point(502, 5);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(92, 33);
            this.rdEmail.TabIndex = 33;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = false;
            this.rdEmail.Visible = false;
            // 
            // rdTelefono
            // 
            this.rdTelefono.AutoSize = true;
            this.rdTelefono.BackColor = System.Drawing.Color.Transparent;
            this.rdTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdTelefono.ForeColor = System.Drawing.Color.White;
            this.rdTelefono.Location = new System.Drawing.Point(600, 5);
            this.rdTelefono.Name = "rdTelefono";
            this.rdTelefono.Size = new System.Drawing.Size(128, 33);
            this.rdTelefono.TabIndex = 32;
            this.rdTelefono.TabStop = true;
            this.rdTelefono.Text = "Telefono";
            this.rdTelefono.UseVisualStyleBackColor = false;
            this.rdTelefono.Visible = false;
            // 
            // rdDireccion
            // 
            this.rdDireccion.AutoSize = true;
            this.rdDireccion.BackColor = System.Drawing.Color.Transparent;
            this.rdDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDireccion.ForeColor = System.Drawing.Color.White;
            this.rdDireccion.Location = new System.Drawing.Point(354, 5);
            this.rdDireccion.Name = "rdDireccion";
            this.rdDireccion.Size = new System.Drawing.Size(133, 33);
            this.rdDireccion.TabIndex = 31;
            this.rdDireccion.TabStop = true;
            this.rdDireccion.Text = "Direccion";
            this.rdDireccion.UseVisualStyleBackColor = false;
            this.rdDireccion.Visible = false;
            // 
            // rdDni
            // 
            this.rdDni.AutoSize = true;
            this.rdDni.BackColor = System.Drawing.Color.Transparent;
            this.rdDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDni.ForeColor = System.Drawing.Color.White;
            this.rdDni.Location = new System.Drawing.Point(275, 5);
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
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscar.Location = new System.Drawing.Point(44, 130);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(354, 38);
            this.tbBuscar.TabIndex = 69;
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
            this.btnBuscar.Location = new System.Drawing.Point(391, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 66);
            this.btnBuscar.TabIndex = 84;
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
            this.label1.Location = new System.Drawing.Point(575, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 85;
            this.label1.Text = "Alumnos y deudas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAlumnosMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbParamAlumnos);
            this.Controls.Add(this.pnlBusquedaAlumnos);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.dgvEtapaUno);
            this.Controls.Add(this.btnGenerarReporte);
            this.Name = "frmAlumnosMorosos";
            this.Text = "frmAlumnosMorosos";
            this.Load += new System.EventHandler(this.frmAlumnosMorosos_Load);
            this.Controls.SetChildIndex(this.btnGenerarReporte, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.pnlBusquedaAlumnos, 0);
            this.Controls.SetChildIndex(this.chbParamAlumnos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.pnlBusquedaAlumnos.ResumeLayout(false);
            this.pnlBusquedaAlumnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbParamAlumnos;
        private System.Windows.Forms.Panel pnlBusquedaAlumnos;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdTelefono;
        private System.Windows.Forms.RadioButton rdDireccion;
        private System.Windows.Forms.RadioButton rdDni;
        private System.Windows.Forms.RadioButton rdApellido;
        private System.Windows.Forms.RadioButton rdNombre;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
    }
}