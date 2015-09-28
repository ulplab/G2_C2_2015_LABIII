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
    public partial class frmInscripcion2 : frmPrincipal
    {
        public frmInscripcion2(clsAlumno nuevo,clsAdministrador actual)
        {
            InitializeComponent();
            Alumno = nuevo;
            Actual = actual;
            ArrancoAlumno = true;
        }
        public frmInscripcion2(clsCurso nuevo,clsAdministrador actual)
        {
            InitializeComponent();
            Curso = nuevo;
            ArrancoAlumno = false;
            Actual = actual;
        }

        private clsAdministrador Actual;
        private clsCurso Curso;
        private clsAlumno Alumno;
        private bool ArrancoAlumno;
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
        private void ActualizarCursos()
        {
            dgvEtapaUno.Rows.Clear();
            clsManejoAsiste nuevo = new clsManejoAsiste();
            try
            {
            List<clsCurso> CursosDelAlumno = nuevo.CursosNoAsistentes(Alumno.Id);
            foreach (clsCurso ECurso in CursosDelAlumno)
            {
                if (ECurso.Estado)
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
        private void ActualizarAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
            clsManejoAsiste nuevo = new clsManejoAsiste();
            List<clsAlumno> AlumnosDelCurso = new List<clsAlumno>();
            try
            {
                AlumnosDelCurso = nuevo.AlumnosNoAsistentes(Curso.Id);
                foreach (clsAlumno EAlum in AlumnosDelCurso)
                {
                    if (EAlum.Estado)
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
        private void CursoSeleccionado()
        {
            if (dgvEtapaUno.SelectedRows != null)
            {
                try
                {
                    if (dgvEtapaUno.SelectedRows.Count > 0)
                    {
                        Curso.Id = Convert.ToInt32(dgvEtapaUno.SelectedRows[0].Cells["IdCurso"].Value.ToString());
                        Curso.Nombre = dgvEtapaUno.SelectedRows[0].Cells["Nombre"].Value.ToString();
                        Curso.Descripcion = dgvEtapaUno.SelectedRows[0].Cells["Nombre"].Value.ToString();
                        Curso.FechaInicio = Convert.ToDateTime(dgvEtapaUno.SelectedRows[0].Cells["FechaInicio"].Value.ToString());
                        Curso.FechaFin = Convert.ToDateTime(dgvEtapaUno.SelectedRows[0].Cells["FechaFin"].Value);
                        if (dgvEtapaUno.SelectedRows[0].Cells["Estado"].Value.ToString() == "habilitado")
                        {
                            Curso.Estado = true;
                        }
                        else
                        {
                            Curso.Estado = false;
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
                        Alumno.Dni = Convert.ToInt32(dgvEtapaUno.SelectedRows[0].Cells["Dni"].Value.ToString());
                        Alumno.Direccion = dgvEtapaUno.SelectedRows[0].Cells["Direccion"].Value.ToString();
                        Alumno.Telefono = dgvEtapaUno.SelectedRows[0].Cells["Telefono"].Value.ToString();
                        Alumno.Email = dgvEtapaUno.SelectedRows[0].Cells["Email"].Value.ToString();
                        if (dgvEtapaUno.SelectedRows[0].Cells["Estado"].Value.ToString() == "Habilitado")
                        {
                            Alumno.Estado = true;
                        }
                        else
                        {
                            Alumno.Estado = false;
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
        private void dgvEtapaUno_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ArrancoAlumno)
            {
                this.CursoSeleccionado();
            }
            else
            {
                this.AlumnoSeleccionado();
            }
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            clsManejoAsiste nuevo = new clsManejoAsiste();
            try
            {
                if ((Alumno.Id != -1) && (Curso.Id != -1) && (Actual != null))
                {
                    int result = nuevo.inscribir(Alumno, Curso, Actual);
                    MessageBox.Show("Se ha realizado" + result.ToString() + "Inscripcion. Su numero de inscripcion es" + result.ToString(), "Exito!");
                    if (ArrancoAlumno)
                    {
                        this.ActualizarCursos();
                    }
                    else
                    {
                        this.ActualizarAlumnos();
                    }
                }
                else
                {
                    if (Curso.Id == -1)
                    {
                        MessageBox.Show("Por favor seleccione un curso", "No Selecciono ningun destino");
                    }
                    else
                    {
                        if (Alumno.Id == -1)
                        {
                            MessageBox.Show("Por favor seleccione un Alumno", "No Selecciono ningun destino");
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + a.Message);
            }
        }
        private void frmInscripcion2_Load(object sender, EventArgs e)
        {
            if (ArrancoAlumno)
            {
                this.ColumnasCursos();
                this.ActualizarCursos();
                dgvEtapaUno.ClearSelection();
                Curso = new clsCurso();
                Curso.Id = -1;
            }
            else
            {
                this.ColumnasAlumnos();
                this.ActualizarAlumnos();
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumno();
                Alumno.Id = -1;
            }
        }
    }
}
