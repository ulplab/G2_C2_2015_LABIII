using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            cbPeriodo.SelectedItem = "Cualquiera";
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
            if (chbCampos.Checked)
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
            else
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
            dgvDatos.Columns.Add("Esperado", "Esperado");
            dgvDatos.Columns.Add("Restante", "Restante");
            dgvDatos.Columns.Add("Porcentaje", "Porcentaje pagado");
        }
        private void Columnas_Curso()
        {
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("FechaInicio", " Fecha de inicio");
            dgvDatos.Columns.Add("FechaFin", "Fecha de finalizacion");
            dgvDatos.Columns.Add("Estado", "Estado Actual");
            dgvDatos.Columns.Add("Recaudacion", "Recaudacion");
            dgvDatos.Columns.Add("Esperado", "Esperado");
            dgvDatos.Columns.Add("Restante", "Restante");
            dgvDatos.Columns.Add("Porcentaje", "Porcentaje Restante");
        }
        private void Columnas_Alumno()
        {
            dgvDatos.Columns.Add("DNI", "D.N.I");
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Apellido", "Apellido");
            dgvDatos.Columns.Add("Estado", "Estado");
            dgvDatos.Columns.Add("Pago", "Pago");
            dgvDatos.Columns.Add("Esperado", "Esperado");
            dgvDatos.Columns.Add("Restante", "Restante");
            dgvDatos.Columns.Add("Porcentaje", "Porcentaje pagado");
        }
        private void Construccion_Consulta()
        {
            string consulta = "Select * from ";
            switch (seleccion)
            {
                case IngresosPor.Todo: consulta += " Cuota "; break;
                case IngresosPor.Cursos: consulta += " Cursos "; break;
                case IngresosPor.Alumno: consulta += " Alumno " ; break;
            }
        }
    }
}
