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
    public partial class frmRegistroCalificaciones : frmPrincipal
    {
        public frmRegistroCalificaciones()
        {
            InitializeComponent();

        }

        clsAlumno Alumno = new clsAlumno();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        bool filtro = false;

        private void frmRegistroCalificaciones_Load(object sender, EventArgs e)
        {

            Repo = RepoF.getRepositorio(RepoType.ALUMNO);

            dgvAlumnos.Columns.Add("IdAlumno", "IdAlumno");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Apellido", "Apellido");
            dgvAlumnos.Columns.Add("Dni", "Dni");
            dgvAlumnos.Columns.Add("Direccion", "Direccion");
            dgvAlumnos.Columns.Add("Telefono", "Telefono");
            dgvAlumnos.Columns.Add("Email", "Email");
            dgvAlumnos.Columns.Add("Estado", "Estado");

            dgvAlumnos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlumnos.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;

            cbFiltroEstado.Items.Add("Habilitados");
            cbFiltroEstado.Items.Add("Deshabilitados");
            cbFiltroEstado.Items.Add("Todos");
            cbFiltroEstado.SelectedItem = "Todos";

            btnDesactivarFiltro.BackColor = Color.Red;

            dgvAlumnos.Columns["IdAlumno"].Visible = false;

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
            dgvAlumnos.Rows.Clear();

            try
            {
                List<IEntidad> LE = Repo.Lista();

                foreach (clsAlumno EAlum in LE)
                {
                    dgvAlumnos.Rows.Add();
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["IdAlumno"].Value = EAlum.Id;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Nombre"].Value = EAlum.Nombre;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Apellido"].Value = EAlum.Apellido;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Dni"].Value = EAlum.Dni;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Direccion"].Value = EAlum.Direccion;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Telefono"].Value = EAlum.Telefono;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Email"].Value = EAlum.Email;
                    if (EAlum.Estado == 1)
                    {
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
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
            clsAlumno temp = new clsAlumno();
            temp.Nombre = tbFiltroNombre.Text;
            temp.Apellido = tbFiltroApellido.Text;
            temp.Dni = Convert.ToInt32(tbFiltroDni.Text);

            if (cbFiltroEstado.SelectedItem.ToString() != "Todos")
            {
                if (cbFiltroEstado.SelectedItem.ToString() == "Habilitados")
                {
                    temp.Estado = 1;
                }
                else
                {
                    temp.Estado = 0;
                }
            }

            dgvAlumnos.Rows.Clear();

            try
            {
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsAlumno EAlum in LE)
                {
                    dgvAlumnos.Rows.Add();
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["IdAlumno"].Value = EAlum.Id;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Nombre"].Value = EAlum.Nombre;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Apellido"].Value = EAlum.Apellido;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Dni"].Value = EAlum.Dni;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Direccion"].Value = EAlum.Direccion;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Telefono"].Value = EAlum.Telefono;
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Email"].Value = EAlum.Email;
                    if (EAlum.Estado == 1)
                    {
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActivarFiltro_Click(object sender, EventArgs e)
        {
            btnActivarFiltro.BackColor = Color.Lime;
            btnDesactivarFiltro.BackColor = Color.Transparent;
            filtro = true;
            ActualizarGrillaFiltrada();
        }

        private void btnDesactivarFiltro_Click(object sender, EventArgs e)
        {

            btnDesactivarFiltro.BackColor = Color.Red;
            btnActivarFiltro.BackColor = Color.Transparent;
            filtro = false;
            ActualizarGrilla();
        }


    }
}
