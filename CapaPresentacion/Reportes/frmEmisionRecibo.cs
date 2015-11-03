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
        public frmEmisionRecibo(clsCuotaFormateada cuotaFormateada)
        {
            InitializeComponent();

            cf = cuotaFormateada;
        }

        private void frmEmisionRecibo_Load(object sender, EventArgs e)
        {
            crReciboCobroMatricula recibo = new crReciboCobroMatricula();
            recibo.SetParameterValue("nombreAlumno", cf.IdAlumno);
            recibo.SetParameterValue("nroPago", cf.Id);

            DataSetReportes dsr = new DataSetReportes();
            dsr.Tables["ReciboMatricula"].Rows.Add(cf.IdCurso, cf.Precio, cf.Fecha);

            recibo.SetDataSource(dsr.Tables["ReciboMatricula"]);

            crystalReportViewer1.ReportSource = recibo;
        }
    }
}
