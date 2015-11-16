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
    public partial class frmCambiarCurso : frmPrincipal
    {
        public frmCambiarCurso(clsAlumno Alumno_Anterior,clsCurso Curso_Anterior)
        {
            InitializeComponent();
            Alumno = Alumno_Anterior;
            this.Curso_Anterior = Curso_Anterior;
        }

        private enum TipoBuscarCurso { Nombre, FechaInicio, FechaFin, Descripcion };
        public clsCurso Curso;
        private clsCurso Curso_Anterior;
        private clsAlumno Alumno;
        List<IEntidad> Cursos;

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

        private void ActualizarGrillaCursos()
        {
            dgvEtapaDos.Rows.Clear();
            this.ColumnasCursos();
            Cursos = new List<IEntidad>();
            clsRepositorioInscripcion consultador = new clsRepositorioInscripcion();
            try
            {
                if (Alumno.Id != -1)
                {
                    Cursos = consultador.ListaCursos(Alumno.Id);
                }
                foreach (clsCurso ECurso in Cursos)
                {
                    if (ECurso.Estado == 1)
                    {
                        dgvEtapaDos.Rows.Add(ECurso.Id, ECurso.Nombre, ECurso.Descripcion, ECurso.FechaInicio, ECurso.FechaFin, "Habilitado");
                    }
                }
                dgvEtapaDos.ClearSelection();
                Curso = new clsCurso();
                Curso.Id = -1;
                this.tbCursoNuevo.Text = "Sin Seleccionar";
                this.tbCursoNuevo.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

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
                        this.tbCursoNuevo.Text = Curso.Nombre;
                        this.tbCursoNuevo.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        this.tbCursoNuevo.Text = "Sin Seleccionar";
                        this.tbCursoNuevo.ForeColor = Color.Red;
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
            else
            {
                this.tbCursoNuevo.Text = "Sin Seleccionar";
                this.tbCursoNuevo.ForeColor = Color.Red;
            }
        }

        private void texto_buscar_Curso()
        {
            if (rdNombreCurso.Checked)
            {
                tbBuscarCurso.Text = rdNombreCurso.Text;
            }
            else
            {
                if (rdDescripcion.Checked)
                {
                    tbBuscarCurso.Text = rdDescripcion.Text;
                }
                else
                {
                    if (rdFechaInicio.Checked)
                    {
                        tbBuscarCurso.Text = rdFechaInicio.Text;
                    }
                    else
                    {
                        if (rdFechaFin.Checked)
                        {
                            tbBuscarCurso.Text = rdFechaFin.Text;
                        }
                    }

                }
            }

        }

        private void texto_limpiar_Curso()
        {
            if (rdNombreCurso.Checked)
            {
                if (tbBuscarCurso.Text == rdNombreCurso.Text)
                {
                    tbBuscarCurso.Text = string.Empty;
                }
            }
            else
            {
                if (rdDescripcion.Checked)
                {
                    if (tbBuscarCurso.Text == rdDescripcion.Text)
                    {
                        tbBuscarCurso.Text = string.Empty;
                    }
                }
                else
                {
                    if (rdFechaInicio.Checked)
                    {
                        if (tbBuscarCurso.Text == rdFechaInicio.Text)
                        {
                            tbBuscarCurso.Text = string.Empty;
                        }
                    }
                    else
                    {
                        if (rdFechaFin.Checked)
                        {
                            if (tbBuscarCurso.Text == rdFechaFin.Text)
                            {
                                tbBuscarCurso.Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }

        private void Buscar_Curso(string Tarjet, TipoBuscarCurso tipo)
        {
            try
            {
                string busqueda = string.Empty;
                switch (tipo)
                {
                    case TipoBuscarCurso.Nombre: busqueda = "Nombre"; break;
                    case TipoBuscarCurso.FechaInicio: busqueda = "FechaInicio"; break;
                    case TipoBuscarCurso.FechaFin: busqueda = "FechaFin"; break;
                    case TipoBuscarCurso.Descripcion: busqueda = "Descripcion"; break;
                }
                List<DataGridViewRow> encontrados = new List<DataGridViewRow>();
                foreach (DataGridViewRow temp in dgvEtapaDos.Rows)
                {
                    if ((tipo != TipoBuscarCurso.FechaInicio) && (tipo != TipoBuscarCurso.FechaFin))
                    {
                        string comparar = temp.Cells[busqueda].Value.ToString();
                        if (comparar.Trim().Contains(Tarjet.Trim()))
                        {
                            encontrados.Add(temp);
                        }
                    }
                    else
                    {
                        DateTime Comparar = Convert.ToDateTime(temp.Cells[busqueda].Value.ToString());
                        DateTime Comparar2 = Convert.ToDateTime(Tarjet);
                        if (DateTime.Compare(Comparar.Date, Comparar2.Date) == 0)
                        {
                            encontrados.Add(temp);
                        }
                    }
                }
                dgvEtapaDos.Rows.Clear();
                dgvEtapaDos.Rows.AddRange(encontrados.ToArray());
                dgvEtapaDos.ClearSelection();
                Curso = new clsCurso();
                Curso.Id = -1;
            }
            catch (FormatException)
            {
                throw new Exception("La fecha tiene un formato incorrecto");
            }
            catch (Exception a)
            {
                throw new Exception("Se produjo el siguiente error: " + a.Message);
            }
        }

        private void frmCambiarCurso_Load(object sender, EventArgs e)
        {
            this.ActualizarGrillaCursos();
            rdNombreCurso.Checked = true;
            tbCursoAnterior.Text = Curso_Anterior.Nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdNombreCurso.Checked)
                {
                    this.Buscar_Curso(tbBuscarCurso.Text, TipoBuscarCurso.Nombre);
                }
                if (rdDescripcion.Checked)
                {
                    this.Buscar_Curso(tbBuscarCurso.Text, TipoBuscarCurso.Descripcion);
                }
                if (rdFechaInicio.Checked)
                {
                    this.Buscar_Curso(tbBuscarCurso.Text, TipoBuscarCurso.FechaInicio);
                }
                if (rdFechaFin.Checked)
                {
                    this.Buscar_Curso(tbBuscarCurso.Text, TipoBuscarCurso.FechaFin);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Curso = null;
            this.Close();
        }

        private void rdNombreCurso_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar_Curso();
        }

        private void tbBuscarCurso_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar_Curso();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (tbCursoNuevo.Text != "Sin Seleccionar")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Alumno");
            }
        }

        private void dgvEtapaDos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CursoSeleccionado();
        }
    }
}
