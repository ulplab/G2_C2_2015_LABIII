namespace CapaPresentacion
{
    partial class frmMenuAlumnos
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
            this.ousPie = new Controles.usPie();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(806, 94);
            this.ousEncabezado.Load += new System.EventHandler(this.ousEncabezado_Load);
            // 
            // ousPie
            // 
            this.ousPie.BackColor = System.Drawing.Color.Transparent;
            this.ousPie.FontColor = System.Drawing.Color.White;
            this.ousPie.Location = new System.Drawing.Point(22, 378);
            this.ousPie.Name = "ousPie";
            this.ousPie.Size = new System.Drawing.Size(756, 50);
            this.ousPie.TabIndex = 54;
            this.ousPie.Usuario = null;
            // 
            // frmMenuAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 440);
            this.Controls.Add(this.ousPie);
            this.Name = "frmMenuAlumnos";
            this.Tag = "1";
            this.Text = "frmMenuAlumnos";
            this.Load += new System.EventHandler(this.frmMenuAlumnos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.ousPie, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.usPie ousPie;
    }
}