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

namespace CapaPresentacion
{
    public partial class frmRegistrarCuota : frmPrincipal
    {
        public frmRegistrarCuota()
        {
            InitializeComponent();
        }
        private clsCurso Curso;
        private clsAlumno Alumno;
        private clsCuota Cuota;
        private IRepoFactory RepoF;
        private IRepositorio Repo;


        private void CursoSeleccionado()
        {
            if (dgvEtapaDos.SelectedRows != null)
            {
                try
                {
                    if (dgvEtapaDos.SelectedRows.Count > 0)
                    {
                        Curso.Id = Convert.ToInt32(dgvEtapaDos.SelectedRows[0].Cells["IdCurso"].Value.ToString());
                        Curso.Nombre = dgvEtapaDos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                        Curso.Descripcion = dgvEtapaDos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                        Curso.FechaInicio = Convert.ToDateTime(dgvEtapaDos.SelectedRows[0].Cells["FechaInicio"].Value.ToString());
                        Curso.FechaFin = Convert.ToDateTime(dgvEtapaDos.SelectedRows[0].Cells["FechaFin"].Value);
                        if (dgvEtapaDos.SelectedRows[0].Cells["Estado"].Value.ToString() == "habilitado")
                        {
                            Curso.Estado = 1;
                        }
                        else
                        {
                            Curso.Estado = 0;
                        }
                        btnContinuar.Enabled = true;
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
        }
        private void AlumnoSeleccionado()
        {
            if (dgvEtapaUno.SelectedRows != null)
            {
                try
                {
                    if (dgvEtapaUno.SelectedRows.Count > 0)
                    {
                        Alumno.Id = Convert.ToInt32(dgvEtapaUno.SelectedRows[0].Cells["IdAlumno"].Value.ToString());
                        Alumno.Nombre = dgvEtapaUno.SelectedRows[0].Cells["Nombre"].Value.ToString();
                        Alumno.Apellido = dgvEtapaUno.SelectedRows[0].Cells["Apellido"].Value.ToString();
                        Alumno.Dni = dgvEtapaUno.SelectedRows[0].Cells["Dni"].Value.ToString();
                        Alumno.Direccion = dgvEtapaUno.SelectedRows[0].Cells["Direccion"].Value.ToString();
                        Alumno.Telefono = dgvEtapaUno.SelectedRows[0].Cells["Telefono"].Value.ToString();
                        Alumno.Email = dgvEtapaUno.SelectedRows[0].Cells["Email"].Value.ToString();
                        if (dgvEtapaUno.SelectedRows[0].Cells["Estado"].Value.ToString() == "Habilitado")
                        {
                            Alumno.Estado = 1;
                        }
                        else
                        {
                            Alumno.Estado = 0;
                        }

                        this.ActualizarGrillaCursos();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
        }
        private void ColumnasCursos()
        {
            dgvEtapaDos.Columns.Clear();
            dgvEtapaDos.Columns.Add("IdCurso", "IdCurso");
            dgvEtapaDos.Columns.Add("Nombre", "Nombre");
            dgvEtapaDos.Columns.Add("Descripcion", "Descripcion");
            dgvEtapaDos.Columns.Add("FechaInicio", "Fecha Incio");
            dgvEtapaDos.Columns.Add("FechaFin", "Fecha Fin");
            dgvEtapaDos.Columns.Add("Estado", "Estado");
            dgvEtapaDos.Columns["IdCurso"].Visible = false;
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
        private void ActualizarGrillaAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
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
            dgvEtapaDos.Rows.Clear();
            this.ColumnasCursos();
            clsRepositorioInscripcion consultador = new clsRepositorioInscripcion();
            try
            {
                List<IEntidad> LE = consultador.CursosMorosos(Alumno.Id);
                foreach (clsCurso ECurso in LE)
                {
                    if (ECurso.Estado == 1)
                    {
                        dgvEtapaDos.Rows.Add(ECurso.Id, ECurso.Nombre, ECurso.Descripcion, ECurso.FechaInicio, ECurso.FechaFin, "Habilitado");
                    }
                }
                dgvEtapaDos.ClearSelection();
                Curso = new clsCurso();
                Curso.Id = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvEtapaUno_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.AlumnoSeleccionado();
        }
        private void dgvetapa2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.CursoSeleccionado();
        }
        private void frmRegistrarCuota_Load(object sender, EventArgs e)
        {
            this.Cuota = new clsCuota();
            RepoF = new clsRepoFactory();
            this.ActualizarGrillaAlumnos();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Cuota = new clsCuota();
            if (Alumno.Id == -1)
            {
                MessageBox.Show("El Alumno es null");
            }
            if (Curso.Id == -1)
            {
                MessageBox.Show("El curso tambien lo rompiste");
            }
            Cuota.IdAlumno = Alumno.Id;
            Cuota.IdCurso = Curso.Id;
            Cuota.Fecha = DateTime.Today;
            clsRepositorioCuota consultador = new clsRepositorioCuota();
            consultador.Agregar(Cuota);
            DialogResult continuar = MessageBox.Show("Cuota Registrada correctamente, ¿desea registrar otra?", "¡Exito!", MessageBoxButtons.YesNo);
            if (continuar == System.Windows.Forms.DialogResult.Yes)
            {
                dgvEtapaUno.Rows.Clear();
                dgvEtapaDos.Rows.Clear();
                this.ActualizarGrillaAlumnos();
            }
            else
            {
                this.Close();
            }
        }
    }
}
