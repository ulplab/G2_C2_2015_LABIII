using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;

namespace CapaPresentacion.Reportes
{
    public partial class frmListadoAlumnos : Form
    {
        List<clsAlumno> alumnos;
        string curso;
        string profesor;

        public frmListadoAlumnos(List<clsAlumno> alumnosMorosos, string nombreCurso, string nombreProfesor)
        {
            InitializeComponent();

            alumnos = alumnosMorosos;
            curso = nombreCurso;
            profesor = nombreProfesor;
        }

        private void frmListadoAlumnos_Load(object sender, EventArgs e)
        {
            crListadoAlumnosPorCurso listado = new crListadoAlumnosPorCurso();
            listado.SetParameterValue("nombreCurso", curso);
            listado.SetParameterValue("nombreProfesor", profesor);

            DataSetReportes dsr = new DataSetReportes();
            foreach (clsAlumno alum in alumnos)
            {
                dsr.Tables["AlumnosPorCurso"].Rows.Add(alum.Id, alum.Nombre, alum.Apellido, alum.Direccion, alum.Telefono);
            }

            listado.SetDataSource(dsr.Tables["AlumnosPorCurso"]);

            crystalReportViewer1.ReportSource = listado;
        }
    }
}
