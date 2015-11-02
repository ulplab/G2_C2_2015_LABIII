namespace CapaPresentacion
{
    partial class frmModificarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCursos));
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIncio = new System.Windows.Forms.DateTimePicker();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaIncio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tbValorCurso = new Controles.DecTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(665, 90);
            this.ousEncabezado.Titulo = "Modificar Cursos";
            this.ousEncabezado.Load += new System.EventHandler(this.ousEncabezado_Load);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(191, 253);
            this.dtpFechaFin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(272, 35);
            this.dtpFechaFin.TabIndex = 83;
            // 
            // dtpFechaIncio
            // 
            this.dtpFechaIncio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFechaIncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIncio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIncio.Location = new System.Drawing.Point(191, 188);
            this.dtpFechaIncio.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFechaIncio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIncio.Name = "dtpFechaIncio";
            this.dtpFechaIncio.Size = new System.Drawing.Size(271, 35);
            this.dtpFechaIncio.TabIndex = 82;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(191, 114);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(271, 35);
            this.tbDescripcion.TabIndex = 81;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblDescripcion.TabIndex = 87;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(23, 259);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(126, 29);
            this.lblFechaFin.TabIndex = 86;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaIncio
            // 
            this.lblFechaIncio.AutoSize = true;
            this.lblFechaIncio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIncio.ForeColor = System.Drawing.Color.White;
            this.lblFechaIncio.Location = new System.Drawing.Point(27, 194);
            this.lblFechaIncio.Name = "lblFechaIncio";
            this.lblFechaIncio.Size = new System.Drawing.Size(143, 29);
            this.lblFechaIncio.TabIndex = 85;
            this.lblFechaIncio.Text = "Fecha Incio:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(191, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(272, 35);
            this.tbNombre.TabIndex = 80;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(23, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 84;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(168, 345);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 29);
            this.lblEstado.TabIndex = 92;
            this.lblEstado.Text = "Estado:";
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.BackColor = System.Drawing.Color.Transparent;
            this.ckbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEstado.ForeColor = System.Drawing.Color.White;
            this.ckbEstado.Location = new System.Drawing.Point(339, 341);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(141, 33);
            this.ckbEstado.TabIndex = 91;
            this.ckbEstado.TabStop = false;
            this.ckbEstado.Text = "Habilitado";
            this.ckbEstado.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(330, 607);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(191, 68);
            this.btnGuardar.TabIndex = 89;
            this.btnGuardar.Tag = "";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(101, 607);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 68);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Tag = "7";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.tbValorCurso);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.tbDescripcion);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.ckbEstado);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Controls.Add(this.dtpFechaFin);
            this.gbDatos.Controls.Add(this.lblFechaIncio);
            this.gbDatos.Controls.Add(this.dtpFechaIncio);
            this.gbDatos.Controls.Add(this.lblFechaFin);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.White;
            this.gbDatos.Location = new System.Drawing.Point(83, 121);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(497, 466);
            this.gbDatos.TabIndex = 103;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Curso";
            // 
            // tbValorCurso
            // 
            this.tbValorCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbValorCurso.Location = new System.Drawing.Point(358, 394);
            this.tbValorCurso.MaxLength = 8;
            this.tbValorCurso.Name = "tbValorCurso";
            this.tbValorCurso.Size = new System.Drawing.Size(104, 35);
            this.tbValorCurso.TabIndex = 94;
            this.tbValorCurso.Text = "00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 93;
            this.label5.Text = "Valor Curso $:";
            // 
            // frmModificarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 687);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmModificarCursos";
            this.Text = "frmModificarCursos";
            this.Load += new System.EventHandler(this.frmModificarCursos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIncio;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaIncio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbDatos;
        private Controles.DecTextBox tbValorCurso;
        private System.Windows.Forms.Label label5;
    }
}