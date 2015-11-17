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
    public partial class frmEmisionRecibo : Form
    {
        crReciboCobroMatricula recibo;
        string nom;
        int nro;

        public frmEmisionRecibo(crReciboCobroMatricula reporteRecibo, string nombreAlumno, int nroRecibo)
        {
            InitializeComponent();

            recibo = reporteRecibo;
            nom = nombreAlumno;
            nro = nroRecibo;
        }

        private void frmEmisionRecibo_Load(object sender, EventArgs e)
        {
            recibo.SetParameterValue("nombreAlumno", nom);
            recibo.SetParameterValue("nroPago", nro);

            crystalReportViewer1.ReportSource = recibo;
        }
    }
}
