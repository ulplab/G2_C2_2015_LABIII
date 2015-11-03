using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmCertificadoFinCurso : Form
    {
        string alumno, profesor, curso;

        public frmCertificadoFinCurso(string nombreApellidoAlumno, string nombreApellidoProfesor, string nombreCurso)
        {
            InitializeComponent();

            alumno = nombreApellidoAlumno;
            profesor = nombreApellidoProfesor;
            curso = nombreCurso;
        }

        private void frmCertificadoFinCurso_Load(object sender, EventArgs e)
        {
            crCertificadoFinCurso certificado = new crCertificadoFinCurso();
            certificado.SetParameterValue("nombreAlumno", alumno);
            certificado.SetParameterValue("nombreCurso", curso);
            certificado.SetParameterValue("emisorCertificado", profesor);

            crystalReportViewer1.ReportSource = certificado;
        }
    }
}
