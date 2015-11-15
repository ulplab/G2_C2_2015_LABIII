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
    public partial class frmDocentesPorCurso : frmPrincipal
    {
        public frmDocentesPorCurso()
        {
            InitializeComponent();
        }

        clsCurso Curso = new clsCurso();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        clsRepositorioProfesor RProfesor = new clsRepositorioProfesor();
        bool filtro = false;

        private void btnAlumnosPorCurso_Click(object sender, EventArgs e)
        {
            frmAlumnosPorCurso AlumnosPorCurso = new frmAlumnosPorCurso();
            this.Visible = false;
            AlumnosPorCurso.ShowDialog();
            this.Close();
        }

        private void btnCursosPorAlumno_Click(object sender, EventArgs e)
        {
            frmCursosPorAlumno CursosPorAlumno = new frmCursosPorAlumno();
            this.Visible = false;
            CursosPorAlumno.ShowDialog();
            this.Close();
        }

        private void btnProfesoresPorCurso_Click(object sender, EventArgs e)
        {
            frmDocentesPorCurso DocentesPorCurso = new frmDocentesPorCurso();
            this.Visible = false;
            DocentesPorCurso.ShowDialog();
            this.Close();
        }

        private void btnCursosPorProfesor_Click(object sender, EventArgs e)
        {
            frmCursosPorDocente CursosPorDocente = new frmCursosPorDocente();
            this.Visible = false;
            CursosPorDocente.ShowDialog();
            this.Close();
        }

        private void frmDocentesPorCurso_Load(object sender, EventArgs e)
        {
            dgvCursos.Columns.Add("IdCurso", "IdCurso");
            dgvCursos.Columns.Add("Nombre", "Nombre");
            dgvCursos.Columns.Add("Descripcion", "Descripcion");
            dgvCursos.Columns.Add("FechaInicio", "Fecha Incio");
            dgvCursos.Columns.Add("FechaFin", "Fecha Fin");
            dgvCursos.Columns.Add("CantidadDocentes", "Cantidad Docentes");

            dgvCursos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaInicio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaFin"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvProfesores.Columns.Add("IdProfesor", "IdProfesor");
            dgvProfesores.Columns.Add("Nombre", "Nombre");
            dgvProfesores.Columns.Add("Apellido", "Apellido");
            dgvProfesores.Columns.Add("Dni", "Dni");
            dgvProfesores.Columns.Add("Direccion", "Direccion");
            dgvProfesores.Columns.Add("Telefono", "Telefono");
            dgvProfesores.Columns.Add("Email", "Email");

            dgvProfesores.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProfesores.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProfesores.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProfesores.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProfesores.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProfesores.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvCursos.Columns["IdCurso"].Visible = false;
            dgvProfesores.Columns["IdProfesor"].Visible = false;

            dgvProfesores.Columns["IdProfesor"].Visible = false;

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            ActualizarGrillaProfesores();
        }

        private void ActualizarGrilla()
        {
            dgvCursos.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.CURSO);
                List<IEntidad> LE = Repo.Lista();

                foreach (clsCurso ECurso in LE)
                {
                    if (ECurso.Estado == 1)
                    {
                        dgvCursos.Rows.Add();
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["CantidadDocentes"].Value = Convert.ToString(RProfesor.CantidadProfesores(ECurso.Id));
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

            clsCurso temp = new clsCurso();
            if (tbFiltroNombre.Text != string.Empty)
            {
                temp.Nombre = tbFiltroNombre.Text;
            }
            if (ckbFiltroFechaInicio.Checked)
            {
                temp.FechaInicio = Convert.ToDateTime(dtpFiltroFechaInicio.Value);
            }
            if (ckbFiltroFechaFin.Checked)
            {
                temp.FechaFin = Convert.ToDateTime(dtpFiltroFechaFin.Value);
            }

            temp.Estado = 1;

            dgvCursos.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.CURSO);
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsCurso ECurso in LE)
                {
                    dgvCursos.Rows.Add();
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["CantidadDocentes"].Value = Convert.ToString(RProfesor.CantidadProfesores(ECurso.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrillaProfesores()
        {
            if (dgvCursos.Rows.Count != 0 && dgvCursos.CurrentRow != null)
            {
                dgvProfesores.Rows.Clear();

                try
                {
                    List<IEntidad> LA = RProfesor.ListaProfesores(Convert.ToInt32(dgvCursos.CurrentRow.Cells["IdCurso"].Value));

                    foreach (clsProfesor EPro in LA)
                    {
                        if (EPro.Estado == 1)
                        {
                            dgvProfesores.Rows.Add();
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["IdProfesor"].Value = EPro.Id;
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["Nombre"].Value = EPro.Nombre;
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["Apellido"].Value = EPro.Apellido;
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["Dni"].Value = EPro.Dni;
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["Direccion"].Value = EPro.Direccion;
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["Telefono"].Value = EPro.Telefono;
                            dgvProfesores.Rows[dgvProfesores.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarGrillaProfesores();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrillaFiltrada();
            ActualizarGrillaProfesores();
            filtro = true;
        }

        private void btnAlumnosPorCurso_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnBuscar")
            {
                btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Grande.png");
            }
            else if ((sender as Button).Name == "btnAlumnosPorCurso")
            {
                btnAlumnosPorCurso.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Grande.png");
            }
            else if ((sender as Button).Name == "btnCursosPorAlumno")
            {
                btnCursosPorAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Grande.png");
            }
            else if ((sender as Button).Name == "btnProfesoresPorCurso")
            {
                btnProfesoresPorCurso.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Grande.png");
            }
            else
            {
                btnCursosPorProfesor.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Grande.png");
            }
        }

        private void btnAlumnosPorCurso_MouseLeave(object sender, EventArgs e)
        {

            if ((sender as Button).Name == "btnBuscar")
            {
                btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Chico.png");
            }
            else if ((sender as Button).Name == "btnAlumnosPorCurso")
            {
                btnAlumnosPorCurso.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Chico.png");
            }
            else if ((sender as Button).Name == "btnCursosPorAlumno")
            {
                btnCursosPorAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Chico.png");
            }
            else if ((sender as Button).Name == "btnProfesoresPorCurso")
            {
                btnProfesoresPorCurso.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Chico.png");
            }
            else
            {
                btnCursosPorProfesor.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Opciones-Chico.png");
            }
        }




    }
}
