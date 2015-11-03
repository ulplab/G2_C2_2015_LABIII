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
    public partial class frmCargarCursos : frmPrincipal
    {
        public frmCargarCursos()
        {
            InitializeComponent();
        }

        clsCurso Curso = new clsCurso();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;
        bool filtro = false;
        private void frmCargarCursos_Load(object sender, EventArgs e)
        {
            dgvCursos.Columns.Add("IdCurso", "IdCurso");
            dgvCursos.Columns.Add("Nombre", "Nombre");
            dgvCursos.Columns.Add("Descripcion", "Descripcion");
            dgvCursos.Columns.Add("FechaInicio", "Fecha Incio");
            dgvCursos.Columns.Add("FechaFin", "Fecha Fin");
            dgvCursos.Columns.Add("Valor", "Valor $");
            dgvCursos.Columns.Add("Estado", "Estado");

            dgvCursos.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaInicio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["FechaFin"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCursos.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;

            cbFiltroEstado.Items.Add("Habilitados");
            cbFiltroEstado.Items.Add("Deshabilitados");
            cbFiltroEstado.Items.Add("Todos");
            cbFiltroEstado.SelectedItem = "Todos";

            dgvCursos.Columns["IdCurso"].Visible = false;

            ActualizarGrilla();

            dtpFechaIncio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;



        }

        private void ActualizarGrilla()
        {
            dgvCursos.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.CURSO);
                List<IEntidad> LE = Repo.Lista();

                foreach (clsCurso ECurso in LE)
                {
                    dgvCursos.Rows.Add();
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Valor"].Value = ECurso.Precio;
                    if (ECurso.Estado == 1)
                    {
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty && tbDescripcion.Text != string.Empty && tbValorCurso.Text != string.Empty)
            {
                try
                {

                    Repo = RepoF.getRepositorio(RepoType.CURSO);

                    Curso.Nombre = tbNombre.Text;
                    Curso.Descripcion = tbDescripcion.Text;
                    Curso.FechaInicio = Convert.ToDateTime(dtpFechaIncio.Value);
                    Curso.FechaFin = Convert.ToDateTime(dtpFechaFin.Value);
                    Curso.Precio = Convert.ToDouble(tbValorCurso.Text);
                    Curso.Estado = 1;

                    Repo.Agregar(Curso);

                    if (!filtro)
                    {
                        ActualizarGrilla();
                    }
                    else
                    {
                        ActualizarGrillaFiltrada();
                    }

                    MessageBox.Show("Curso cargado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbNombre.Clear();
                    tbDescripcion.Clear();
                    dtpFechaIncio.Value = DateTime.Now;
                    dtpFechaFin.Value = DateTime.Now;
                    tbNombre.Focus();

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

        private void dgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Curso.Id = Convert.ToInt32(dgvCursos.CurrentRow.Cells["IdCurso"].Value);
            Curso.Nombre = Convert.ToString(dgvCursos.CurrentRow.Cells["Nombre"].Value);
            Curso.Descripcion = Convert.ToString(dgvCursos.CurrentRow.Cells["Descripcion"].Value);
            Curso.FechaInicio = Convert.ToDateTime(dgvCursos.CurrentRow.Cells["FechaInicio"].Value);
            Curso.FechaFin = Convert.ToDateTime(dgvCursos.CurrentRow.Cells["FechaFin"].Value);
            Curso.Precio = Convert.ToDouble(dgvCursos.CurrentRow.Cells["Valor"].Value);
            if (Convert.ToString(dgvCursos.CurrentRow.Cells["Estado"].Value) == "Habilitado")
            {
                Curso.Estado = 1;
            }
            else
            {
                Curso.Estado = 0;
            }

            int FilaSeleccionada = dgvCursos.CurrentRow.Index;

            frmModificarCursos ModificarCursos = new frmModificarCursos(Curso);
            ModificarCursos.ShowDialog();

            if (!filtro)
            {
                ActualizarGrilla();
            }
            else
            {
                ActualizarGrillaFiltrada();
            }

            if (dgvCursos.Rows.Count >= (FilaSeleccionada + 1))
            {
                dgvCursos.Rows[FilaSeleccionada].Cells[1].Selected = true;
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

            dgvCursos.Rows.Clear();

            try
            {
                Repo = RepoF.getRepositorio(RepoType.CURSO);
                List<IEntidad> LE = Repo.Lista(temp);

                foreach (clsCurso ECurso in LE)
                {
                    dgvCursos.Rows.Add();
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["IdCurso"].Value = ECurso.Id;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Nombre"].Value = ECurso.Nombre;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Descripcion"].Value = ECurso.Descripcion;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaInicio"].Value = ECurso.FechaInicio;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["FechaFin"].Value = ECurso.FechaFin;
                    dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Valor"].Value = ECurso.Precio;
                    if (ECurso.Estado == 1)
                    {
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Estado"].Value = "Habilitado";
                    }
                    else
                    {
                        dgvCursos.Rows[dgvCursos.Rows.Count - 1].Cells["Estado"].Value = "Deshabilitado";
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

        private void ousEncabezado_Load(object sender, EventArgs e)
        {

        }







    }
}
