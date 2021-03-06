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
    public partial class frmCargarAlumnos : frmPrincipal
    {
        public frmCargarAlumnos()
        {
            InitializeComponent();
        }

        clsAlumno Alumno = new clsAlumno();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        bool filtro = false;


        private void frmCargarAlumnos_Load(object sender, EventArgs e)
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
            dgvAlumnos.Columns.Add("Contraseña", "Contraseña");

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


            dgvAlumnos.Columns["IdAlumno"].Visible = false;
            dgvAlumnos.Columns["Contraseña"].Visible = false;

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
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Contraseña"].Value = EAlum.Contraseña;
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

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnAgregar")
                {
                    btnAgregar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Agregar-Grande.png");
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

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnAgregar")
                {
                    btnAgregar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Agregar-Chico.png");
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


        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno.Id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["IdAlumno"].Value);
            Alumno.Nombre = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Nombre"].Value);
            Alumno.Apellido = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Apellido"].Value);
            Alumno.Dni = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Dni"].Value);
            Alumno.Direccion = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Direccion"].Value);
            Alumno.Telefono = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Telefono"].Value);
            Alumno.Email = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Email"].Value);
            Alumno.Contraseña = Convert.ToString(dgvAlumnos.CurrentRow.Cells["Dni"].Value);
            if (Convert.ToString(dgvAlumnos.CurrentRow.Cells["Estado"].Value) == "Habilitado")
            {
                Alumno.Estado = 1;
            }
            else
            {
                Alumno.Estado = 0;
            }

            int FilaSeleccionada = dgvAlumnos.CurrentRow.Index;

            frmModificarAlumnos ModificarAlumnos = new frmModificarAlumnos(Alumno);
            ModificarAlumnos.ShowDialog();

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            if (dgvAlumnos.Rows.Count >= (FilaSeleccionada + 1))
            {
                dgvAlumnos.Rows[FilaSeleccionada].Cells[1].Selected = true;
            }

        }

        private void ActualizarGrillaFiltrada()
        {

            clsAlumno temp = new clsAlumno();
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
                    dgvAlumnos.Rows[dgvAlumnos.Rows.Count - 1].Cells["Contraseña"].Value = EAlum.Contraseña;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrillaFiltrada();
            filtro = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty && tbDireccion.Text != string.Empty && tbTelefono.Text != string.Empty && tbEmail.Text != string.Empty)
            {
                try
                {
                    if (tbDni.Text.Length == 8)
                    {
                        Repo = RepoF.getRepositorio(RepoType.ALUMNO);

                        Alumno.Nombre = tbNombre.Text;
                        Alumno.Apellido = tbApellido.Text;
                        Alumno.Dni = tbDni.Text;
                        Alumno.Direccion = tbDireccion.Text;
                        Alumno.Telefono = tbTelefono.Text;
                        Alumno.Email = tbEmail.Text;
                        Alumno.Estado = 1;
                        Alumno.Contraseña = tbDni.Text;

                        Repo.Agregar(Alumno);

                        if (!filtro)
                        {
                            ActualizarGrilla();
                        }
                        else
                        {
                            ActualizarGrillaFiltrada();
                        }

                        MessageBox.Show("Alumno cargado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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






    }
}
