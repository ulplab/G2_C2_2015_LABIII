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
        public frmInscripcion2(clsAlumno nuevo)
        {
            InitializeComponent();
            Alumno = nuevo;
            ArrancoAlumno = true;
            ousEncabezado.Titulo = "Seleccione el curso al cual inscribir";
        }
        public frmInscripcion2(clsCurso nuevo)
        {
            InitializeComponent();
            Curso = nuevo;
            ArrancoAlumno = false;
            ousEncabezado.Titulo = "Seleccione el alumno al cual inscribir";
        }

        private clsCurso Curso;
        private clsAlumno Alumno;
        private bool ArrancoAlumno;
        private enum TipoBuscarAlumno { Nombre, Apellido, Dni, Direccion, Telefono, Email };
        private enum TipoBuscarCurso { Nombre, FechaInicio, FechaFin, Descripcion };
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
            clsRepositorioInscripcion nuevo = new clsRepositorioInscripcion();
            try
            {
            List<IEntidad> CursosDelAlumno = nuevo.CursosNoAsistentes(Alumno.Id);
            foreach (clsCurso ECurso in CursosDelAlumno)
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
        private void ActualizarAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
            clsRepositorioInscripcion nuevo = new clsRepositorioInscripcion();
            List<IEntidad> AlumnosDelCurso = new List<IEntidad>();
            try
            {
                AlumnosDelCurso = nuevo.AlumnosNoAsistentes(Curso.Id);
                foreach (clsAlumno EAlum in AlumnosDelCurso)
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
            clsRepositorioInscripcion nuevo = new clsRepositorioInscripcion();
            try
            {
                if ((Alumno.Id != -1) && (Curso.Id != -1))
                {
                    clsInscripcion Inscripcion = new clsInscripcion();
                    Inscripcion.IdAlumno = Alumno.Id;
                    Inscripcion.IdCurso = Curso.Id;
                    int result = nuevo.Inscribir(Inscripcion);
                    MessageBox.Show("Se ha realizado correctamente la Inscripcion. Su numero de inscripcion es " + result.ToString(), "Exito!");
                    if (ArrancoAlumno)
                    {
                        this.ActualizarCursos();
                        btnCancelar.BackColor = Color.Black;
                        btnCancelar.Text = "Cancelar";
                    }
                    else
                    {
                        this.ActualizarAlumnos();
                        btnCancelar.BackColor = Color.Black;
                        btnCancelar.Text = "Cancelar";
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
                if (ArrancoAlumno)
                {
                    this.ActualizarCursos();
                    btnCancelar.BackColor = Color.Black;
                    btnCancelar.Text = "Cancelar";
                }
                else
                {
                    this.ActualizarAlumnos();
                    btnCancelar.BackColor = Color.Black;
                    btnCancelar.Text = "Cancelar";
                }
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
                this.rdNombre.Text = "Nombre";
                this.rdApellido.Text = "FechaInicio";
                this.rdDNI.Text = "FechaFin";
                this.rdDireccion.Text = "Descripcion";
                this.rdTelefono.Visible = false;
                this.rdEmail.Visible = false;
                rdNombre.Checked = true;
            }
            else
            {
                
                rdNombre.Checked = true;
                this.rdNombre.Text = "Nombre";
                this.rdApellido.Text = "Apellido";
                this.rdDNI.Text = "Dni";
                this.rdDireccion.Text = "Direccion";
                this.rdTelefono.Text = "Telefono";
                this.rdEmail.Text = "Email";
                this.rdTelefono.Visible = true;
                this.rdEmail.Visible = true;
                this.rdNombre.Checked = true;
                this.ColumnasAlumnos();
                this.ActualizarAlumnos();
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumno();
                Alumno.Id = -1;
            }
        }
        private void texto_buscar()
        {
            if (rdNombre.Checked)
            {
                tbBuscar.Text = rdNombre.Text;
            }
            if (rdApellido.Checked)
            {
                tbBuscar.Text = rdApellido.Text;
            }
            if (rdDireccion.Checked)
            {
                tbBuscar.Text = rdDireccion.Text;
            }
            if (rdDNI.Checked)
            {
                tbBuscar.Text = rdDNI.Text;
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
                if (tbBuscar.Text == rdNombre.Text)
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
            if (rdDNI.Checked)
            {
                if (tbBuscar.Text == rdDNI.Text)
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
        private void Buscar_Alumno(string Tarjet, TipoBuscarAlumno tipo)
        {
            try
            {
                string busqueda = string.Empty;
                switch (tipo)
                {
                    case TipoBuscarAlumno.Nombre: busqueda = "Nombre"; break;
                    case TipoBuscarAlumno.Apellido: busqueda = "Apellido"; break;
                    case TipoBuscarAlumno.Direccion: busqueda = "Direccion"; break;
                    case TipoBuscarAlumno.Dni: busqueda = "Dni"; break;
                    case TipoBuscarAlumno.Email: busqueda = "Email"; break;
                    case TipoBuscarAlumno.Telefono: busqueda = "Telefono"; break;
                }
                List<DataGridViewRow> encontrados = new List<DataGridViewRow>();
                foreach (DataGridViewRow temp in dgvEtapaUno.Rows)
                {
                    if (temp.Cells[busqueda].Value.ToString() == Tarjet)
                    {
                        encontrados.Add(temp);
                    }
                }
                dgvEtapaUno.Rows.Clear();
                dgvEtapaUno.Rows.AddRange(encontrados.ToArray());
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumno();
                Alumno.Id = -1;
            }
            catch (Exception a)
            {
                throw new Exception("Se produjo el siguiente error: " + a.Message);
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
                foreach (DataGridViewRow temp in dgvEtapaUno.Rows)
                {
                    if ((tipo != TipoBuscarCurso.FechaInicio) && (tipo != TipoBuscarCurso.FechaFin))
                    {
                        string comparar = temp.Cells[busqueda].Value.ToString();
                        if (string.Compare(comparar.Trim(), Tarjet.Trim()) == 0)
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
                dgvEtapaUno.Rows.Clear();
                dgvEtapaUno.Rows.AddRange(encontrados.ToArray());
                dgvEtapaUno.ClearSelection();
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ArrancoAlumno)
                {
                    if (rdNombre.Checked)
                    {
                        this.Buscar_Alumno(tbBuscar.Text, TipoBuscarAlumno.Nombre);
                    }
                    if (rdApellido.Checked)
                    {
                        this.Buscar_Alumno(tbBuscar.Text, TipoBuscarAlumno.Apellido);
                    }
                    if (rdDireccion.Checked)
                    {
                        this.Buscar_Alumno(tbBuscar.Text, TipoBuscarAlumno.Direccion);
                    }
                    if (rdDNI.Checked)
                    {
                        this.Buscar_Alumno(tbBuscar.Text, TipoBuscarAlumno.Dni);
                    }
                    if (rdEmail.Checked)
                    {
                        this.Buscar_Alumno(tbBuscar.Text, TipoBuscarAlumno.Email);
                    }
                    if (rdTelefono.Checked)
                    {
                        this.Buscar_Alumno(tbBuscar.Text, TipoBuscarAlumno.Telefono);
                    }
                }
                else
                {
                    if (rdNombre.Checked)
                    {
                        this.Buscar_Curso(tbBuscar.Text, TipoBuscarCurso.Nombre);
                    }
                    if (rdApellido.Checked)
                    {
                        this.Buscar_Curso(tbBuscar.Text, TipoBuscarCurso.FechaInicio);
                    }
                    if (rdDNI.Checked)
                    {
                        this.Buscar_Curso(tbBuscar.Text, TipoBuscarCurso.FechaFin);
                    }
                    if (rdDireccion.Checked)
                    {
                        this.Buscar_Curso(tbBuscar.Text, TipoBuscarCurso.Descripcion);
                    }
                }
                btnCancelar.BackColor = Color.Red;
                btnCancelar.Text = "todos";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void cbParametros_CheckedChanged(object sender, EventArgs e)
        {
            if (cbParametros.Checked)
            {
                pnlBusqueda.Visible = true;
            }
            else
            {
                pnlBusqueda.Visible = false;
                rdNombre.Checked = true;
            }
        }
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar();
        }
        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "todos")
            {
                if (ArrancoAlumno)
                {
                    this.ActualizarCursos();
                }
                else
                {
                    this.ActualizarAlumnos();
                }
                btnCancelar.BackColor = Color.Black;
                btnCancelar.Text = "Cancelar";
            }
            else
            {
                this.Close();
            }
        }
    }
}
