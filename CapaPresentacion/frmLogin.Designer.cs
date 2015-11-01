namespace CapaPresentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.cbNivelSeguridad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(264, 58);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(48, 48);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(318, 58);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(48, 48);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(52, 185);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(230, 35);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "User";
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContraseña_KeyPress);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(52, 290);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(230, 35);
            this.tbContraseña.TabIndex = 1;
            this.tbContraseña.Text = "Contraseña";
            this.tbContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContraseña_KeyPress);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(241, 434);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(125, 37);
            this.btnEntrar.TabIndex = 16;
            this.btnEntrar.TabStop = false;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            // 
            // cbNivelSeguridad
            // 
            this.cbNivelSeguridad.BackColor = System.Drawing.Color.White;
            this.cbNivelSeguridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNivelSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelSeguridad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbNivelSeguridad.FormattingEnabled = true;
            this.cbNivelSeguridad.Location = new System.Drawing.Point(115, 68);
            this.cbNivelSeguridad.Name = "cbNivelSeguridad";
            this.cbNivelSeguridad.Size = new System.Drawing.Size(136, 28);
            this.cbNivelSeguridad.TabIndex = 17;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(380, 548);
            this.Controls.Add(this.cbNivelSeguridad);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ComboBox cbNivelSeguridad;
    }
}