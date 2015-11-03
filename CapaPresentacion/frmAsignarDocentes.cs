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
    public partial class frmAsignarDocentes : frmPrincipal
    {
        public frmAsignarDocentes()
        {
            InitializeComponent();
        }

        clsProfesor Profesor = new clsProfesor();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        clsRepositorioProfesor RProfesor = new clsRepositorioProfesor();
        bool filtro = false;

        private void frmAsignarProfesores_Load(object sender, EventArgs e)
        {
            Repo = RepoF.getRepositorio(RepoType.PROFESOR);

            dgvDocentes.Columns.Add("IdProfesor", "IdProfesor");
            dgvDocentes.Columns.Add("Nombre", "Nombre");
            dgvDocentes.Columns.Add("Apellido", "Apellido");
            dgvDocentes.Columns.Add("Dni", "Dni");
            dgvDocentes.Columns.Add("Direccion", "Direccion");
            dgvDocentes.Columns.Add("Telefono", "Telefono");
            dgvDocentes.Columns.Add("Email", "Email");
            dgvDocentes.Columns.Add("CantidadCursos", "Cantidad Cursos");

            dgvDocentes.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvDocentes.Columns["IdProfesor"].Visible = false;

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
            dgvDocentes.Rows.Clear();

            try
            {
                List<IEntidad> LE = Repo.Lista();

                foreach (clsProfesor EPro in LE)
                {
                    dgvDocentes.Rows.Add();
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["IdProfesor"].Value = EPro.Id;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Nombre"].Value = EPro.Nombre;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Apellido"].Value = EPro.Apellido;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Dni"].Value = EPro.Dni;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Direccion"].Value = EPro.Direccion;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Telefono"].Value = EPro.Telefono;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["CantidadCursos"].Value = Convert.ToString(RProfesor.CantidadCursos(EPro.Id));
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

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnBuscar")
                {
                    btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Chico.png");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnBuscar")
                {
                    btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Grande.png");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void dgvDocentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Profesor.Id = Convert.ToInt32(dgvDocentes.CurrentRow.Cells["IdProfesor"].Value);
            Profesor.Nombre = Convert.ToString(dgvDocentes.CurrentRow.Cells["Nombre"].Value);
            Profesor.Apellido = Convert.ToString(dgvDocentes.CurrentRow.Cells["Apellido"].Value);
            Profesor.Dni = Convert.ToString(dgvDocentes.CurrentRow.Cells["Dni"].Value);
            Profesor.Direccion = Convert.ToString(dgvDocentes.CurrentRow.Cells["Direccion"].Value);
            Profesor.Telefono = Convert.ToString(dgvDocentes.CurrentRow.Cells["Telefono"].Value);
            Profesor.Email = Convert.ToString(dgvDocentes.CurrentRow.Cells["Email"].Value);

            int FilaSeleccionada = dgvDocentes.CurrentRow.Index;

            frmModificarDocente ModificarAlumnos = new frmModificarDocente(Profesor);
            ModificarAlumnos.ShowDialog();

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            if (dgvDocentes.Rows.Count >= (FilaSeleccionada + 1))
            {
                dgvDocentes.Rows[FilaSeleccionada].Cells[1].Selected = true;
            }
        }

        private void ActualizarGrillaFiltrada()
        {

            clsProfesor temp = new clsProfesor();
            if (tbFiltroNombre.Text != string.Empty)
            {
                temp.Nombre = tbFiltroNombre.Text;
            }
            if (tbFiltroApellido.Text != string.Empty)
            {
                temp.Apellido = tbFiltroApellido.Text;
            }
            if (tbFiltroDni.Text != string.Empty)
            {
                temp.Dni = tbFiltroDni.Text;
            }

            dgvDocentes.Rows.Clear();

            try
            {
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsProfesor EPro in LE)
                {
                    dgvDocentes.Rows.Add();
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["IdProfesor"].Value = EPro.Id;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Nombre"].Value = EPro.Nombre;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Apellido"].Value = EPro.Apellido;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Dni"].Value = EPro.Dni;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Direccion"].Value = EPro.Direccion;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Telefono"].Value = EPro.Telefono;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                    dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["CantidadCursos"].Value = Convert.ToString(RProfesor.CantidadCursos(EPro.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
