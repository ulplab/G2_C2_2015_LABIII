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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tcInformacion = new System.Windows.Forms.TabControl();
            this.tpGrilla = new System.Windows.Forms.TabPage();
            this.tpGrafico = new System.Windows.Forms.TabPage();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresosPor = new System.Windows.Forms.Label();
            this.cbIngresosPor = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.chbPersonalizar = new System.Windows.Forms.CheckBox();
            this.lblCampos = new System.Windows.Forms.Label();
            this.lblVariable1 = new System.Windows.Forms.Label();
            this.lblVariable2 = new System.Windows.Forms.Label();
            this.lblVariable3 = new System.Windows.Forms.Label();
            this.lblVariable4 = new System.Windows.Forms.Label();
            this.lblVariable5 = new System.Windows.Forms.Label();
            this.lblVariable6 = new System.Windows.Forms.Label();
            this.lblVariable7 = new System.Windows.Forms.Label();
            this.tbVariable1 = new System.Windows.Forms.TextBox();
            this.tbVariable2 = new System.Windows.Forms.TextBox();
            this.tbVariable3 = new System.Windows.Forms.TextBox();
            this.tbVariable4 = new System.Windows.Forms.TextBox();
            this.tbVariable5 = new System.Windows.Forms.TextBox();
            this.tbVariable6 = new System.Windows.Forms.TextBox();
            this.dtpVariable5 = new System.Windows.Forms.DateTimePicker();
            this.dtpVariable6 = new System.Windows.Forms.DateTimePicker();
            this.cbVariable7 = new System.Windows.Forms.ComboBox();
            this.chbCampos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tcInformacion.SuspendLayout();
            this.tpGrilla.SuspendLayout();
            this.tpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // ousEncabezado
            // 
            this.ousEncabezado.Formulario = this;
            this.ousEncabezado.Size = new System.Drawing.Size(1167, 94);
            this.ousEncabezado.Titulo = "Ingresos";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(3, 6);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(732, 517);
            this.dgvDatos.TabIndex = 22;
            // 
            // tcInformacion
            // 
            this.tcInformacion.Controls.Add(this.tpGrilla);
            this.tcInformacion.Controls.Add(this.tpGrafico);
            this.tcInformacion.Location = new System.Drawing.Point(382, 122);
            this.tcInformacion.Name = "tcInformacion";
            this.tcInformacion.SelectedIndex = 0;
            this.tcInformacion.Size = new System.Drawing.Size(749, 552);
            this.tcInformacion.TabIndex = 23;
            // 
            // tpGrilla
            // 
            this.tpGrilla.BackColor = System.Drawing.Color.Transparent;
            this.tpGrilla.Controls.Add(this.dgvDatos);
            this.tpGrilla.Location = new System.Drawing.Point(4, 22);
            this.tpGrilla.Name = "tpGrilla";
            this.tpGrilla.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrilla.Size = new System.Drawing.Size(741, 526);
            this.tpGrilla.TabIndex = 0;
            this.tpGrilla.Text = "Grilla";
            // 
            // tpGrafico
            // 
            this.tpGrafico.Controls.Add(this.chartEstadisticas);
            this.tpGrafico.Location = new System.Drawing.Point(4, 22);
            this.tpGrafico.Name = "tpGrafico";
            this.tpGrafico.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrafico.Size = new System.Drawing.Size(741, 526);
            this.tpGrafico.TabIndex = 1;
            this.tpGrafico.Text = "Grafico";
            this.tpGrafico.UseVisualStyleBackColor = true;
            // 
            // chartEstadisticas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend1);
            this.chartEstadisticas.Location = new System.Drawing.Point(3, 6);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEstadisticas.Series.Add(series1);
            this.chartEstadisticas.Size = new System.Drawing.Size(732, 514);
            this.chartEstadisticas.TabIndex = 0;
            this.chartEstadisticas.Text = "Grafico";
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
            this.lblIngresosPor.Location = new System.Drawing.Point(47, 165);
            this.lblIngresosPor.Name = "lblIngresosPor";
            this.lblIngresosPor.Size = new System.Drawing.Size(138, 26);
            this.lblIngresosPor.TabIndex = 26;
            this.lblIngresosPor.Text = "Ingresos por:";
            // 
            // cbIngresosPor
            // 
            this.cbIngresosPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngresosPor.FormattingEnabled = true;
            this.cbIngresosPor.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cbIngresosPor.Items.AddRange(new object[] {
            "Alumnos",
            "Cursos",
            "Todo"});
            this.cbIngresosPor.Location = new System.Drawing.Point(45, 194);
            this.cbIngresosPor.Name = "cbIngresosPor";
            this.cbIngresosPor.Size = new System.Drawing.Size(248, 21);
            this.cbIngresosPor.TabIndex = 27;
            this.cbIngresosPor.SelectedIndexChanged += new System.EventHandler(this.cbIngresosPor_SelectedIndexChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(47, 218);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(93, 26);
            this.lblPeriodo.TabIndex = 28;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Quincenal",
            "Mensual",
            "Trimestral",
            "Anual",
            "Cualquiera"});
            this.cbPeriodo.Location = new System.Drawing.Point(45, 247);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(248, 21);
            this.cbPeriodo.TabIndex = 29;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(45, 297);
            this.dtpFechaInicio.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1870, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(248, 20);
            this.dtpFechaInicio.TabIndex = 30;
            this.dtpFechaInicio.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(45, 323);
            this.dtpFechaFin.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(1870, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(248, 20);
            this.dtpFechaFin.TabIndex = 31;
            this.dtpFechaFin.Value = new System.DateTime(2015, 11, 3, 0, 0, 0, 0);
            this.dtpFechaFin.Visible = false;
            // 
            // chbPersonalizar
            // 
            this.chbPersonalizar.AutoSize = true;
            this.chbPersonalizar.BackColor = System.Drawing.Color.Transparent;
            this.chbPersonalizar.Location = new System.Drawing.Point(45, 274);
            this.chbPersonalizar.Name = "chbPersonalizar";
            this.chbPersonalizar.Size = new System.Drawing.Size(83, 17);
            this.chbPersonalizar.TabIndex = 32;
            this.chbPersonalizar.Text = "Personalizar";
            this.chbPersonalizar.UseVisualStyleBackColor = false;
            this.chbPersonalizar.CheckedChanged += new System.EventHandler(this.chbPersonalizar_CheckedChanged);
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCampos.ForeColor = System.Drawing.Color.White;
            this.lblCampos.Location = new System.Drawing.Point(40, 346);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(100, 26);
            this.lblCampos.TabIndex = 33;
            this.lblCampos.Text = "Campos:";
            // 
            // lblVariable1
            // 
            this.lblVariable1.AutoSize = true;
            this.lblVariable1.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable1.ForeColor = System.Drawing.Color.White;
            this.lblVariable1.Location = new System.Drawing.Point(47, 381);
            this.lblVariable1.Name = "lblVariable1";
            this.lblVariable1.Size = new System.Drawing.Size(92, 26);
            this.lblVariable1.TabIndex = 34;
            this.lblVariable1.Text = "Variable";
            this.lblVariable1.Visible = false;
            // 
            // lblVariable2
            // 
            this.lblVariable2.AutoSize = true;
            this.lblVariable2.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable2.ForeColor = System.Drawing.Color.White;
            this.lblVariable2.Location = new System.Drawing.Point(47, 433);
            this.lblVariable2.Name = "lblVariable2";
            this.lblVariable2.Size = new System.Drawing.Size(104, 26);
            this.lblVariable2.TabIndex = 35;
            this.lblVariable2.Text = "Variable2";
            this.lblVariable2.Visible = false;
            // 
            // lblVariable3
            // 
            this.lblVariable3.AutoSize = true;
            this.lblVariable3.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable3.ForeColor = System.Drawing.Color.White;
            this.lblVariable3.Location = new System.Drawing.Point(53, 456);
            this.lblVariable3.Name = "lblVariable3";
            this.lblVariable3.Size = new System.Drawing.Size(104, 26);
            this.lblVariable3.TabIndex = 36;
            this.lblVariable3.Text = "Variable3";
            this.lblVariable3.Visible = false;
            // 
            // lblVariable4
            // 
            this.lblVariable4.AutoSize = true;
            this.lblVariable4.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable4.ForeColor = System.Drawing.Color.White;
            this.lblVariable4.Location = new System.Drawing.Point(53, 502);
            this.lblVariable4.Name = "lblVariable4";
            this.lblVariable4.Size = new System.Drawing.Size(104, 26);
            this.lblVariable4.TabIndex = 37;
            this.lblVariable4.Text = "Variable4";
            this.lblVariable4.Visible = false;
            // 
            // lblVariable5
            // 
            this.lblVariable5.AutoSize = true;
            this.lblVariable5.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable5.ForeColor = System.Drawing.Color.White;
            this.lblVariable5.Location = new System.Drawing.Point(53, 550);
            this.lblVariable5.Name = "lblVariable5";
            this.lblVariable5.Size = new System.Drawing.Size(104, 26);
            this.lblVariable5.TabIndex = 38;
            this.lblVariable5.Text = "Variable5";
            this.lblVariable5.Visible = false;
            // 
            // lblVariable6
            // 
            this.lblVariable6.AutoSize = true;
            this.lblVariable6.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable6.ForeColor = System.Drawing.Color.White;
            this.lblVariable6.Location = new System.Drawing.Point(53, 597);
            this.lblVariable6.Name = "lblVariable6";
            this.lblVariable6.Size = new System.Drawing.Size(104, 26);
            this.lblVariable6.TabIndex = 39;
            this.lblVariable6.Text = "Variable6";
            this.lblVariable6.Visible = false;
            // 
            // lblVariable7
            // 
            this.lblVariable7.AutoSize = true;
            this.lblVariable7.BackColor = System.Drawing.Color.Transparent;
            this.lblVariable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblVariable7.ForeColor = System.Drawing.Color.White;
            this.lblVariable7.Location = new System.Drawing.Point(60, 644);
            this.lblVariable7.Name = "lblVariable7";
            this.lblVariable7.Size = new System.Drawing.Size(104, 26);
            this.lblVariable7.TabIndex = 40;
            this.lblVariable7.Text = "Variable7";
            this.lblVariable7.Visible = false;
            // 
            // tbVariable1
            // 
            this.tbVariable1.Location = new System.Drawing.Point(164, 387);
            this.tbVariable1.Name = "tbVariable1";
            this.tbVariable1.Size = new System.Drawing.Size(193, 20);
            this.tbVariable1.TabIndex = 41;
            this.tbVariable1.Visible = false;
            // 
            // tbVariable2
            // 
            this.tbVariable2.Location = new System.Drawing.Point(164, 433);
            this.tbVariable2.Name = "tbVariable2";
            this.tbVariable2.Size = new System.Drawing.Size(193, 20);
            this.tbVariable2.TabIndex = 42;
            this.tbVariable2.Visible = false;
            // 
            // tbVariable3
            // 
            this.tbVariable3.Location = new System.Drawing.Point(170, 462);
            this.tbVariable3.Name = "tbVariable3";
            this.tbVariable3.Size = new System.Drawing.Size(193, 20);
            this.tbVariable3.TabIndex = 43;
            this.tbVariable3.Visible = false;
            // 
            // tbVariable4
            // 
            this.tbVariable4.Location = new System.Drawing.Point(170, 508);
            this.tbVariable4.Name = "tbVariable4";
            this.tbVariable4.Size = new System.Drawing.Size(193, 20);
            this.tbVariable4.TabIndex = 44;
            this.tbVariable4.Visible = false;
            // 
            // tbVariable5
            // 
            this.tbVariable5.Location = new System.Drawing.Point(170, 556);
            this.tbVariable5.Name = "tbVariable5";
            this.tbVariable5.Size = new System.Drawing.Size(193, 20);
            this.tbVariable5.TabIndex = 45;
            this.tbVariable5.Visible = false;
            // 
            // tbVariable6
            // 
            this.tbVariable6.Location = new System.Drawing.Point(170, 603);
            this.tbVariable6.Name = "tbVariable6";
            this.tbVariable6.Size = new System.Drawing.Size(193, 20);
            this.tbVariable6.TabIndex = 46;
            this.tbVariable6.Visible = false;
            // 
            // dtpVariable5
            // 
            this.dtpVariable5.Location = new System.Drawing.Point(58, 579);
            this.dtpVariable5.Name = "dtpVariable5";
            this.dtpVariable5.Size = new System.Drawing.Size(305, 20);
            this.dtpVariable5.TabIndex = 48;
            this.dtpVariable5.Visible = false;
            // 
            // dtpVariable6
            // 
            this.dtpVariable6.Location = new System.Drawing.Point(58, 626);
            this.dtpVariable6.Name = "dtpVariable6";
            this.dtpVariable6.Size = new System.Drawing.Size(305, 20);
            this.dtpVariable6.TabIndex = 49;
            this.dtpVariable6.Visible = false;
            // 
            // cbVariable7
            // 
            this.cbVariable7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariable7.FormattingEnabled = true;
            this.cbVariable7.Location = new System.Drawing.Point(170, 646);
            this.cbVariable7.Name = "cbVariable7";
            this.cbVariable7.Size = new System.Drawing.Size(193, 21);
            this.cbVariable7.TabIndex = 50;
            this.cbVariable7.Visible = false;
            // 
            // chbCampos
            // 
            this.chbCampos.AutoSize = true;
            this.chbCampos.BackColor = System.Drawing.Color.Transparent;
            this.chbCampos.Location = new System.Drawing.Point(164, 355);
            this.chbCampos.Name = "chbCampos";
            this.chbCampos.Size = new System.Drawing.Size(83, 17);
            this.chbCampos.TabIndex = 51;
            this.chbCampos.Text = "Personalizar";
            this.chbCampos.UseVisualStyleBackColor = false;
            this.chbCampos.CheckedChanged += new System.EventHandler(this.chbCampos_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbCampos);
            this.Controls.Add(this.cbVariable7);
            this.Controls.Add(this.dtpVariable6);
            this.Controls.Add(this.dtpVariable5);
            this.Controls.Add(this.tbVariable6);
            this.Controls.Add(this.tbVariable5);
            this.Controls.Add(this.tbVariable4);
            this.Controls.Add(this.tbVariable3);
            this.Controls.Add(this.tbVariable2);
            this.Controls.Add(this.tbVariable1);
            this.Controls.Add(this.lblVariable7);
            this.Controls.Add(this.lblVariable6);
            this.Controls.Add(this.lblVariable5);
            this.Controls.Add(this.lblVariable4);
            this.Controls.Add(this.lblVariable3);
            this.Controls.Add(this.lblVariable2);
            this.Controls.Add(this.lblVariable1);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.chbPersonalizar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cbIngresosPor);
            this.Controls.Add(this.lblIngresosPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcInformacion);
            this.Name = "frmIngresos";
            this.Text = "frmIngresos";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            this.Controls.SetChildIndex(this.ousEncabezado, 0);
            this.Controls.SetChildIndex(this.tcInformacion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblIngresosPor, 0);
            this.Controls.SetChildIndex(this.cbIngresosPor, 0);
            this.Controls.SetChildIndex(this.lblPeriodo, 0);
            this.Controls.SetChildIndex(this.cbPeriodo, 0);
            this.Controls.SetChildIndex(this.dtpFechaInicio, 0);
            this.Controls.SetChildIndex(this.dtpFechaFin, 0);
            this.Controls.SetChildIndex(this.chbPersonalizar, 0);
            this.Controls.SetChildIndex(this.lblCampos, 0);
            this.Controls.SetChildIndex(this.lblVariable1, 0);
            this.Controls.SetChildIndex(this.lblVariable2, 0);
            this.Controls.SetChildIndex(this.lblVariable3, 0);
            this.Controls.SetChildIndex(this.lblVariable4, 0);
            this.Controls.SetChildIndex(this.lblVariable5, 0);
            this.Controls.SetChildIndex(this.lblVariable6, 0);
            this.Controls.SetChildIndex(this.lblVariable7, 0);
            this.Controls.SetChildIndex(this.tbVariable1, 0);
            this.Controls.SetChildIndex(this.tbVariable2, 0);
            this.Controls.SetChildIndex(this.tbVariable3, 0);
            this.Controls.SetChildIndex(this.tbVariable4, 0);
            this.Controls.SetChildIndex(this.tbVariable5, 0);
            this.Controls.SetChildIndex(this.tbVariable6, 0);
            this.Controls.SetChildIndex(this.dtpVariable5, 0);
            this.Controls.SetChildIndex(this.dtpVariable6, 0);
            this.Controls.SetChildIndex(this.cbVariable7, 0);
            this.Controls.SetChildIndex(this.chbCampos, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tcInformacion.ResumeLayout(false);
            this.tpGrilla.ResumeLayout(false);
            this.tpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TabControl tcInformacion;
        private System.Windows.Forms.TabPage tpGrilla;
        private System.Windows.Forms.TabPage tpGrafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresosPor;
        private System.Windows.Forms.ComboBox cbIngresosPor;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.CheckBox chbPersonalizar;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Label lblVariable1;
        private System.Windows.Forms.Label lblVariable2;
        private System.Windows.Forms.Label lblVariable3;
        private System.Windows.Forms.Label lblVariable4;
        private System.Windows.Forms.Label lblVariable5;
        private System.Windows.Forms.Label lblVariable6;
        private System.Windows.Forms.Label lblVariable7;
        private System.Windows.Forms.TextBox tbVariable1;
        private System.Windows.Forms.TextBox tbVariable2;
        private System.Windows.Forms.TextBox tbVariable3;
        private System.Windows.Forms.TextBox tbVariable4;
        private System.Windows.Forms.TextBox tbVariable5;
        private System.Windows.Forms.TextBox tbVariable6;
        private System.Windows.Forms.DateTimePicker dtpVariable5;
        private System.Windows.Forms.DateTimePicker dtpVariable6;
        private System.Windows.Forms.ComboBox cbVariable7;
        private System.Windows.Forms.CheckBox chbCampos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private System.Windows.Forms.Button button1;

    }
}