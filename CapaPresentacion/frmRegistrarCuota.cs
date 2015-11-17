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
using CapaPresentacion.Reportes;

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
        private enum TipoBuscarAlumno { Nombre, Apellido, Dni, Direccion, Telefono, Email };
        private enum TipoBuscarCurso { Nombre, FechaInicio, FechaFin, Descripcion };

        private void CursoSeleccionado()
        {
            if (dgvEtapaDos.SelectedRows != null)
            {
                try
                {
                    if (dgvEtapaDos.SelectedRows.Count > 0)
                    {
                        this.Curso.Id = Convert.ToInt32(dgvEtapaDos.SelectedRows[0].Cells["IdCurso"].Value.ToString());
                        this.Curso.Nombre = dgvEtapaDos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                        this.Curso.Descripcion = dgvEtapaDos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                        this.Curso.FechaInicio = Convert.ToDateTime(dgvEtapaDos.SelectedRows[0].Cells["FechaInicio"].Value.ToString());
                        this.Curso.FechaFin = Convert.ToDateTime(dgvEtapaDos.SelectedRows[0].Cells["FechaFin"].Value);
                        if (dgvEtapaDos.SelectedRows[0].Cells["Estado"].Value.ToString() == "habilitado")
                        {
                            this.Curso.Estado = 1;
                        }
                        else
                        {
                            this.Curso.Estado = 0;
                        }
                        btnContinuar.Enabled = true;
                        lblVariableCurso.Text = this.Curso.Nombre;
                        lblVariableCurso.ForeColor = Color.DarkBlue;
                        clsRepositorioCurso consultador = new clsRepositorioCurso();
                        clsCurso Curso = (clsCurso)consultador.ObtenerPorId(this.Curso.Id);
                        lblCuota.Text = "$" + Curso.Precio.ToString().Replace('.',',');
                        lblCuota.ForeColor = Color.Red;
                        
                    }
                    else
                    {
                        lblVariableCurso.Text = "Sin Seleccionar";
                        lblVariableCurso.ForeColor = Color.Red;
                        lblCuota.ForeColor = Color.White;
                        lblCuota.Text = "$00,00";
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
                        lblVariableAlumno.Text = Alumno.Nombre + " " + Alumno.Apellido;
                        lblVariableAlumno.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        lblVariableAlumno.Text = "Sin seleccionar";
                        lblVariableAlumno.ForeColor = Color.Red;
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
                this.AlumnoSeleccionado();
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
                this.CursoSeleccionado();
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
            rdNombre.Checked = true;
            rdNombreCurso.Checked = true;
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
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
                DialogResult Recibo = MessageBox.Show("¿Desea imprimir el recibo de la operacion?", "¡Exito!", MessageBoxButtons.YesNo);
                if (Recibo == DialogResult.Yes)
                {
                    crReciboCobroMatricula Comprobante = new crReciboCobroMatricula();
                    //Comprobante.SetParameterValue("NombreAlumno", Alumno.Nombre);
                    //Comprobante.SetParameterValue("nroPago", Cuota.Id);

                    DataSetReportes reporte = new DataSetReportes();
                    DataTable Datos = reporte.Tables["ReciboMatricula"];

                    Datos.Rows.Add(Curso.Nombre, Curso.Precio, Cuota.Fecha);

                    Comprobante.SetDataSource(Datos);

                    frmEmisionRecibo EmisionRecibo = new frmEmisionRecibo(Comprobante,Alumno.Nombre,Cuota.Id);

                    EmisionRecibo.Show();
             
                }
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
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + a.Message);
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
                    if (temp.Cells[busqueda].Value.ToString().Trim().Contains(Tarjet.Trim()))
                    {
                        encontrados.Add(temp);
                    }
                }
                dgvEtapaUno.Rows.Clear();
                dgvEtapaUno.Rows.AddRange(encontrados.ToArray());
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumno();
                Alumno.Id = -1;
                this.AlumnoSeleccionado();
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
                this.CursoSeleccionado();
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
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar();
        }
        private void btnBuscarAlumnos_Click(object sender, EventArgs e)
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
        private void tbBuscarCurso_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar_Curso();
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
        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar();
        }
        private void rdNombreCurso_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar_Curso();
        }
        private void lblAlumnos_Click(object sender, EventArgs e)
        {
            this.ActualizarGrillaAlumnos();
        }
        private void lblCursos_Click(object sender, EventArgs e)
        {
            this.ActualizarGrillaCursos();
        }
    }
}
