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
    public partial class frmRegistrarAdministradores : frmPrincipal
    {
        public frmRegistrarAdministradores()
        {
            InitializeComponent();
        }

        clsAdministrador Administrador = new clsAdministrador();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        bool filtro = false;

        private void frmRegistrarAdministrador_Load(object sender, EventArgs e)
        {
            dgvAdministradores.Columns.Add("IdAdministrador", "IdAdministrador");
            dgvAdministradores.Columns.Add("Usuario", "Usuario");
            dgvAdministradores.Columns.Add("Contraseña", "Contraseña");
            dgvAdministradores.Columns.Add("Nombre", "Nombre");
            dgvAdministradores.Columns.Add("Apellido", "Apellido");
            dgvAdministradores.Columns.Add("Dni", "Dni");
            dgvAdministradores.Columns.Add("Telefono", "Telefono");
            dgvAdministradores.Columns.Add("Estado", "Estado");

            dgvAdministradores.Columns["Usuario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAdministradores.Columns["Contraseña"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAdministradores.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAdministradores.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAdministradores.Columns["Dni"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAdministradores.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAdministradores.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;

            cbFiltroEstado.Items.Add("Habilitados");
            cbFiltroEstado.Items.Add("Deshabilitados");
            cbFiltroEstado.Items.Add("Todos");
            cbFiltroEstado.SelectedItem = "Todos";

            dgvAdministradores.Columns["IdAdministrador"].Visible = false;
            dgvAdministradores.Columns["Contraseña"].Visible = false;

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnRegistrar")
                {
                    btnRegistrar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Bonton-Registrar-Grande.png");
                }
                else if ((sender as Button).Name == "btnBuscar")
                {
                    btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Grande.png");
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

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnRegistrar")
                {
                    btnRegistrar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Bonton-Registrar-Chico.png");
                }
                else if ((sender as Button).Name == "btnBuscar")
                {
                    btnBuscar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Buscar-Chico.png");
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

        private void ActualizarGrilla()
        {
            dgvAdministradores.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.ADMINISTRADOR);
                List<IEntidad> LE = Repo.Lista();

                foreach (clsAdministrador EAdmin in LE)
                {
                    dgvAdministradores.Rows.Add();
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["IdAdministrador"].Value = EAdmin.Id;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Usuario"].Value = EAdmin.Usuario;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Contraseña"].Value = EAdmin.Contraseña;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Nombre"].Value = EAdmin.Nombre;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Apellido"].Value = EAdmin.Apellido;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Dni"].Value = EAdmin.Dni;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Telefono"].Value = EAdmin.Telefono;
                    if (EAdmin.Estado == 1)
                    {
                        dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty && tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty)
            {
                try
                {
                    if (tbDni.Text.Length == 8)
                    {
                        Repo = RepoF.getRepositorio(RepoType.ADMINISTRADOR);

                        Administrador.Usuario = tbUsuario.Text;
                        Administrador.Contraseña = tbContraseña.Text;
                        Administrador.Nombre = tbNombre.Text;
                        Administrador.Apellido = tbApellido.Text;
                        Administrador.Dni = tbDni.Text;
                        Administrador.Telefono = tbTelefono.Text;
                        Administrador.Estado = 1;

                        Repo.Agregar(Administrador);

                        if (!filtro)
                        {
                            ActualizarGrilla();
                        }
                        else
                        {
                            ActualizarGrillaFiltrada();
                        }

                        MessageBox.Show("Administrador registrador correctamente", "AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        tbUsuario.Clear();
                        tbContraseña.Clear();
                        tbNombre.Clear();
                        tbApellido.Clear();
                        tbDni.Clear();
                        tbTelefono.Clear();
                        tbUsuario.Focus();
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

        private void dgvAdministradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Administrador.Id = Convert.ToInt32(dgvAdministradores.CurrentRow.Cells["IdAdministrador"].Value);
            Administrador.Usuario = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Usuario"].Value);
            Administrador.Contraseña = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Contraseña"].Value);
            Administrador.Nombre = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Nombre"].Value);
            Administrador.Apellido = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Apellido"].Value);
            Administrador.Dni = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Dni"].Value);
            Administrador.Telefono = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Telefono"].Value);

            if (Convert.ToString(dgvAdministradores.CurrentRow.Cells["Estado"].Value) == "Habilitado")
            {
                Administrador.Estado = 1;
            }
            else
            {
                Administrador.Estado = 0;
            }

            int FilaSeleccionada = dgvAdministradores.CurrentRow.Index;

            frmModificarAdministradores ModificarAdministradores = new frmModificarAdministradores(Administrador);
            ModificarAdministradores.ShowDialog();

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            if (dgvAdministradores.Rows.Count >= (FilaSeleccionada + 1))
            {
                dgvAdministradores.Rows[FilaSeleccionada].Cells[1].Selected = true;
            }
        }


        private void ActualizarGrillaFiltrada()
        {
            string query = string.Empty;
            clsAdministrador temp = new clsAdministrador();

            if (tbFiltroUsuario.Text != null)
            {
                temp.Usuario = tbFiltroUsuario.Text;
            }
            if (tbFiltroApellido.Text != string.Empty)
            {
                temp.Apellido = tbFiltroApellido.Text;
            }
            if (tbFiltroDni.Text != string.Empty)
            {
                temp.Dni = tbFiltroDni.Text;
            }

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

            dgvAdministradores.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.ADMINISTRADOR);
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsAdministrador EAdmin in LE)
                {
                    dgvAdministradores.Rows.Add();
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["IdAdministrador"].Value = EAdmin.Id;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Usuario"].Value = EAdmin.Usuario;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Contraseña"].Value = EAdmin.Contraseña;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Nombre"].Value = EAdmin.Nombre;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Apellido"].Value = EAdmin.Apellido;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Dni"].Value = EAdmin.Dni;
                    dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Telefono"].Value = EAdmin.Telefono;
                    if (EAdmin.Estado == 1)
                    {
                        dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvAdministradores.Rows[dgvAdministradores.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
                    }
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



    }
}
