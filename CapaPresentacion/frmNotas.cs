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
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class frmNotas : frmPrincipal
    {
        public frmNotas(clsAdministrador Administrador, clsProfesor Profesor)
        {
            InitializeComponent();
            if (Administrador != null)
            {
                Iniciador = inicio.Amdinistrador;
            }
            else
            {
                if (Profesor != null)
                {
                    Profesor_inicial = Profesor;
                    Iniciador = inicio.Profesor;
                }
            }
        }
        private clsProfesor Profesor_inicial;
        private clsCurso Curso;
        private clsAlumno Alumno;
        private clsRepositorioNota Nota;
        List<IEntidad> Alumnos;
        List<IEntidad> Cursos;
        List<IEntidad> Cursos_del_profesor;
        private enum TipoBuscarAlumno { Nombre, Apellido, Dni, Direccion, Telefono, Email };
        private enum TipoBuscarCurso { Nombre, FechaInicio, FechaFin, Descripcion };

        private enum inicio { Amdinistrador, Profesor };
        private inicio Iniciador;
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
                        this.ActualizarGrillaCursos(Iniciador);
                        this.lblVariableAlumno.ForeColor = Color.DarkBlue;
                        this.lblVariableAlumno.Text = Alumno.Nombre;
                        this.lblVariableAlumno.Text += " " + Alumno.Apellido;
                    }
                    else
                    {
                        this.lblVariableAlumno.ForeColor = Color.Red;
                        this.lblVariableAlumno.Text = "Sin seleccionar";
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
                this.lblVariableAlumno.Text = "Sin seleccionar";
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
                    Alumnos = new List<IEntidad>();
                    clsRepositorioAlumno consultador = new clsRepositorioAlumno();
                    Alumnos = consultador.Lista();
                    foreach (clsAlumno EAlum in Alumnos)
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
                    this.lblVariableAlumno.Text = "Sin seleccionar";
                    this.ActualizarGrillaCursos(Iniciador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void ActualizarGrillaCursos(inicio temp)
        {
            if (temp == inicio.Amdinistrador)
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
                    lblVariableCurso.Text = "Sin Seleccionar";
                    lblVariableCurso.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvEtapaDos.Rows.Clear();
                this.ColumnasCursos();
                List<IEntidad> Cursos_del_Alumno = new List<IEntidad>();
                clsRepositorioInscripcion consultador = new clsRepositorioInscripcion();
                clsRepositorioProfesor consultador2 = new clsRepositorioProfesor();
                Cursos.Clear();
                try
                {
                    if (Alumno.Id != -1)
                    {
                        Cursos_del_Alumno = consultador.ListaCursos(Alumno.Id);
                    }
                    if (Cursos_del_profesor.Count() == 0)
                    {
                        Cursos_del_profesor = consultador2.ListaCursos(Profesor_inicial.Id);
                    }
                    foreach(clsCurso CursoPibe in Cursos_del_Alumno)
                    {
                        if (Cursos_del_profesor.Exists(x => x.Id == CursoPibe.Id))
                        {
                            Cursos.Add(CursoPibe);
                        }
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
                    lblVariableCurso.Text = "Sin Seleccionar";
                    lblVariableCurso.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }
        private void frmNotas_Load(object sender, EventArgs e)
        {
            Alumno = new clsAlumno();
            Curso = new clsCurso();
            Cursos = new List<IEntidad>();
            Nota = new clsRepositorioNota();
            this.Cursos_del_profesor = new List<IEntidad>();
            this.ActualizarGrillaAlumnos();
            rdNombre.Checked = true;
            rdNombreCurso.Checked = true;
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
        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar();
        }
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar();
        }
        private void rdNombreCurso_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar_Curso();
        }
        private void tbBuscarCurso_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar_Curso();
        }
        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
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
                if (rdDni.Checked)
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
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
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
                    if (temp.Cells[busqueda].Value.ToString().Trim().Contains( Tarjet.Trim() ))
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
        private void lblAlumnos_Click(object sender, EventArgs e)
        {
            this.ActualizarGrillaAlumnos();
        }
        private void lblCursos_Click(object sender, EventArgs e)
        {
            this.ActualizarGrillaCursos(Iniciador);
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            clsNota nueva = new clsNota();
            try
            {
                if (!string.IsNullOrWhiteSpace(tbNota.Text))
                {
                    string expresion1 =  "^[,][0-9]{0,4}$";
                    string valor = tbNota.Text;
                    if (Regex.IsMatch(tbNota.Text.Trim(), expresion1) == false) 
                    {
                        nueva.IdAlumno = Alumno.Id;
                        nueva.IdCurso = Curso.Id;
                        nueva.Nota = Convert.ToDouble(valor);
                        nueva.Estado = 1;
                        nueva.Fecha = DateTime.Today;
                        Nota.Agregar(nueva);
                        DialogResult result = MessageBox.Show("Desea Registrar otra nota?", "Nota Registrada exitosamente", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            this.restaurar_inicio();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato de la nota ingresada no es correcto");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una nota");
                }
            }
            catch (Exception a)
            {
                if(a.Message == "Esta nota ya fue registrada")
                {
                    DialogResult modificar = MessageBox.Show("¿Desea modificar la nota existente?", "Esta nota ya fue registrada", MessageBoxButtons.YesNo);
                    if (modificar == DialogResult.Yes)
                    {
                        try
                        {
                            clsNota tarjet = (clsNota) Nota.ObtenerPorId(nueva.IdAlumno, nueva.IdCurso);
                            frmModificarNota Modificar_Nota = new frmModificarNota(tarjet);
                            this.Visible = false;
                            Modificar_Nota.ShowDialog();
                            this.Visible = true;
                            this.restaurar_inicio();
                        }
                        catch (Exception b)
                        {
                            MessageBox.Show("Ocurrio el siguiente error:" + b.Message);
                        }

                    }
                    else
                    {
                        this.restaurar_inicio();
                    }
                }
            }
            
        }
        private void lblVariableAlumno_ForeColorChanged(object sender, EventArgs e)
        {
            if ((lblVariableAlumno.ForeColor != Color.Red) & (lblVariableCurso.ForeColor != Color.Red))
            {
                btnContinuar.Enabled = true;
            }
            else
            {
                btnContinuar.Enabled = false;
            }
        }
        private void restaurar_inicio()
        {
            this.ActualizarGrillaAlumnos();
            rdNombre.Checked = true;
            rdNombreCurso.Checked = true;
            tbNota.Text = string.Empty;
        }
    }
}
