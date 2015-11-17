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

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            cbIngresosPor.SelectedItem = "Todo";
            seleccion = IngresosPor.Todo;
            cbPeriodo.SelectedItem = "Cualquiera";
            Segunda_seleccion = Periodo.Todo;
            chbPersonalizar.Checked = false;
        }
        private void chbPersonalizar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPersonalizar.Checked)
            {
                lblDesde.Visible = true;
                dtpFechaInicio.Visible = true;
                dtpFechaFin.Visible = true;
                lblHasta.Visible = true;
            }
            else
            {
                lblDesde.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFin.Visible = false;
                lblHasta.Visible = false;
            }
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
                    case Periodo.Todo:; break;
                }
            }
            this.Procedimiento_sin_campos(FechaInicio, FechaFin);
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
                        dgvDatos.Rows.Add(temp.IdCurso, temp.IdAlumno, temp.Fecha,"$ "+ temp.Precio.ToString());
                    }
                    break;
                case IngresosPor.Cursos:
                    clsRepositorioCurso consultador2 = new clsRepositorioCurso();
                    Resultado = consultador2.Cursos_Formateados(Fecha_Inicio,Fecha_Fin);
                    dgvDatos.Rows.Clear();
                    foreach (clsCursoFormateado temp in Resultado)
                    {
                        dgvDatos.Rows.Add(temp.Nombre, temp.FechaInicio, temp.FechaFin, temp.Estado, "$ " + temp.Recaudado.ToString(), "$ " + temp.Esperado.ToString(), temp.Porcentaje_pagado.ToString() + " %");
                    }
                    break;
                case IngresosPor.Alumno:
                    clsRepositorioAlumno consultador3 = new clsRepositorioAlumno();
                    Resultado = consultador3.Alumnos_Formateados(Fecha_Inicio, Fecha_Fin);
                    dgvDatos.Rows.Clear();
                    foreach (clsAlumnoFormateado temp in Resultado)
                    {
                        dgvDatos.Rows.Add(temp.Dni,temp.Nombre,temp.Apellido,temp.Estado,"$ " + temp.Pagado.ToString(),"$ " + temp.Esperado,temp.Porcentaje + " %");
                    }
                    ; break;
            }
            this.Chart(Resultado);
        }
        private void Chart(List<IEntidad> temp)
        {
            chartEstadisticas.Series.Clear();
            if (temp.Count() > 0)
            {
                if (temp[0] is clsCuotaFormateada)
                {
                    foreach(clsCuotaFormateada x in temp)
                    {
                        chartEstadisticas.Series.Add(x.IdAlumno.ToString() +"-"+x.IdCurso.ToString());
                        chartEstadisticas.Series[x.IdAlumno.ToString() +"-"+x.IdCurso.ToString()].Points.AddXY(chartEstadisticas.Series.Count, x.Precio);
                    }
                }
                else
                {
                    if (temp[0] is clsCursoFormateado)
                    {
                        int i = 0;
                        foreach (clsCursoFormateado y in temp)
                        {
                            chartEstadisticas.Series.Add(y.Nombre+" "+i.ToString() );
                            chartEstadisticas.Series[y.Nombre + " " + i.ToString()].Points.AddXY(chartEstadisticas.Series.Count, y.Recaudado);
                            i++;
                            if (i >= 10)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        int i = 0;
                        foreach (clsAlumnoFormateado y in temp)
                        {
                            chartEstadisticas.Series.Add(y.Apellido +" "+ i.ToString());
                            chartEstadisticas.Series[y.Apellido + " " + i.ToString()].Points.AddXY(chartEstadisticas.Series.Count, y.Pagado);
                            i++;
                            if (i >= 10)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Construccion_Consulta();
        }
        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPeriodo.SelectedItem.ToString())
            {
                case "Cualquiera": Segunda_seleccion = Periodo.Todo; break;
                case "Diario": Segunda_seleccion = Periodo.Diario; break;
                case "Semanal": Segunda_seleccion = Periodo.Semanal; break;
                case "Quincenal": Segunda_seleccion = Periodo.Quincenal; break;
                case "Mensual": Segunda_seleccion = Periodo.Mensual; break;
                case "Trimestral": Segunda_seleccion = Periodo.Trimestral; break;
                case "Anual": Segunda_seleccion = Periodo.Anual; break;
            }
        }
        
    }
}
