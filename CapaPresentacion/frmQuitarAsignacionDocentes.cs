using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using CapaLogica;
using Interfaces;

namespace CapaPresentacion
{
    public partial class frmQuitarAsignacionDocentes : frmPrincipal
    {
        public frmQuitarAsignacionDocentes(clsProfesor Profesor)
        {
            InitializeComponent();
            this.Profesor = Profesor;
        }

        clsProfesor Profesor = new clsProfesor();
        clsRepositorioProfesor RProfesor = new clsRepositorioProfesor();
        bool filtro = false;

        private void frmQuitarAsignacionDocentes_Load(object sender, EventArgs e)
        {
            tbNombre.Text = Profesor.Nombre;
            tbApellido.Text = Profesor.Apellido;
            tbDni.Text = Profesor.Dni;
            tbDireccion.Text = Profesor.Direccion;
            tbTelefono.Text = Profesor.Telefono;
            tbEmail.Text = Profesor.Email;


            dgvCursos.Columns.Add("IdCurso", "IdCurso");
            dgvCursos.Columns.Add("Nombre", "Nombre");
            dgvCursos.Columns.Add("Descripcion", "Descripcion");
            dgvCursos.Columns.Add("FechaInicio", "Fecha Incio");
            dgvCursos.Columns.Add("FechaFin", "Fecha Fin");
            dgvCursos.Columns.Add("CantidadProfesores", "CantidadProfesores");

            dgvCursos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaInicio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaFin"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvCursos.Columns["IdCurso"].Visible = false;

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }
        }


        private void ActualizarGrilla()
        {
            dgvCursos.Rows.Clear();

            try
            {
                List<IEntidad> LE = RProfesor.CursosQueDicta(Profesor.Id);


                foreach (clsCurso ECurso in LE)
                {
                    if (ECurso.Estado == 1)
                    {
                        dgvCursos.Rows.Add();
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["CantidadProfesores"].Value = Convert.ToString(RProfesor.CantidadProfesores(ECurso.Id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarGrillaFiltrada()
        {
            clsCurso temp = new clsCurso();
            if (tbFiltroNombre.Text != string.Empty)
            {
                temp.Nombre = tbFiltroNombre.Text;
            }
            if (ckbFiltroFechaInicio.Checked)
            {
                temp.FechaInicio = Convert.ToDateTime(dtpFiltroFechaInicio.Value);
            }
            if (ckbFiltroFechaFin.Checked)
            {
                temp.FechaFin = Convert.ToDateTime(dtpFiltroFechaFin.Value);
            }

            temp.Estado = 1;

            dgvCursos.Rows.Clear();

            try
            {
                List<IEntidad> LE = RProfesor.CursosQueDicta(Profesor.Id);

                foreach (clsCurso ECurso in LE)
                {
                    dgvCursos.Rows.Add();
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["CantidadProfesores"].Value = Convert.ToString(RProfesor.CantidadProfesores(ECurso.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrillaFiltrada();
            filtro = true;
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnBuscar")
                {
                    btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Grande.png");
                }
                else
                {
                    btnQuitar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Quitar-Grande.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnBuscar")
                {
                    btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Chico.png");
                }
                else
                {
                    btnQuitar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Quitar-Chico.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int IdCurso = Convert.ToInt32(dgvCursos.CurrentRow.Cells["IdCurso"].Value);

            try
            {
                bool resultado = RProfesor.BorrarProfesorACurso(Profesor.Id, IdCurso);

                if (resultado)
                {
                    MessageBox.Show("Se removio el permiso del profesor al curso correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(filtro)
                    {
                        ActualizarGrillaFiltrada();
                    }
                    else
                    {
                        ActualizarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo completar esta accion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
