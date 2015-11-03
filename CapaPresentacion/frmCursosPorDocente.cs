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
    public partial class frmCursosPorDocente : frmPrincipal
    {
        public frmCursosPorDocente()
        {
            InitializeComponent();
        }

        clsProfesor Profesor = new clsProfesor();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        clsRepositorioProfesor RPro = new clsRepositorioProfesor();
        bool filtro = false;

        private void frmCursosPorDocente_Load(object sender, EventArgs e)
        {
            dgvDocentes.Columns.Add("IdProfesor", "IdProfesor");
            dgvDocentes.Columns.Add("Nombre", "Nombre");
            dgvDocentes.Columns.Add("Apellido", "Apellido");
            dgvDocentes.Columns.Add("Dni", "Dni");
            dgvDocentes.Columns.Add("Direccion", "Direccion");
            dgvDocentes.Columns.Add("Telefono", "Telefono");
            dgvDocentes.Columns.Add("Email", "Email");
            dgvDocentes.Columns.Add("CantidadCursos", "Cantidad Cursos");

            dgvDocentes.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;

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
            dgvDocentes.Columns["IdProfesor"].Visible = false;

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
            dgvDocentes.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.PROFESOR);
                List<IEntidad> LE = Repo.Lista();

                foreach (clsProfesor EPro in LE)
                {
                    if (EPro.Estado == 1)
                    {
                        dgvDocentes.Rows.Add();
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["IdProfesor"].Value = EPro.Id;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Nombre"].Value = EPro.Nombre;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Apellido"].Value = EPro.Apellido;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Dni"].Value = EPro.Dni;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Direccion"].Value = EPro.Direccion;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Telefono"].Value = EPro.Telefono;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["CantidadCursos"].Value = Convert.ToString(RPro.CantidadCursos(EPro.Id));
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
            clsProfesor temp = new clsProfesor();
            if (tbFiltroNombre.Text != string.Empty)
            {
                temp.Nombre = tbFiltroNombre.Text;
            }
            if (tbFiltroApellido.Text != string.Empty)
            {
                temp.Apellido = tbFiltroApellido.Text;
            }
            if (tbFiltroDni.Text != string.Empty)
            {
                temp.Dni = tbFiltroDni.Text;
            }

            temp.Estado = 1;

            dgvDocentes.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.PROFESOR);
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsProfesor EPro in LE)
                {
                    dgvDocentes.Rows.Add();
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["IdProfesor"].Value = EPro.Id;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Nombre"].Value = EPro.Nombre;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Apellido"].Value = EPro.Apellido;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Dni"].Value = EPro.Dni;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Direccion"].Value = EPro.Direccion;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Telefono"].Value = EPro.Telefono;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["CantidadCursos"].Value = Convert.ToString(RPro.CantidadCursos(EPro.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrillaCursos()
        {
            if (dgvDocentes.Rows.Count != 0 && dgvDocentes.CurrentRow != null)
            {
                dgvCursos.Rows.Clear();

                try
                {
                    List<IEntidad> LA = RPro.ListaCursos(Convert.ToInt32(dgvDocentes.CurrentRow.Cells["IdProfesor"].Value));

                    foreach (clsCurso ECurso in LA)
                    {
                        if (ECurso.Estado == 1)
                        {
                            dgvCursos.Rows.Add();
                            dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                            dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                            dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                            dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                            dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarGrillaCursos();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrillaFiltrada();
            ActualizarGrillaCursos();
            filtro = true;
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
            frmCursosPorDocente CursosPorDocente = new frmCursosPorDocente();
            this.Visible = false;
            CursosPorDocente.ShowDialog();
            this.Close();
        }



    }
}
