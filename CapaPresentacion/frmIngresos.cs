using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interfaces;
using Clases;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmIngresos : frmPrincipal
    {
        public frmIngresos()
        {
            InitializeComponent();
        }

        private enum IngresosPor {Todo,Cursos,Alumno}
        private enum Periodo { Diario,Semanal,Quincenal,Mensual,Trimestral,Anual,Todo}
        private enum Estado {Habilitado, Deshabilitado}
        private IngresosPor seleccion;
        private Periodo Segunda_seleccion;
        private Estado tercera_seleccion;

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            cbIngresosPor.SelectedItem = "Todo";
            seleccion = IngresosPor.Todo;
            cbPeriodo.SelectedItem = "Cualquiera";
            Segunda_seleccion = Periodo.Todo;
            chbPersonalizar.Checked = false;
            chbCampos.Checked = false;
        }
        private void chbPersonalizar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPersonalizar.Checked)
            {
                dtpFechaInicio.Visible = true;
                dtpFechaFin.Visible = true;
            }
            else
            {
                dtpFechaInicio.Visible = false;
                dtpFechaFin.Visible = false;
            }
        }
        private void chbCampos_CheckedChanged(object sender, EventArgs e)
        {
                this.Campos(seleccion);
        }
        private void cbIngresosPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDatos.Columns.Clear();
            if (cbIngresosPor.SelectedItem.ToString() == "Todo")
            {
                seleccion = IngresosPor.Todo;
            }
            else
            {
                if (cbIngresosPor.SelectedItem.ToString() == "Cursos")
                {
                    seleccion = IngresosPor.Cursos;
                }
                else
                {
                    seleccion = IngresosPor.Alumno;
                }
            }
            Creacion_Columnas();
            if (chbCampos.Checked)
            {
                this.Campos(seleccion);
            }
        }
        private void Creacion_Columnas()
        {
            switch (seleccion)
            {
                case IngresosPor.Todo: this.Columnas_Todo(); break;
                case IngresosPor.Cursos: this.Columnas_Curso(); break;
                case IngresosPor.Alumno: this.Columnas_Alumno(); break;
            }
        }
        private void Columnas_Todo()
        {
            dgvDatos.Columns.Add("Curso", "Curso");
            dgvDatos.Columns.Add("Alumno", "Alumno");
            dgvDatos.Columns.Add("Fecha", "Fecha");
            dgvDatos.Columns.Add("Pago", "Pago");
        }
        private void Columnas_Curso()
        {
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("FechaInicio", " Fecha de inicio");
            dgvDatos.Columns.Add("FechaFin", "Fecha de finalizacion");
            dgvDatos.Columns.Add("Estado", "Estado Actual");
            dgvDatos.Columns.Add("Recaudacion", "Recaudacion");
            dgvDatos.Columns.Add("Esperado", "Esperado");
            dgvDatos.Columns.Add("Porcentaje", "Porcentaje pagado");
        }
        private void Columnas_Alumno()
        {
            dgvDatos.Columns.Add("DNI", "D.N.I");
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Apellido", "Apellido");
            dgvDatos.Columns.Add("Estado", "Estado");
            dgvDatos.Columns.Add("Pago", "Pagado");
            dgvDatos.Columns.Add("Esperado", "Total a pagar");
            dgvDatos.Columns.Add("Porcentaje", "Porcentaje pagado");
        }
        private void Construccion_Consulta()
        {
            string fechaComodin = "02/02/1950";
            DateTime FechaInicio = Convert.ToDateTime(fechaComodin);
            DateTime FechaFin = Convert.ToDateTime(fechaComodin);
            clsAlumno Alumno = new clsAlumno();
            clsCurso Curso = new clsCurso();
            clsCuota cuota = new clsCuota();

            if (chbPersonalizar.Checked)
            {
                 FechaInicio = dtpFechaInicio.Value.Date;
                 FechaFin = dtpFechaFin.Value.Date;
            }
            else
            {
                switch (Segunda_seleccion)
                {
                    case Periodo.Diario: FechaFin = DateTime.Today; FechaInicio = DateTime.Today.AddDays(-1); ; break;
                    case Periodo.Semanal: FechaFin = DateTime.Today; FechaInicio = DateTime.Today.AddDays(-7); ; break;
                    case Periodo.Quincenal: FechaFin = DateTime.Today; FechaInicio = DateTime.Today.AddDays(-15); ; break;
                    case Periodo.Mensual: FechaFin = DateTime.Today; FechaInicio = DateTime.Today.AddMonths(-1); ; break;
                    case Periodo.Anual: FechaFin = DateTime.Today; FechaInicio = DateTime.Today.AddMonths(-12); ; break;
                    case Periodo.Todo: FechaFin = DateTime.Today; FechaInicio = DateTime.Today ; break;
                }
            }
            if (chbCampos.Checked)
            {

            }
            else
            {
                this.Procedimiento_sin_campos(FechaInicio, FechaFin);
            }

        }
        private void Procedimiento_sin_campos(DateTime Fecha_Inicio,DateTime Fecha_Fin)
        {
            List<IEntidad> Resultado = new List<IEntidad>();

            switch (seleccion)
            {
                case IngresosPor.Todo:
                    clsRepositorioCuota consultador = new clsRepositorioCuota();
                    Resultado = consultador.Lista_Formateada(Fecha_Inicio, Fecha_Fin);
                    dgvDatos.Rows.Clear();
                    foreach (clsCuotaFormateada temp in Resultado)
                    {
                        dgvDatos.Rows.Add(temp.IdCurso, temp.IdAlumno, temp.Fecha, temp.Precio);
                    }
                    break;
                case IngresosPor.Cursos:
                    clsRepositorioCurso consultador2 = new clsRepositorioCurso();
                    Resultado = consultador2.Cursos_Formateados(Fecha_Inicio,Fecha_Fin);
                    dgvDatos.Rows.Clear();
                    foreach (clsCursoFormateado temp in Resultado)
                    {
                        dgvDatos.Rows.Add(temp.Nombre, temp.FechaInicio, temp.FechaFin, temp.Estado, temp.Recaudado, temp.Esperado, temp.Porcentaje_pagado.ToString() + " %");
                    }
                    break;
                case IngresosPor.Alumno: ; break;
            }


        }
        private void Campos(IngresosPor temp)
        {
            this.mostrar_Campos();
            if (temp != IngresosPor.Todo)
            {
                if (temp == IngresosPor.Alumno)
                {
                    lblVariable1.Text = "Dni";
                    lblVariable2.Text = "Nombre";
                    lblVariable3.Text = "Apellido";
                    lblVariable4.Text = "Estado";
                    lblVariable5.Visible = false;
                    tbVariable5.Visible = false;
                    lblVariable6.Visible = false;
                    tbVariable6.Visible = false;
                    lblVariable7.Visible = false;
                    dtpVariable5.Visible = false;
                    dtpVariable6.Visible = false;
                    tbVariable4.Visible = false;
                }
                else
                {
                    lblVariable1.Text = "Nombre";
                    lblVariable2.Text = "Fecha de inicio";
                    lblVariable3.Text = "fecha de finalizacion";
                    lblVariable4.Text = "Estado";
                    lblVariable5.Visible = false;
                    tbVariable5.Visible = false;
                    lblVariable6.Visible = false;
                    tbVariable6.Visible = false;
                    tbVariable4.Visible = false;
                    lblVariable7.Visible = false;
                    tbVariable2.Visible = false;
                    tbVariable3.Visible = false;
                }
            }
        }
        private void mostrar_Campos()
        {
            lblVariable1.Visible = true;
            lblVariable2.Visible = true;
            lblVariable3.Visible = true;
            lblVariable4.Visible = true;
            lblVariable5.Visible = true;
            lblVariable6.Visible = true;
            lblVariable7.Visible = true;
            tbVariable1.Visible = true;
            tbVariable2.Visible = true;
            tbVariable3.Visible = true;
            tbVariable4.Visible = true;
            tbVariable5.Visible = true;
            tbVariable6.Visible = true;
            dtpVariable5.Visible = true;
            dtpVariable6.Visible = true;
            cbVariable7.Visible = true;
        }
        private void ocultar_Campos()
        {
            lblVariable1.Visible = false;
            lblVariable2.Visible = false;
            lblVariable3.Visible = false;
            lblVariable4.Visible = false;
            lblVariable5.Visible = false;
            lblVariable6.Visible = false;
            lblVariable7.Visible = false;
            tbVariable1.Visible = false;
            tbVariable2.Visible = false;
            tbVariable3.Visible = false;
            tbVariable4.Visible = false;
            tbVariable5.Visible = false;
            tbVariable6.Visible = false;
            dtpVariable5.Visible = false;
            dtpVariable6.Visible = false;
            cbVariable7.Visible = false;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Construccion_Consulta();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Construccion_Consulta();
        }
    }
}
