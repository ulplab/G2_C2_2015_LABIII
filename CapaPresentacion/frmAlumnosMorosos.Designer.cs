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
            this.dgvEtapaUno = new System.Windows.Forms.DataGridView();
            this.lblMorosos = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Titulo = "Alumnos Morosos";
            // 
            // dgvEtapaUno
            // 
            this.dgvEtapaUno.AllowUserToAddRows = false;
            this.dgvEtapaUno.AllowUserToDeleteRows = false;
            this.dgvEtapaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapaUno.Location = new System.Drawing.Point(23, 147);
            this.dgvEtapaUno.Name = "dgvEtapaUno";
            this.dgvEtapaUno.ReadOnly = true;
            this.dgvEtapaUno.Size = new System.Drawing.Size(809, 293);
            this.dgvEtapaUno.TabIndex = 23;
            // 
            // lblMorosos
            // 
            this.lblMorosos.AutoSize = true;
            this.lblMorosos.BackColor = System.Drawing.Color.Transparent;
            this.lblMorosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblMorosos.ForeColor = System.Drawing.Color.White;
            this.lblMorosos.Location = new System.Drawing.Point(16, 97);
            this.lblMorosos.Name = "lblMorosos";
            this.lblMorosos.Size = new System.Drawing.Size(297, 39);
            this.lblMorosos.TabIndex = 25;
            this.lblMorosos.Text = "Alumnos morosos";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Black;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(627, 465);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(205, 62);
            this.btnGenerarReporte.TabIndex = 26;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // frmAlumnosMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 576);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lblMorosos);
            this.Controls.Add(this.dgvEtapaUno);
            this.Name = "frmAlumnosMorosos";
            this.Text = "frmAlumnosMorosos";
            this.Load += new System.EventHandler(this.frmAlumnosMorosos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.dgvEtapaUno, 0);
            this.Controls.SetChildIndex(this.lblMorosos, 0);
            this.Controls.SetChildIndex(this.btnGenerarReporte, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapaUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtapaUno;
        private System.Windows.Forms.Label lblMorosos;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}