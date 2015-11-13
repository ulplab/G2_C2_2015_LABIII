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
    public partial class frmRegistroCalificaciones : frmPrincipal
    {

        public frmRegistroCalificaciones()
        {
            InitializeComponent();

        }
        clsNota Nota;
        clsAlumno Alumno;
        clsCurso Curso;
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        bool filtro = false;

        private void frmRegistroCalificaciones_Load(object sender, EventArgs e)
        {
            Curso = new clsCurso();
            Alumno = new clsAlumno();
            Nota = new clsNota();
            this.ActualizarGrillaNotas();
        }
        private void ActualizarGrillaAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
            dgvEtapaUno.Columns.Clear();
            this.ColumnasAlumnos();
            try
            {
                Repo = RepoF.getRepositorio(RepoType.ALUMNO);
                List<IEntidad> LE = Repo.Lista();
                foreach (clsAlumno EAlum in LE)
                {
                    if (EAlum.Estado == 1)
                    {
                        dgvEtapaUno.Rows.Add(EAlum.Id, EAlum.Nombre, EAlum.Apellido, EAlum.Dni, EAlum.Direccion, EAlum.Telefono, EAlum.Email, "Habilitado");
                    }
                }
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumno();
                Alumno.Id = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarGrillaCursos()
        {
            dgvEtapaUno.Rows.Clear();
            dgvEtapaUno.Columns.Clear();
            this.ColumnasCursos();
            try
            {
                Repo = RepoF.getRepositorio(RepoType.CURSO);
                List<IEntidad> LE = Repo.Lista();
                foreach (clsCurso ECurso in LE)
                {
                    if (ECurso.Estado == 1)
                    {
                        dgvEtapaUno.Rows.Add(ECurso.Id, ECurso.Nombre, ECurso.Descripcion, ECurso.FechaInicio, ECurso.FechaFin, "Habilitado");
                    }
                }
                dgvEtapaUno.ClearSelection();
                Curso = new clsCurso();
                Curso.Id = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarGrillaNotas()
        {
            dgvEtapaUno.Rows.Clear();
            this.ColumnasNotas();
            try
            {
                Repo = RepoF.getRepositorio(RepoType.NOTA);
                List<IEntidad> LE = Repo.Lista();
                foreach (clsNota ECurso in LE)
                {
                    if (ECurso.Estado == 1)
                    {
                        dgvEtapaUno.Rows.Add(ECurso.Id, ECurso.IdAlumno,ECurso.IdCurso,ECurso.Nota,ECurso.Fecha);
                    }
                }
                dgvEtapaUno.ClearSelection();
                Nota = new clsNota();
                Nota.Id = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarGrillaFiltrada()
        {
            clsAlumno temp = new clsAlumno();
            temp.Nombre = tbFiltroNombre.Text;
            temp.Apellido = tbFiltroApellido.Text;
            temp.Dni = tbFiltroDni.Text;

            if (cbFiltroEstado.SelectedItem.ToString() != "Todos")
            {
                if (cbFiltroEstado.SelectedItem.ToString() == "Habilitados")
                {
                    temp.Estado = 1;
                }
                else
                {
                    temp.Estado = 0;
                }
            }

            dgvEtapaUno.Rows.Clear();

            try
            {
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsAlumno EAlum in LE)
                {
                    dgvEtapaUno.Rows.Add();
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["IdAlumno"].Value = EAlum.Id;
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Nombre"].Value = EAlum.Nombre;
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Apellido"].Value = EAlum.Apellido;
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Dni"].Value = EAlum.Dni;
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Direccion"].Value = EAlum.Direccion;
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Telefono"].Value = EAlum.Telefono;
                    dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Email"].Value = EAlum.Email;
                    if (EAlum.Estado == 1)
                    {
                        dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvEtapaUno.Rows[dgvEtapaUno.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
                    }
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
        }
        private void btnDesactivarFiltro_Click(object sender, EventArgs e)
        {

            btnDesactivarFiltro.BackColor = Color.Red;
            btnActivarFiltro.BackColor = Color.Transparent;
            filtro = false;
        }
        private void ColumnasCursos()
        {
            dgvEtapaUno.Columns.Clear();
            dgvEtapaUno.Columns.Add("IdCurso", "IdCurso");
            dgvEtapaUno.Columns.Add("Nombre", "Nombre");
            dgvEtapaUno.Columns.Add("Descripcion", "Descripcion");
            dgvEtapaUno.Columns.Add("FechaInicio", "Fecha Incio");
            dgvEtapaUno.Columns.Add("FechaFin", "Fecha Fin");
            dgvEtapaUno.Columns.Add("Estado", "Estado");
            dgvEtapaUno.Columns["IdCurso"].Visible = false;
        }
        private void ColumnasAlumnos()
        {
            dgvEtapaUno.Columns.Clear();
            dgvEtapaUno.Columns.Add("IdAlumno", "IdAlumno");
            dgvEtapaUno.Columns.Add("Nombre", "Nombre");
            dgvEtapaUno.Columns.Add("Apellido", "Apellido");
            dgvEtapaUno.Columns.Add("Dni", "Dni");
            dgvEtapaUno.Columns.Add("Direccion", "Direccion");
            dgvEtapaUno.Columns.Add("Telefono", "Telefono");
            dgvEtapaUno.Columns.Add("Email", "Email");
            dgvEtapaUno.Columns.Add("Estado", "Estado");
            dgvEtapaUno.Columns["IdAlumno"].Visible = false;
        }
        private void ColumnasNotas()
        {
            dgvEtapaUno.Columns.Add("IdNota", "IdNota");
            dgvEtapaUno.Columns["idNota"].Visible = false;
            dgvEtapaUno.Columns.Add("Alumno", "Alumno");
            dgvEtapaUno.Columns.Add("Curso", "Curso");
            dgvEtapaUno.Columns.Add("Nota", "Nota");
            dgvEtapaUno.Columns.Add("Fecha", "Fecha");
        }

    }
}
