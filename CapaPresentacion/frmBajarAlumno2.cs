using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogica;
using Clases;
using Interfaces;

namespace CapaPresentacion
{
    public partial class frmBajarAlumno2 : frmPrincipal
    {
        public frmBajarAlumno2(clsAlumno seleccionado)
        {
            InitializeComponent();
            Alumno = seleccionado;
        }

        public frmBajarAlumno2(clsCurso seleccionado)
        {
            InitializeComponent();
            Curso = seleccionado;
        }
        clsCurso Curso;
        clsAlumno Alumno;
        bool ArrancoAlumno;
        private void frmBajarAlumno2_Load(object sender, EventArgs e)
        {  
            if (Curso != null)
            {
                Alumno = new clsAlumno();
                ArrancoAlumno = false;
                this.ColumnasAlumnos();
                this.ActualizarAlumnos();
            }
            else
            {
                Curso = new clsCurso();
                if (Alumno != null)
                {
                    ArrancoAlumno = true;
                    this.ColumnasCursos();
                    ActualizarCursos();
                }
                else
                {
                    DialogResult temp = MessageBox.Show("Alumno y curso es null","Error en el formulario 1",MessageBoxButtons.OK);
                    if (temp == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
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
        private void ActualizarCursos()
        {
            dgvEtapaUno.Rows.Clear();
            clsManejoAsiste nuevo = new clsManejoAsiste();
            List<clsCurso> CursosDelAlumno = nuevo.ListaCursos(Alumno.Id);
            try
            {
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
            List<clsAlumno> AlumnosDelCurso = nuevo.ListaAlumnos(Curso.Id);
            try{
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
            if ((Alumno.Id != -1) && (Curso.Id != -1))
            {
                clsManejoAsiste eliminar = new clsManejoAsiste();
                int filas = eliminar.DarDeBaja(Alumno, Curso);
                DialogResult temp = MessageBox.Show("Se afectaron " + filas.ToString() + " filas", "Exito!", MessageBoxButtons.OK);
                if (temp == DialogResult.OK)
                {
                    if (ArrancoAlumno)
                    {
                        this.ActualizarCursos();
                    }
                    else
                    {
                        this.ActualizarAlumnos();
                    }
                }
            }
            else
            {
                if(Alumno.Id != -1)
                {
                    MessageBox.Show("Por favor, seleccione un Alumno para proceder", "ninguno seleccionado");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un Curso para proceder", "ninguno seleccionado");
                }
            }
        }
    }
}
