﻿using System;
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

            btnDesactivarFiltro.BackColor = Color.Red;

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
                    if (EAdmin.Estado)
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

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty && tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty && tbTelefono.Text != string.Empty)
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
                        Administrador.Dni = Convert.ToInt32(tbDni.Text);
                        Administrador.Telefono = tbTelefono.Text;
                        Administrador.Estado = true;

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
            Administrador.Dni = Convert.ToInt32(dgvAdministradores.CurrentRow.Cells["Dni"].Value);
            Administrador.Telefono = Convert.ToString(dgvAdministradores.CurrentRow.Cells["Telefono"].Value);

            if (Convert.ToString(dgvAdministradores.CurrentRow.Cells["Estado"].Value) == "Habilitado")
            {
                Administrador.Estado = true;
            }
            else
            {
                Administrador.Estado = false;
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


            query = "SELECT * " +
                    "FROM Administradores " +
                    "WHERE Usuario LIKE '" + tbFiltroUsuario.Text + "%' " +
                    "AND Apellido LIKE '" + tbFiltroApellido.Text + "%' " +
                    "AND cast(Dni as varchar(10)) LIKE'" + tbFiltroDni.Text + "%' ";
            if (cbFiltroEstado.SelectedItem != "Todos")
            {
                if (cbFiltroEstado.SelectedItem == "Habilitados")
                {
                    query += "AND Estado = 1;";
                }
                else
                {
                    query += "AND Estado = 0;";
                }
            }

            dgvAdministradores.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.ADMINISTRADOR);
                List<IEntidad> LE = Repo.Lista(query);

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
                    if (EAdmin.Estado)
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

        private void tbFiltroUsuario_TextChanged(object sender, EventArgs e)
        {
            if (filtro)
            {
                ActualizarGrillaFiltrada();
            }
        }
     

    }
}