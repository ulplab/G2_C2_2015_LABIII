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
    public partial class frmCambioDeAlumno : frmPrincipal
    {
        public frmCambioDeAlumno(clsAlumno Anterior,clsAlumno Retorno)
        {
            InitializeComponent();
            Alumno = Retorno;
            Alumno_Anterior = Anterior;
        }
        private clsAlumno Alumno_Anterior;
        public clsAlumno Alumno;
        private enum TipoBuscarAlumno { Nombre, Apellido, Dni, Direccion, Telefono, Email };

        private void frmCambioDeAlumno_Load(object sender, EventArgs e)
        {
            if (Alumno_Anterior != null)
            {
                tbNombreAnterior.Text = Alumno_Anterior.Nombre + " " + Alumno_Anterior.Apellido;
            }
            this.ActualizarGrillaAlumnos();
            rdNombre.Checked = true;
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
                        this.tbAlumnoNuevo.ForeColor = Color.DarkBlue;
                        this.tbAlumnoNuevo.Text = Alumno.Nombre;
                        this.tbAlumnoNuevo.Text += " " + Alumno.Apellido;
                    }
                    else
                    {
                        this.tbAlumnoNuevo.ForeColor = Color.Red;
                        this.tbAlumnoNuevo.Text = "sin seleccionar";
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
            else
            {
                this.tbAlumnoNuevo.ForeColor = Color.Red;
                this.tbAlumnoNuevo.Text = "sin seleccionar";
            }
        }
        private void ActualizarGrillaAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
            this.ColumnasAlumnos();
            try
            {
                List<IEntidad> Alumnos = new List<IEntidad>();
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
                this.tbAlumnoNuevo.Text = "sin seleccionar";
                this.tbAlumnoNuevo.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception a)
            {
                throw new Exception("Se produjo el siguiente error: " + a.Message);
            }
        }
        private void dgvEtapaUno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlumnoSeleccionado();
        }
        private void chbParametros_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParametros.Checked)
            {
                pnlBusquedaAlumnos.Visible = true;
            }
            else
            {
                pnlBusquedaAlumnos.Visible = false;
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
        private void button1_Click(object sender, EventArgs e)
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
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Alumno.Nombre != null)
            {         
                this.Close();
            }
            else
            {
                MessageBox.Show("error");
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Alumno = null;
            this.Close();
        }
    }
}
