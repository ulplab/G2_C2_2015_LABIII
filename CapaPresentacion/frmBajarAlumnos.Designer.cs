﻿namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rdCursos = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.rdAlumnos = new System.Windows.Forms.RadioButton();
            this.rdTelefono = new System.Windows.Forms.RadioButton();
            this.rdDireccion = new System.Windows.Forms.RadioButton();
            this.rdDNI = new System.Windows.Forms.RadioButton();
            this.rdApellido = new System.Windows.Forms.RadioButton();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.cbParametros = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1115, 96);
            this.ousEncabezado.Titulo = "Dar baja alumnos";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(698, 617);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(192, 78);
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
            this.btnBuscar.Location = new System.Drawing.Point(681, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 38);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rdCursos
            // 
            this.rdCursos.AutoSize = true;
            this.rdCursos.BackColor = System.Drawing.Color.Transparent;
            this.rdCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdCursos.ForeColor = System.Drawing.Color.White;
            this.rdCursos.Location = new System.Drawing.Point(61, 183);
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
            this.tbBuscar.Location = new System.Drawing.Point(216, 123);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(459, 38);
            this.tbBuscar.TabIndex = 41;
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            // 
            // rdAlumnos
            // 
            this.rdAlumnos.AutoSize = true;
            this.rdAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.rdAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdAlumnos.ForeColor = System.Drawing.Color.White;
            this.rdAlumnos.Location = new System.Drawing.Point(61, 127);
            this.rdAlumnos.Name = "rdAlumnos";
            this.rdAlumnos.Size = new System.Drawing.Size(124, 33);
            this.rdAlumnos.TabIndex = 38;
            this.rdAlumnos.TabStop = true;
            this.rdAlumnos.Text = "Alumnos";
            this.rdAlumnos.UseVisualStyleBackColor = false;
            this.rdAlumnos.CheckedChanged += new System.EventHandler(this.rdAlumnos_CheckedChanged);
            // 
            // rdTelefono
            // 
            this.rdTelefono.AutoSize = true;
            this.rdTelefono.BackColor = System.Drawing.Color.Transparent;
            this.rdTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdTelefono.ForeColor = System.Drawing.Color.White;
            this.rdTelefono.Location = new System.Drawing.Point(586, 5);
            this.rdTelefono.Name = "rdTelefono";
            this.rdTelefono.Size = new System.Drawing.Size(128, 33);
            this.rdTelefono.TabIndex = 32;
            this.rdTelefono.TabStop = true;
            this.rdTelefono.Text = "Telefono";
            this.rdTelefono.UseVisualStyleBackColor = false;
            this.rdTelefono.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdDireccion
            // 
            this.rdDireccion.AutoSize = true;
            this.rdDireccion.BackColor = System.Drawing.Color.Transparent;
            this.rdDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDireccion.ForeColor = System.Drawing.Color.White;
            this.rdDireccion.Location = new System.Drawing.Point(437, 3);
            this.rdDireccion.Name = "rdDireccion";
            this.rdDireccion.Size = new System.Drawing.Size(133, 33);
            this.rdDireccion.TabIndex = 31;
            this.rdDireccion.TabStop = true;
            this.rdDireccion.Text = "Direccion";
            this.rdDireccion.UseVisualStyleBackColor = false;
            this.rdDireccion.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdDNI
            // 
            this.rdDNI.AutoSize = true;
            this.rdDNI.BackColor = System.Drawing.Color.Transparent;
            this.rdDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdDNI.ForeColor = System.Drawing.Color.White;
            this.rdDNI.Location = new System.Drawing.Point(311, 5);
            this.rdDNI.Name = "rdDNI";
            this.rdDNI.Size = new System.Drawing.Size(72, 33);
            this.rdDNI.TabIndex = 30;
            this.rdDNI.TabStop = true;
            this.rdDNI.Text = "DNI";
            this.rdDNI.UseVisualStyleBackColor = false;
            this.rdDNI.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
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
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusqueda.Controls.Add(this.rdEmail);
            this.pnlBusqueda.Controls.Add(this.rdTelefono);
            this.pnlBusqueda.Controls.Add(this.rdDireccion);
            this.pnlBusqueda.Controls.Add(this.rdDNI);
            this.pnlBusqueda.Controls.Add(this.rdApellido);
            this.pnlBusqueda.Controls.Add(this.rdNombre);
            this.pnlBusqueda.Location = new System.Drawing.Point(211, 175);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(834, 41);
            this.pnlBusqueda.TabIndex = 43;
            this.pnlBusqueda.Visible = false;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.BackColor = System.Drawing.Color.Transparent;
            this.rdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdEmail.ForeColor = System.Drawing.Color.White;
            this.rdEmail.Location = new System.Drawing.Point(730, 3);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(92, 33);
            this.rdEmail.TabIndex = 33;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = false;
            this.rdEmail.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // cbParametros
            // 
            this.cbParametros.AutoSize = true;
            this.cbParametros.BackColor = System.Drawing.Color.Transparent;
            this.cbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametros.ForeColor = System.Drawing.Color.White;
            this.cbParametros.Location = new System.Drawing.Point(872, 134);
            this.cbParametros.Name = "cbParametros";
            this.cbParametros.Size = new System.Drawing.Size(124, 28);
            this.cbParametros.TabIndex = 44;
            this.cbParametros.Text = "Parametros";
            this.cbParametros.UseVisualStyleBackColor = false;
            this.cbParametros.CheckedChanged += new System.EventHandler(this.cbParametros_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(189, 617);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 78);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtapaUno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtapaUno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEtapaUno.Location = new System.Drawing.Point(61, 288);
            this.dgvEtapaUno.MultiSelect = false;
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.RowHeadersVisible = false;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(935, 274);
            this.dgvEtapaUno.TabIndex = 46;
            this.dgvEtapaUno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_RowEnter);
            this.dgvEtapaUno.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_RowLeave);
            this.dgvEtapaUno.DoubleClick += new System.EventHandler(this.dgvEtapaUno_DoubleClick);
            // 
            // frmBajarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 766);
            this.Controls.Add(this.dgvEtapaUno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.cbParametros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rdCursos);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.rdAlumnos);
            this.Controls.Add(this.btnContinuar);
            this.Name = "frmBajarAlumnos";
            this.Text = "frmBajarAlumnos";
            this.Load += new System.EventHandler(this.frmBajarAlumnos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.rdAlumnos, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.rdCursos, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.cbParametros, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdTelefono;
        private System.Windows.Forms.RadioButton rdDireccion;
        private System.Windows.Forms.RadioButton rdDNI;
        private System.Windows.Forms.RadioButton rdApellido;
        private System.Windows.Forms.RadioButton rdNombre;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.CheckBox cbParametros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
    }
}