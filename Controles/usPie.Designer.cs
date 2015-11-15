namespace Controles
{
    partial class usPie
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTituloHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblTituloTiempo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.lblSeparadorMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblSeparadorHoras = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloHora
            // 
            this.lblTituloHora.AutoSize = true;
            this.lblTituloHora.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHora.ForeColor = System.Drawing.Color.Black;
            this.lblTituloHora.Location = new System.Drawing.Point(12, 5);
            this.lblTituloHora.Name = "lblTituloHora";
            this.lblTituloHora.Size = new System.Drawing.Size(50, 18);
            this.lblTituloHora.TabIndex = 2;
            this.lblTituloHora.Text = "Hora :";
            this.lblTituloHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblTituloHora);
            this.panel2.Location = new System.Drawing.Point(190, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 27);
            this.panel2.TabIndex = 9;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(59, 5);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(93, 18);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "-----------------";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.lblTituloUsuario);
            this.panel3.Location = new System.Drawing.Point(363, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 27);
            this.panel3.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(85, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "---------------";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTituloUsuario.Location = new System.Drawing.Point(12, 5);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(67, 18);
            this.lblTituloUsuario.TabIndex = 2;
            this.lblTituloUsuario.Text = "Usuario :";
            this.lblTituloUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblSeparadorHoras);
            this.panel4.Controls.Add(this.lblHoras);
            this.panel4.Controls.Add(this.lblSegundos);
            this.panel4.Controls.Add(this.lblSeparadorMinutos);
            this.panel4.Controls.Add(this.lblMinutos);
            this.panel4.Controls.Add(this.lblTituloTiempo);
            this.panel4.Location = new System.Drawing.Point(552, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 27);
            this.panel4.TabIndex = 11;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.Black;
            this.lblMinutos.Location = new System.Drawing.Point(109, 5);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(22, 18);
            this.lblMinutos.TabIndex = 3;
            this.lblMinutos.Text = "00";
            this.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTiempo
            // 
            this.lblTituloTiempo.AutoSize = true;
            this.lblTituloTiempo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTiempo.ForeColor = System.Drawing.Color.Black;
            this.lblTituloTiempo.Location = new System.Drawing.Point(12, 5);
            this.lblTituloTiempo.Name = "lblTituloTiempo";
            this.lblTituloTiempo.Size = new System.Drawing.Size(65, 18);
            this.lblTituloTiempo.TabIndex = 2;
            this.lblTituloTiempo.Text = "Tiempo :";
            this.lblTituloTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 47);
            this.panel5.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblTituloFecha);
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 27);
            this.panel1.TabIndex = 13;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(67, 5);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 18);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "-----------------";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.ForeColor = System.Drawing.Color.Black;
            this.lblTituloFecha.Location = new System.Drawing.Point(6, 5);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(55, 18);
            this.lblTituloFecha.TabIndex = 2;
            this.lblTituloFecha.Text = "Fecha :";
            this.lblTituloFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 1000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // lblSeparadorMinutos
            // 
            this.lblSeparadorMinutos.AutoSize = true;
            this.lblSeparadorMinutos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparadorMinutos.ForeColor = System.Drawing.Color.Black;
            this.lblSeparadorMinutos.Location = new System.Drawing.Point(128, 5);
            this.lblSeparadorMinutos.Name = "lblSeparadorMinutos";
            this.lblSeparadorMinutos.Size = new System.Drawing.Size(12, 18);
            this.lblSeparadorMinutos.TabIndex = 4;
            this.lblSeparadorMinutos.Text = ":";
            this.lblSeparadorMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.Black;
            this.lblSegundos.Location = new System.Drawing.Point(137, 5);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(22, 18);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "00";
            this.lblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparadorHoras
            // 
            this.lblSeparadorHoras.AutoSize = true;
            this.lblSeparadorHoras.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparadorHoras.ForeColor = System.Drawing.Color.Black;
            this.lblSeparadorHoras.Location = new System.Drawing.Point(100, 5);
            this.lblSeparadorHoras.Name = "lblSeparadorHoras";
            this.lblSeparadorHoras.Size = new System.Drawing.Size(12, 18);
            this.lblSeparadorHoras.TabIndex = 7;
            this.lblSeparadorHoras.Text = ":";
            this.lblSeparadorHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(81, 5);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(22, 18);
            this.lblHoras.TabIndex = 6;
            this.lblHoras.Text = "00";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usPie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel5);
            this.Name = "usPie";
            this.Size = new System.Drawing.Size(750, 53);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblTituloTiempo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblSeparadorMinutos;
        private System.Windows.Forms.Label lblSeparadorHoras;
        private System.Windows.Forms.Label lblHoras;
    }
}
