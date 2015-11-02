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
    public partial class frmCargarDocentes : frmPrincipal
    {
        public frmCargarDocentes()
        {
            InitializeComponent();
        }
        clsProfesor Profesor = new clsProfesor();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        bool filtro = false;

        private void frmCargarDocentes_Load(object sender, EventArgs e)
        {
            Repo = RepoF.getRepositorio(RepoType.PROFESOR);

            dgvDocentes.Columns.Add("IdProfesor", "IdProfesor");
            dgvDocentes.Columns.Add("Nombre", "Nombre");
            dgvDocentes.Columns.Add("Apellido", "Apellido");
            dgvDocentes.Columns.Add("Dni", "Dni");
            dgvDocentes.Columns.Add("Direccion", "Direccion");
            dgvDocentes.Columns.Add("Telefono", "Telefono");
            dgvDocentes.Columns.Add("Email", "Email");
            dgvDocentes.Columns.Add("Estado", "Estado");

            dgvDocentes.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDocentes.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;

            cbFiltroEstado.Items.Add("Habilitados");
            cbFiltroEstado.Items.Add("Deshabilitados");
            cbFiltroEstado.Items.Add("Todos");
            cbFiltroEstado.SelectedItem = "Todos";

            btnDesactivarFiltro.BackColor = Color.Red;

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
                    //dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                    if (EPro.Estado == 1)
                    {
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnAgregar")
                {
                    btnAgregar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Agregar-Grande.png");
                }
                else
                {
                    btnCancelar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Bonton-Cancelar-Grande.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnAgregar")
                {
                    btnAgregar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Agregar-Chico.png");
                }
                else
                {
                    btnCancelar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Bonton-Cancelar-Chico.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty)
            {
                try
                {
                    if (tbDni.Text.Length == 8)
                    {
                        Repo = RepoF.getRepositorio(RepoType.ALUMNO);

                        Profesor.Nombre = tbNombre.Text;
                        Profesor.Apellido = tbApellido.Text;
                        Profesor.Dni = tbDni.Text;
                        Profesor.Direccion = tbDireccion.Text;
                        Profesor.Telefono = tbTelefono.Text;
                        //Profesor.Email = tbEmail.Text;
                        Profesor.Estado = 1;

                        Repo.Agregar(Profesor);

                        if (!filtro)
                        {
                            ActualizarGrilla();
                        }
                        else
                        {
                            ActualizarGrillaFiltrada();
                        }

                        MessageBox.Show("Docente cargado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbNombre.Clear();
                        tbApellido.Clear();
                        tbDni.Clear();
                        tbDireccion.Clear();
                        tbTelefono.Clear();
                        tbEmail.Clear();
                        tbNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Dni ingresado no valido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDni.Clear();
                        tbDni.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Profesor.Email = Convert.ToString(dgvDocentes.CurrentRow.Cells["Email"].Value);
            if (Convert.ToString(dgvDocentes.CurrentRow.Cells["Estado"].Value) == "Habilitado")
            {
                Profesor.Estado = 1;
            }
            else
            {
                Profesor.Estado = 0;
            }

            int FilaSeleccionada = dgvDocentes.CurrentRow.Index;

            frmModificarProfesor ModificarAlumnos = new frmModificarProfesor(Profesor);
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
            string query = string.Empty;

            clsProfesor temp = new clsProfesor();
            temp.Nombre = tbFiltroNombre.Text;
            temp.Apellido = tbFiltroApellido.Text;
            temp.Dni = tbFiltroDni.Text;

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
                    //dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Email"].Value = EPro.Email;
                    if (EPro.Estado == 1)
                    {
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvDocentes.Rows[dgvDocentes.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
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

