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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmAlumnosMorosos : frmPrincipal
    {
        public frmAlumnosMorosos()
        {
            InitializeComponent();
        }
        private clsAlumnoFormateado Alumno;
        private clsRepositorioCuota consultador;
        private enum TipoBuscarAlumno { Nombre, Apellido, Dni, Direccion, Telefono, Email };
        private List<IEntidad> LE;
        private void ActualizarGrillaAlumnos()
        {
            dgvEtapaUno.Rows.Clear();
            this.ColumnasAlumnos();
            try
            {
                LE = consultador.ListaMorosos();
                foreach (clsAlumnoFormateado EAlum in LE)
                {
                    if (EAlum.Estado == 1)
                    {
                        dgvEtapaUno.Rows.Add(EAlum.Id, EAlum.Nombre, EAlum.Apellido, EAlum.Dni,EAlum.Pagado, "Habilitado");
                    }
                }
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumnoFormateado();
                Alumno.Id = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColumnasAlumnos()
        {
            dgvEtapaUno.Columns.Clear();
            dgvEtapaUno.Columns.Add("IdAlumno", "IdAlumno");
            dgvEtapaUno.Columns.Add("Nombre", "Nombre");
            dgvEtapaUno.Columns.Add("Apellido", "Apellido");
            dgvEtapaUno.Columns.Add("Dni", "Dni");
            dgvEtapaUno.Columns.Add("Deuda", "Deuda");
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
                        Alumno.Pagado = Convert.ToDouble( dgvEtapaUno.SelectedRows[0].Cells["Deuda"].Value );
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }
            }
        }
        private void frmAlumnosMorosos_Load(object sender, EventArgs e)
        {
            Alumno = new clsAlumnoFormateado();
            consultador = new clsRepositorioCuota();
            this.ActualizarGrillaAlumnos();
            rdNombre.Checked = true;
        }
        private void generar_Reporte()
        {
            try
            {
                DataTable reporte = new DataTable();
                reporte.Columns.Add("Nombre");
                reporte.Columns.Add("Telefono");
                reporte.Columns.Add("Direccion");
                reporte.Columns.Add("Deuda");

                foreach (clsAlumnoFormateado temp in LE)
                {
                    reporte.Rows.Add(temp.Nombre, temp.Telefono, temp.Direccion, temp.Pagado);
                }

                crReporteMorosidad Reporte_generado = new crReporteMorosidad();
                Reporte_generado.SetDataSource(reporte);
                frmReporteMorosidad ReporteMorosidad = new frmReporteMorosidad(Reporte_generado);
                this.Visible = false;
                ReporteMorosidad.ShowDialog();
                this.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Excepcion del reporte");
            }

        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
       //     this.generar_Reporte();
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
        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar();
        }
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar();
        }
        private void chbParamAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlBusquedaAlumnos.Visible)
            {
                pnlBusquedaAlumnos.Visible = false;
            }
            else
            {
                pnlBusquedaAlumnos.Visible = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
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
                    if (temp.Cells[busqueda].Value.ToString().Trim().Contains(Tarjet.Trim()))
                    {
                        encontrados.Add(temp);
                    }
                }
                dgvEtapaUno.Rows.Clear();
                dgvEtapaUno.Rows.AddRange(encontrados.ToArray());
                dgvEtapaUno.ClearSelection();
                Alumno = new clsAlumnoFormateado();
                Alumno.Id = -1;
            }
            catch (Exception a)
            {
                throw new Exception("Se produjo el siguiente error: " + a.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.ActualizarGrillaAlumnos();
        }
    }
}
