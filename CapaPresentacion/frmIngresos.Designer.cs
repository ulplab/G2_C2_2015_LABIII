namespace CapaPresentacion
{
    partial class frmIngresos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresos));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresosPor = new System.Windows.Forms.Label();
            this.cbIngresosPor = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.chbPersonalizar = new System.Windows.Forms.CheckBox();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVariableTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1161, 94);
            this.ousEncabezado.Titulo = "Ingresos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Economía";
            // 
            // lblIngresosPor
            // 
            this.lblIngresosPor.AutoSize = true;
            this.lblIngresosPor.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresosPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblIngresosPor.ForeColor = System.Drawing.Color.White;
            this.lblIngresosPor.Location = new System.Drawing.Point(47, 213);
            this.lblIngresosPor.Name = "lblIngresosPor";
            this.lblIngresosPor.Size = new System.Drawing.Size(177, 26);
            this.lblIngresosPor.TabIndex = 26;
            this.lblIngresosPor.Text = "Ver ingresos por:";
            // 
            // cbIngresosPor
            // 
            this.cbIngresosPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngresosPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbIngresosPor.FormattingEnabled = true;
            this.cbIngresosPor.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cbIngresosPor.Items.AddRange(new object[] {
            "Alumnos",
            "Cursos",
            "Todo"});
            this.cbIngresosPor.Location = new System.Drawing.Point(52, 242);
            this.cbIngresosPor.Name = "cbIngresosPor";
            this.cbIngresosPor.Size = new System.Drawing.Size(248, 33);
            this.cbIngresosPor.TabIndex = 27;
            this.cbIngresosPor.SelectedIndexChanged += new System.EventHandler(this.cbIngresosPor_SelectedIndexChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(47, 278);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(190, 26);
            this.lblPeriodo.TabIndex = 28;
            this.lblPeriodo.Text = "Periodo mostrado:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Quincenal",
            "Mensual",
            "Trimestral",
            "Anual",
            "Cualquiera"});
            this.cbPeriodo.Location = new System.Drawing.Point(52, 307);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(248, 33);
            this.cbPeriodo.TabIndex = 29;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(52, 413);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1870, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(348, 29);
            this.dtpFechaInicio.TabIndex = 30;
            this.dtpFechaInicio.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpFechaFin.Location = new System.Drawing.Point(52, 482);
            this.dtpFechaFin.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(1870, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(348, 29);
            this.dtpFechaFin.TabIndex = 31;
            this.dtpFechaFin.Value = new System.DateTime(2015, 11, 3, 0, 0, 0, 0);
            this.dtpFechaFin.Visible = false;
            // 
            // chbPersonalizar
            // 
            this.chbPersonalizar.AutoSize = true;
            this.chbPersonalizar.BackColor = System.Drawing.Color.Transparent;
            this.chbPersonalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chbPersonalizar.ForeColor = System.Drawing.Color.White;
            this.chbPersonalizar.Location = new System.Drawing.Point(52, 346);
            this.chbPersonalizar.Name = "chbPersonalizar";
            this.chbPersonalizar.Size = new System.Drawing.Size(144, 30);
            this.chbPersonalizar.TabIndex = 32;
            this.chbPersonalizar.Text = "Usar rango:";
            this.chbPersonalizar.UseVisualStyleBackColor = false;
            this.chbPersonalizar.CheckedChanged += new System.EventHandler(this.chbPersonalizar_CheckedChanged);
            // 
            // chartEstadisticas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend2);
            this.chartEstadisticas.Location = new System.Drawing.Point(409, 336);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartEstadisticas.Series.Add(series2);
            this.chartEstadisticas.Size = new System.Drawing.Size(708, 310);
            this.chartEstadisticas.TabIndex = 53;
            this.chartEstadisticas.Text = "Grafico";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Location = new System.Drawing.Point(409, 97);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(708, 233);
            this.dgvDatos.TabIndex = 68;
            this.dgvDatos.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(52, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 59);
            this.btnBuscar.TabIndex = 86;
            this.btnBuscar.Tag = "6";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(47, 379);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(81, 26);
            this.lblDesde.TabIndex = 87;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(47, 445);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(69, 26);
            this.lblHasta.TabIndex = 88;
            this.lblHasta.Text = "Hasta";
            this.lblHasta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(402, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 39);
            this.label2.TabIndex = 89;
            this.label2.Text = "Total Recaudado:";
            // 
            // lblVariableTotal
            // 
            this.lblVariableTotal.AutoSize = true;
            this.lblVariableTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblVariableTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblVariableTotal.ForeColor = System.Drawing.Color.White;
            this.lblVariableTotal.Location = new System.Drawing.Point(995, 649);
            this.lblVariableTotal.Name = "lblVariableTotal";
            this.lblVariableTotal.Size = new System.Drawing.Size(122, 39);
            this.lblVariableTotal.TabIndex = 90;
            this.lblVariableTotal.Text = "$00.00";
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 730);
            this.Controls.Add(this.lblVariableTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.chartEstadisticas);
            this.Controls.Add(this.chbPersonalizar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cbIngresosPor);
            this.Controls.Add(this.lblIngresosPor);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresos";
            this.Text = "frmIngresos";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblIngresosPor, 0);
            this.Controls.SetChildIndex(this.cbIngresosPor, 0);
            this.Controls.SetChildIndex(this.lblPeriodo, 0);
            this.Controls.SetChildIndex(this.cbPeriodo, 0);
            this.Controls.SetChildIndex(this.dtpFechaInicio, 0);
            this.Controls.SetChildIndex(this.dtpFechaFin, 0);
            this.Controls.SetChildIndex(this.chbPersonalizar, 0);
            this.Controls.SetChildIndex(this.chartEstadisticas, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblDesde, 0);
            this.Controls.SetChildIndex(this.lblHasta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblVariableTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresosPor;
        private System.Windows.Forms.ComboBox cbIngresosPor;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.CheckBox chbPersonalizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblVariableTotal;
        private System.Windows.Forms.Label label2;

    }
}