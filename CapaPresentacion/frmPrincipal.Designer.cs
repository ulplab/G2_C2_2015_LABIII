namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ousEncabezado = new Controles.usEncabezado();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.ousEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.ousEncabezado.EnableCerrar = true;
            this.ousEncabezado.EnableMaximizar = false;
            this.ousEncabezado.EnableMinimizar = true;
            this.ousEncabezado.FontColor = System.Drawing.Color.White;
            this.ousEncabezado.Formulario = null;
            this.ousEncabezado.Location = new System.Drawing.Point(0, 0);
            this.ousEncabezado.Name = "ousEncabezado";
            this.ousEncabezado.Size = new System.Drawing.Size(873, 94);
            this.ousEncabezado.TabIndex = 22;
            this.ousEncabezado.Titulo = "Titulo";
            this.ousEncabezado.Load += new System.EventHandler(this.ousEncabezado_Load);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 576);
            this.Controls.Add(this.ousEncabezado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        protected Controles.usEncabezado ousEncabezado;






    }
}