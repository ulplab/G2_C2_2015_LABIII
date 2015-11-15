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
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports;

namespace CapaPresentacion.Reportes
{
    public partial class frmReporteMorosidad : Form
    {
        crReporteMorosidad morosos;

        public frmReporteMorosidad(crReporteMorosidad reporteMorosidad)
        {
            InitializeComponent();

            morosos = reporteMorosidad;
        }

        private void frmReporteMorosidad_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = morosos;
        }
    }
}
