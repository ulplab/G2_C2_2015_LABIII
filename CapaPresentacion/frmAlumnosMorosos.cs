using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Interfaces;
using CapaLogica;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmAlumnosMorosos : frmPrincipal
    {
        public frmAlumnosMorosos()
        {
            InitializeComponent();
        }
        private clsAlumnoFormateado Alumno;
        private clsRepositorioCuota consultador;
        private List<IEntidad> LE;
        private void ActualizarGrillaAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
            this.ColumnasAlumnos();
            try
            {
                LE = consultador.ListaMorosos();
                foreach (clsAlumnoFormateado EAlum in LE)
                {
                    if (EAlum.Estado == 1)
                    {
                        dgvEtapaUno.Rows.Add(EAlum.Id, EAlum.Nombre, EAlum.Apellido, EAlum.Dni,EAlum.Pagado, "Habilitado");
                    }
                }
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumnoFormateado();
                Alumno.Id = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColumnasAlumnos()
        {
            dgvEtapaUno.Columns.Clear();
            dgvEtapaUno.Columns.Add("IdAlumno", "IdAlumno");
            dgvEtapaUno.Columns.Add("Nombre", "Nombre");
            dgvEtapaUno.Columns.Add("Apellido", "Apellido");
            dgvEtapaUno.Columns.Add("Dni", "Dni");
            dgvEtapaUno.Columns.Add("Deuda", "Deuda");
            dgvEtapaUno.Columns["IdAlumno"].Visible = false;
        }
        private void AlumnoSeleccionado()
        {
            if (dgvEtapaUno.SelectedRows != null)
            {
                try
                {
                    if (dgvEtapaUno.SelectedRows.Count > 0)
                    {
                        Alumno.Id = Convert.ToInt32(dgvEtapaUno.SelectedRows[0].Cells["IdAlumno"].Value.ToString());
                        Alumno.Nombre = dgvEtapaUno.SelectedRows[0].Cells["Nombre"].Value.ToString();
                        Alumno.Apellido = dgvEtapaUno.SelectedRows[0].Cells["Apellido"].Value.ToString();
                        Alumno.Dni = dgvEtapaUno.SelectedRows[0].Cells["Dni"].Value.ToString();
                        Alumno.Pagado = Convert.ToDouble( dgvEtapaUno.SelectedRows[0].Cells["Deuda"].Value );
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
        }
        private void frmAlumnosMorosos_Load(object sender, EventArgs e)
        {
            Alumno = new clsAlumnoFormateado();
            consultador = new clsRepositorioCuota();
            this.ActualizarGrillaAlumnos();
        }
        private void generar_Reporte()
        {
            DataTable reporte = new DataTable();
            reporte.Columns.Add("Nombre");
            reporte.Columns.Add("Telefono");
            reporte.Columns.Add("Direccion");
            reporte.Columns.Add("Deuda");

            foreach (clsAlumnoFormateado temp in LE)
            {
                reporte.Rows.Add(temp.Nombre, temp.Telefono, temp.Direccion, temp.Pagado);
            }

            //frmReporteMorosidad ReporteMorosidad = new frmReporteMorosidad(reporte);
            this.Visible = false;
            //ReporteMorosidad.ShowDialog();
            this.Visible = true;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.generar_Reporte();
        }
    }
}
