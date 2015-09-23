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
    public partial class frmCursosPorAlumno : frmPrincipal
    {
        public frmCursosPorAlumno()
        {
            InitializeComponent();
        }

        clsAlumno Alumno = new clsAlumno();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        clsManejoAsiste MA = new clsManejoAsiste();
        bool filtro = false;

        private void CursosPorAlumno_Load(object sender, EventArgs e)
        {

            dgvAlumnos.Columns.Add("IdAlumno", "IdAlumno");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Apellido", "Apellido");
            dgvAlumnos.Columns.Add("Dni", "Dni");
            dgvAlumnos.Columns.Add("Direccion", "Direccion");
            dgvAlumnos.Columns.Add("Telefono", "Telefono");
            dgvAlumnos.Columns.Add("Email", "Email");
            dgvAlumnos.Columns.Add("CantidadCursos", "Cantidad Cursos");

            dgvAlumnos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvCursos.Columns.Add("IdCurso", "IdCurso");
            dgvCursos.Columns.Add("Nombre", "Nombre");
            dgvCursos.Columns.Add("Descripcion", "Descripcion");
            dgvCursos.Columns.Add("FechaInicio", "Fecha Inicio");
            dgvCursos.Columns.Add("FechaFin", "Fecha Fin");

            dgvCursos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaInicio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaFin"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvCursos.Columns["IdCurso"].Visible = false;
            dgvAlumnos.Columns["IdAlumno"].Visible = false;


            btnDesactivarFiltro.BackColor = Color.Red;


            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            ActualizarGrillaCursos();
        }

        private void ActualizarGrilla()
        {
            dgvAlumnos.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.ALUMNO);
                List<IEntidad> LE = Repo.Lista();

                foreach (clsAlumno EAlum in LE)
                {
                    if (EAlum.Estado)
                    {
                        dgvAlumnos.Rows.Add();
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["IdAlumno"].Value = EAlum.Id;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Nombre"].Value = EAlum.Nombre;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Apellido"].Value = EAlum.Apellido;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Dni"].Value = EAlum.Dni;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Direccion"].Value = EAlum.Direccion;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Telefono"].Value = EAlum.Telefono;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Email"].Value = EAlum.Email;
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["CantidadCursos"].Value = Convert.ToString(MA.CantidadAlumno(EAlum.Id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrillaFiltrada()
        {
            string query = string.Empty;


            query = "SELECT * " +
                    "FROM Alumnos " +
                    "WHERE Nombre LIKE '" + tbFiltroNombre.Text + "%' " +
                    "AND Apellido LIKE '" + tbFiltroApellido.Text + "%' " +
                    "AND cast(Dni as varchar(10)) LIKE'" + tbFiltroDni.Text + "%' ";
            
            

            dgvAlumnos.Rows.Clear();

            try
            {
                List<IEntidad> LE = Repo.Lista(query);

                foreach (clsAlumno EAlum in LE)
                {
                    dgvAlumnos.Rows.Add();
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["IdAlumno"].Value = EAlum.Id;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Nombre"].Value = EAlum.Nombre;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Apellido"].Value = EAlum.Apellido;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Dni"].Value = EAlum.Dni;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Direccion"].Value = EAlum.Direccion;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Telefono"].Value = EAlum.Telefono;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Email"].Value = EAlum.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActivarFiltro_Click(object sender, EventArgs e)
        {
            btnActivarFiltro.BackColor = Color.Lime;
            btnDesactivarFiltro.BackColor = Color.Transparent;
            filtro = true;
            ActualizarGrillaFiltrada();
            ActualizarGrillaCursos();
        }

        private void btnDesactivarFiltro_Click(object sender, EventArgs e)
        {
            btnDesactivarFiltro.BackColor = Color.Red;
            btnActivarFiltro.BackColor = Color.Transparent;
            filtro = false;
            ActualizarGrilla();
            ActualizarGrillaCursos();
        }

        private void tbFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            if (filtro)
            {
                ActualizarGrillaFiltrada();
                ActualizarGrillaCursos();
            }
        }

        private void ActualizarGrillaCursos()
        {
            if (dgvAlumnos.Rows.Count != 0 && dgvAlumnos.CurrentRow != null)
            {
                dgvCursos.Rows.Clear();

                try
                {
                    List<clsCurso> LA = MA.ListaCursos(Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["IdAlumno"].Value));

                    foreach (clsCurso ECurso in LA)
                    {
                        dgvCursos.Rows.Add();
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarGrillaCursos();
        }




    }
}
