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

        public frmEmisionRecibo(crReciboCobroMatricula reporteRecibo)
        {
            InitializeComponent();

            recibo = reporteRecibo;
        }

        private void frmEmisionRecibo_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = recibo;
        }
    }
}
