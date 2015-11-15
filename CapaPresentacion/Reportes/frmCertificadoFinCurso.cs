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
        string alumno, profesor, curso, logo;

        public frmCertificadoFinCurso(string nombreApellidoAlumno, string nombreApellidoProfesor, string nombreCurso, string logoPath)
        {
            InitializeComponent();

            alumno = nombreApellidoAlumno;
            profesor = nombreApellidoProfesor;
            curso = nombreCurso;
            logo = logoPath;
        }

        private void frmCertificadoFinCurso_Load(object sender, EventArgs e)
        {
            crCertificadoFinCurso certificado = new crCertificadoFinCurso();
            certificado.SetParameterValue("nombreAlumno", alumno);
            certificado.SetParameterValue("nombreCurso", curso);
            certificado.SetParameterValue("emisorCertificado", profesor);
            certificado.SetParameterValue("logoUrl", logo);

            crystalReportViewer1.ReportSource = certificado;
        }
    }
}
