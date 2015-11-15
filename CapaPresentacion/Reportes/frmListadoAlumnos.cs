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
        string curso;
        string profesor;
        crListadoAlumnosPorCurso listado;

        public frmListadoAlumnos(string nombreCurso, string nombreProfesor, crListadoAlumnosPorCurso reporteListadoAlumnos)
        {
            InitializeComponent();

            curso = nombreCurso;
            profesor = nombreProfesor;
            listado = reporteListadoAlumnos;
        }

        private void frmListadoAlumnos_Load(object sender, EventArgs e)
        {
            listado.SetParameterValue("nombreCurso", curso);
            listado.SetParameterValue("nombreProfesor", profesor);

            crystalReportViewer1.ReportSource = listado;
        }
    }
}
