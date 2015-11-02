namespace CapaPresentacion
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCuenta = new System.Windows.Forms.GroupBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tbDni = new Controles.NumTextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.gbCuenta.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(884, 93);
            this.ousEncabezado.Titulo = "Modificar Alumnos";
            this.ousEncabezado.Load += new System.EventHandler(this.ousEncabezado_Load);
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
            this.btnGuardar.Location = new System.Drawing.Point(571, 605);
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
            this.btnCancelar.Location = new System.Drawing.Point(123, 605);
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
            // gbCuenta
            // 
            this.gbCuenta.BackColor = System.Drawing.Color.Transparent;
            this.gbCuenta.Controls.Add(this.tbUsuario);
            this.gbCuenta.Controls.Add(this.lblUsuario);
            this.gbCuenta.Controls.Add(this.tbContraseña);
            this.gbCuenta.Controls.Add(this.lblContraseña);
            this.gbCuenta.Controls.Add(this.ckbEstado);
            this.gbCuenta.Controls.Add(this.lblEstado);
            this.gbCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCuenta.ForeColor = System.Drawing.Color.White;
            this.gbCuenta.Location = new System.Drawing.Point(66, 407);
            this.gbCuenta.Name = "gbCuenta";
            this.gbCuenta.Size = new System.Drawing.Size(751, 182);
            this.gbCuenta.TabIndex = 105;
            this.gbCuenta.TabStop = false;
            this.gbCuenta.Text = "Datos de la cuenta";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(127, 53);
            this.tbUsuario.MaxLength = 8;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(200, 35);
            this.tbUsuario.TabIndex = 102;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(19, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 29);
            this.lblUsuario.TabIndex = 103;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(534, 53);
            this.tbContraseña.MaxLength = 10;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(200, 35);
            this.tbContraseña.TabIndex = 100;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(386, 59);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(142, 29);
            this.lblContraseña.TabIndex = 101;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.BackColor = System.Drawing.Color.Transparent;
            this.ckbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEstado.ForeColor = System.Drawing.Color.White;
            this.ckbEstado.Location = new System.Drawing.Point(534, 117);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(141, 33);
            this.ckbEstado.TabIndex = 96;
            this.ckbEstado.TabStop = false;
            this.ckbEstado.Text = "Habilitado";
            this.ckbEstado.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(386, 117);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 29);
            this.lblEstado.TabIndex = 97;
            this.lblEstado.Text = "Estado:";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.tbDni);
            this.gbDatos.Controls.Add(this.tbApellido);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.lblDni);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.lblEmail);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.tbDireccion);
            this.gbDatos.Controls.Add(this.tbEmail);
            this.gbDatos.Controls.Add(this.tbTelefono);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.White;
            this.gbDatos.Location = new System.Drawing.Point(66, 120);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(751, 267);
            this.gbDatos.TabIndex = 104;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Personales Alumno";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(156, 191);
            this.tbDni.MaxLength = 8;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(200, 35);
            this.tbDni.TabIndex = 97;
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(156, 127);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 35);
            this.tbApellido.TabIndex = 85;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(34, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 90;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(156, 63);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 35);
            this.tbNombre.TabIndex = 84;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(34, 130);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(108, 29);
            this.lblApellido.TabIndex = 91;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(34, 194);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 29);
            this.lblDni.TabIndex = 95;
            this.lblDni.Text = "Dni:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(391, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(116, 29);
            this.lblTelefono.TabIndex = 93;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(391, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 29);
            this.lblEmail.TabIndex = 94;
            this.lblEmail.Text = "Email:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(386, 66);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(121, 29);
            this.lblDireccion.TabIndex = 92;
            this.lblDireccion.Text = "Direccion:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(527, 60);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(200, 35);
            this.tbDireccion.TabIndex = 87;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(527, 188);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 35);
            this.tbEmail.TabIndex = 89;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(527, 124);
            this.tbTelefono.MaxLength = 15;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(200, 35);
            this.tbTelefono.TabIndex = 88;
            // 
            // frmModificarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 719);
            this.Controls.Add(this.gbCuenta);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmModificarAlumnos";
            this.Text = "frmModificarAlumnos";
            this.Load += new System.EventHandler(this.frmModificarAlumnos_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.Controls.SetChildIndex(this.gbCuenta, 0);
            this.gbCuenta.ResumeLayout(false);
            this.gbCuenta.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbCuenta;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private Controles.NumTextBox tbDni;
    }
}