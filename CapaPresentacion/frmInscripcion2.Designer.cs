﻿namespace CapaPresentacion
{
    partial class frmInscripcion2
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cbParametros = new System.Windows.Forms.CheckBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdTelefono = new System.Windows.Forms.RadioButton();
            this.rdDireccion = new System.Windows.Forms.RadioButton();
            this.rdDNI = new System.Windows.Forms.RadioButton();
            this.rdApellido = new System.Windows.Forms.RadioButton();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(1193, 79);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(1007, 0);
            // 
            // pbLinea
            // 
            this.pbLinea.Size = new System.Drawing.Size(1193, 10);
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(494, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 38);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbBuscar.Location = new System.Drawing.Point(39, 92);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(459, 38);
            this.tbBuscar.TabIndex = 49;
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaUno.Location = new System.Drawing.Point(39, 183);
            this.dgvEtapaUno.MultiSelect = false;
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapaUno.Size = new System.Drawing.Size(1130, 358);
            this.dgvEtapaUno.TabIndex = 48;
            this.dgvEtapaUno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_RowEnter);
            this.dgvEtapaUno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapaUno_RowEnter);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(902, 547);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(267, 73);
            this.btnContinuar.TabIndex = 47;
            this.btnContinuar.Text = "Inscribir";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // cbParametros
            // 
            this.cbParametros.AutoSize = true;
            this.cbParametros.BackColor = System.Drawing.Color.Transparent;
            this.cbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametros.ForeColor = System.Drawing.Color.White;
            this.cbParametros.Location = new System.Drawing.Point(658, 92);
            this.cbParametros.Name = "cbParametros";
            this.cbParametros.Size = new System.Drawing.Size(124, 28);
            this.cbParametros.TabIndex = 52;
            this.cbParametros.Text = "Parametros";
            this.cbParametros.UseVisualStyleBackColor = false;
            this.cbParametros.CheckedChanged += new System.EventHandler(this.cbParametros_CheckedChanged);
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
            this.pnlBusqueda.Location = new System.Drawing.Point(39, 136);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(937, 41);
            this.pnlBusqueda.TabIndex = 51;
            this.pnlBusqueda.Visible = false;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.BackColor = System.Drawing.Color.Transparent;
            this.rdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdEmail.ForeColor = System.Drawing.Color.White;
            this.rdEmail.Location = new System.Drawing.Point(842, 5);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(92, 33);
            this.rdEmail.TabIndex = 33;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = false;
            this.rdEmail.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // rdTelefono
            // 
            this.rdTelefono.AutoSize = true;
            this.rdTelefono.BackColor = System.Drawing.Color.Transparent;
            this.rdTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rdTelefono.ForeColor = System.Drawing.Color.White;
            this.rdTelefono.Location = new System.Drawing.Point(658, 5);
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
            this.rdDireccion.Location = new System.Drawing.Point(480, 5);
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
            this.rdDNI.Location = new System.Drawing.Point(338, 3);
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
            this.rdApellido.Location = new System.Drawing.Point(167, 3);
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
            this.rdNombre.Location = new System.Drawing.Point(17, 3);
            this.rdNombre.Name = "rdNombre";
            this.rdNombre.Size = new System.Drawing.Size(119, 33);
            this.rdNombre.TabIndex = 24;
            this.rdNombre.TabStop = true;
            this.rdNombre.Text = "Nombre";
            this.rdNombre.UseVisualStyleBackColor = false;
            this.rdNombre.CheckedChanged += new System.EventHandler(this.rdNombre_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(39, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(267, 73);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInscripcion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 635);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbParametros);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.dgvEtapaUno);
            this.Controls.Add(this.btnContinuar);
            this.Name = "frmInscripcion2";
            this.Text = "frmInscripcion2";
            this.Load += new System.EventHandler(this.frmInscripcion2_Load);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.pnlTitulo, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.cbParametros, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.CheckBox cbParametros;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdTelefono;
        private System.Windows.Forms.RadioButton rdDireccion;
        private System.Windows.Forms.RadioButton rdDNI;
        private System.Windows.Forms.RadioButton rdApellido;
        private System.Windows.Forms.RadioButton rdNombre;
        private System.Windows.Forms.Button btnCancelar;
    }
}