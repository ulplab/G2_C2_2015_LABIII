using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using CapaLogica;
using Interfaces;

namespace CapaPresentacion
{
    public partial class frmFacturas : frmPrincipal
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        clsCuota cuota = new clsCuota();
        IRepoFactory repoF = new clsRepoFactory();
        clsRepositorioCuota repo;
        List<IEntidad> listCuota = new List<IEntidad>();

        bool filtro = false;

        private void actualizarGrilla()
        {
            listCuota.AddRange(repo.Lista_Formateada(dtpDesde.Value, dtpHasta.Value));

            dgvFacturas.Rows.Clear();
            foreach (clsCuotaFormateada cf in listCuota)
            {
                dgvFacturas.Rows.Add(cf.Id, cf.IdAlumno, cf.IdCurso, cf.Fecha, cf.Precio);
            }
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            repo = (clsRepositorioCuota)repoF.getRepositorio(RepoType.CUOTA);

            listCuota.AddRange(repo.Pagos_Por_Cursos());

            dgvFacturas.Columns.Add("IdCuota", "Nro de Inscripcion");
            dgvFacturas.Columns.Add("IdAlumno", "Alumno");
            dgvFacturas.Columns.Add("IdCurso", "Curso");
            dgvFacturas.Columns.Add("Fecha", "Fecha");
            dgvFacturas.Columns.Add("Monto", "Monto en $");

            foreach(clsCuotaFormateada cf in listCuota)
            {
                dgvFacturas.Rows.Add(cf.Id, cf.IdAlumno, cf.IdCurso, cf.Fecha, cf.Precio);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            cuota.Id = Convert.ToInt32(dgvFacturas.SelectedRows[0].Cells["IdCuota"]);
            repo.Borrar(cuota);
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
