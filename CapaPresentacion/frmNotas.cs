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
    public partial class frmNotas : frmPrincipal
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        private clsCurso Curso;
        private clsAlumno Alumno;
        private clsRepositorioNota Nota;

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
                        lblVariableCurso.Text = Curso.Nombre;
                        lblVariableCurso.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        lblVariableCurso.Text = "Sin Seleccionar";
                        lblVariableCurso.ForeColor = Color.Red;
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
            else
            {
                lblVariableCurso.Text = "Sin Seleccionar";
                lblVariableCurso.ForeColor = Color.Red;
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
                        this.lblVariableAlumno.ForeColor = Color.DarkBlue;
                        this.lblVariableAlumno.Text = Alumno.Nombre;
                        this.lblVariableAlumno.Text += " " + Alumno.Apellido;
                    }
                    else
                    {
                        this.lblVariableAlumno.ForeColor = Color.Red;
                        this.lblVariableAlumno.Text = "sin seleccionar";
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
            else
            {
                this.lblVariableAlumno.ForeColor = Color.Red;
                this.lblVariableAlumno.Text = "sin seleccionar";
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
                clsRepositorioAlumno consultador = new clsRepositorioAlumno();
                List<IEntidad> LE = consultador.Lista();
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
                this.lblVariableAlumno.ForeColor = Color.Red;
                this.lblVariableAlumno.Text = "sin seleccionar";
                this.ActualizarGrillaCursos();
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
                List<IEntidad> LE = new List<IEntidad>();
                if (Alumno.Id != -1)
                {
                    LE = consultador.ListaCursos(Alumno.Id);
                }
                else
                {

                }
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
                lblVariableCurso.Text = "Sin Seleccionar";
                lblVariableCurso.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void frmNotas_Load(object sender, EventArgs e)
        {
            Alumno = new clsAlumno();
            Curso = new clsCurso();
            Nota = new clsRepositorioNota();
            this.ActualizarGrillaAlumnos();
        }
        private void dgvEtapaUno_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.AlumnoSeleccionado();
        }
        private void dgvEtapaDos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CursoSeleccionado();
        }
        private void chbParamAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParamAlumnos.Checked)
            {
                pnlBusquedaAlumnos.Visible = true;
            }
            else
            {
                pnlBusquedaAlumnos.Visible = false;
            }
        }
        private void chbParamCursos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParamCursos.Checked)
            {
                pnlBusquedaCursos.Visible = true;
            }
            else
            {
                pnlBusquedaCursos.Visible = false;
            }
        }
        private void texto_buscar()
        {
            if (rdNombre.Checked)
            {
                tbBuscar.Text = rdNombreCurso.Text;
            }
            if (rdApellido.Checked)
            {
                tbBuscar.Text = rdApellido.Text;
            }
            if (rdDireccion.Checked)
            {
                tbBuscar.Text = rdDireccion.Text;
            }
            if (rdDni.Checked)
            {
                tbBuscar.Text = rdDni.Text;
            }
            if (rdEmail.Checked)
            {
                tbBuscar.Text = rdEmail.Text;
            }
            if (rdTelefono.Checked)
            {
                tbBuscar.Text = rdTelefono.Text;
            }
        }
        private void texto_limpiar()
        {
            if (rdNombre.Checked)
            {
                if (tbBuscar.Text == rdNombreCurso.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdApellido.Checked)
            {
                if (tbBuscar.Text == rdApellido.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdDireccion.Checked)
            {
                if (tbBuscar.Text == rdDireccion.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdDni.Checked)
            {
                if (tbBuscar.Text == rdDni.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdEmail.Checked)
            {
                if (tbBuscar.Text == rdEmail.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdTelefono.Checked)
            {
                if (tbBuscar.Text == rdTelefono.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
        }
        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar();
        }
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar();
        }      
    }
}
