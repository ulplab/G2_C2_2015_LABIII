﻿namespace CapaPresentacion
{
    partial class frmModificarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarAlumnos));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(329, 42);
            this.lblTitulo.Text = "Modificar Alumno";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(557, 79);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(371, 0);
            // 
            // pbLinea
            // 
            this.pbLinea.Size = new System.Drawing.Size(557, 10);
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
            this.btnMaximizar.Enabled = false;
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
            this.btnCerrar.Tag = "1";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(243, 438);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 35);
            this.tbEmail.TabIndex = 70;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(106, 444);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 29);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Email:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(243, 372);
            this.tbTelefono.MaxLength = 15;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(200, 35);
            this.tbTelefono.TabIndex = 69;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(106, 378);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(116, 29);
            this.lblTelefono.TabIndex = 74;
            this.lblTelefono.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(243, 306);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(200, 35);
            this.tbDireccion.TabIndex = 68;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(106, 312);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(121, 29);
            this.lblDireccion.TabIndex = 73;
            this.lblDireccion.Text = "Direccion:";
            // 
            // tbDni
            // 
            this.tbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDni.Location = new System.Drawing.Point(243, 240);
            this.tbDni.MaxLength = 8;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(200, 35);
            this.tbDni.TabIndex = 67;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(243, 174);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 35);
            this.tbApellido.TabIndex = 66;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(106, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(108, 29);
            this.lblApellido.TabIndex = 72;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(243, 108);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 35);
            this.tbNombre.TabIndex = 65;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(106, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(106, 246);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 29);
            this.lblDni.TabIndex = 79;
            this.lblDni.Text = "Dni:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(106, 507);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 29);
            this.lblEstado.TabIndex = 83;
            this.lblEstado.Text = "Estado:";
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.BackColor = System.Drawing.Color.Transparent;
            this.ckbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEstado.ForeColor = System.Drawing.Color.White;
            this.ckbEstado.Location = new System.Drawing.Point(243, 504);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(141, 33);
            this.ckbEstado.TabIndex = 82;
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
            this.btnGuardar.Location = new System.Drawing.Point(281, 588);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(191, 68);
            this.btnGuardar.TabIndex = 91;
            this.btnGuardar.Tag = "";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
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
            this.btnCancelar.Location = new System.Drawing.Point(84, 588);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 68);
            this.btnCancelar.TabIndex = 92;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Tag = "7";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // frmModificarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 694);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmModificarAlumnos";
            this.Text = "frmModificarAlumnos";
            this.Load += new System.EventHandler(this.frmModificarAlumnos_Load);
            this.Controls.SetChildIndex(this.pnlTitulo, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.tbApellido, 0);
            this.Controls.SetChildIndex(this.tbDni, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.tbDireccion, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.Controls.SetChildIndex(this.tbTelefono, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.ckbEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}