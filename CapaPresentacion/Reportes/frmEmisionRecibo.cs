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
        clsCuotaFormateada cf;
        crReciboCobroMatricula recibo;

        public frmEmisionRecibo(clsCuotaFormateada cuotaFormateada, crReciboCobroMatricula reporteRecibo)
        {
            InitializeComponent();

            cf = cuotaFormateada;
            recibo = reporteRecibo;
        }

        private void frmEmisionRecibo_Load(object sender, EventArgs e)
        {
            recibo.SetParameterValue("nombreAlumno", cf.IdAlumno);
            recibo.SetParameterValue("nroPago", cf.Id);

            crystalReportViewer1.ReportSource = recibo;
        }
    }
}
