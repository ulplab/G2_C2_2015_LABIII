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
    public partial class frmAlumnosPorCurso : frmPrincipal
    {
        public frmAlumnosPorCurso()
        {
            InitializeComponent();
        }

        clsCurso Curso = new clsCurso();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        clsRepositorioInscripcion MA = new clsRepositorioInscripcion();
        bool filtro = false;

        private void frmListadosRegistros_Load(object sender, EventArgs e)
        {

            dgvCursos.Columns.Add("IdCurso", "IdCurso");
            dgvCursos.Columns.Add("Nombre", "Nombre");
            dgvCursos.Columns.Add("Descripcion", "Descripcion");
            dgvCursos.Columns.Add("FechaInicio", "Fecha Incio");
            dgvCursos.Columns.Add("FechaFin", "Fecha Fin");
            dgvCursos.Columns.Add("CantidadEstudiantes", "CantidadEstudiantes");

            dgvCursos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaInicio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaFin"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvAlumnos.Columns.Add("IdAlumno", "IdAlumno");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Apellido", "Apellido");
            dgvAlumnos.Columns.Add("Dni", "Dni");
            dgvAlumnos.Columns.Add("Direccion", "Direccion");
            dgvAlumnos.Columns.Add("Telefono", "Telefono");
            dgvAlumnos.Columns.Add("Email", "Email");

            dgvAlumnos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvCursos.Columns["IdCurso"].Visible = false;
            dgvAlumnos.Columns["IdAlumno"].Visible = false;

            dgvAlumnos.Columns["IdAlumno"].Visible = false;

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            ActualizarGrillaAlumnos();
            
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
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["CantidadEstudiantes"].Value = Convert.ToString(MA.Cantidad(ECurso.Id));
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
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["CantidadEstudiantes"].Value = Convert.ToString(MA.Cantidad(ECurso.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarGrillaAlumnos()
        {
            if (dgvCursos.Rows.Count != 0 && dgvCursos.CurrentRow != null)
            {
                dgvAlumnos.Rows.Clear();

                try
                {
                    List<IEntidad> LA = MA.ListaAlumnos(Convert.ToInt32(dgvCursos.CurrentRow.Cells["IdCurso"].Value));

                    foreach (clsAlumno EAlum in LA)
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
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarGrillaAlumnos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrillaFiltrada();
            ActualizarGrillaAlumnos();
            filtro = true;
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
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

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
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

        }



       







    }
}
