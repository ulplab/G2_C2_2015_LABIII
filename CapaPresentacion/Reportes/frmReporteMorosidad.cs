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
        DataTable dt;

        public frmReporteMorosidad(DataTable nombreTelefonoDireccionDeuda)
        {
            InitializeComponent();

            dt = nombreTelefonoDireccionDeuda;
        }

        private void frmReporteMorosidad_Load(object sender, EventArgs e)
        {
            crReporteMorosidad morosos = new crReporteMorosidad();

            morosos.SetDataSource(dt);

            crystalReportViewer1.ReportSource = morosos;
        }
        private void frmReporteMorosidad_Load(object sender, EventArgs e)
        {

        }


    }
}
