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
    public partial class frmModificarCursos : frmPrincipal
    {
        public frmModificarCursos(clsCurso Curso)
        {
            InitializeComponent();
            this.Curso = Curso;
        }

        clsCurso Curso = new clsCurso();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnGuardar")
                {
                    btnGuardar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Guardar-Grande.png");
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
                if ((sender as Button).Name == "btnGuardar")
                {
                    btnGuardar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Boton-Guardar-Chico.png");
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

        private void frmModificarCursos_Load(object sender, EventArgs e)
        {
            CargarTextBox();

        }

        private void CargarTextBox()
        {
            if (Curso != null)
            {
                tbNombre.Text = Curso.Nombre;
                tbDescripcion.Text = Curso.Descripcion;
                dtpFechaIncio.Value = Curso.FechaInicio;
                dtpFechaFin.Value = Curso.FechaFin;
                tbValorCurso.Text = Convert.ToString(Curso.Precio);
                if (Curso.Estado == 1)
                {
                    ckbEstado.Checked = true;
                }
                else
                {
                    ckbEstado.Checked = false;
                }
            }
        }

        private void GuardarCambios()
        {
            if (tbNombre.Text != string.Empty && tbDescripcion.Text != string.Empty)
            {
                try
                {

                    Repo = RepoF.getRepositorio(RepoType.CURSO);
                    clsCurso CursoModificado = new clsCurso();

                    CursoModificado.Id = Convert.ToInt32(Curso.Id);
                    CursoModificado.Nombre = tbNombre.Text;
                    CursoModificado.Descripcion = tbDescripcion.Text;
                    CursoModificado.FechaInicio = Convert.ToDateTime(dtpFechaIncio.Value);
                    CursoModificado.FechaFin = Convert.ToDateTime(dtpFechaFin.Value);
                    CursoModificado.Estado = Convert.ToInt32(ckbEstado.Checked);
                    CursoModificado.Precio = Convert.ToDouble(tbValorCurso.Text);

                    Repo.Actualizar(CursoModificado);
                    Curso = CursoModificado;

                    MessageBox.Show("Curso modificado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbNombre.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarTextBox();
                    tbNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarTextBox();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        void Cerrar()
        {
            if (tbNombre.Text == Curso.Nombre && tbDescripcion.Text == Curso.Descripcion && dtpFechaIncio.Value == Curso.FechaInicio && dtpFechaFin.Value == Curso.FechaFin && Convert.ToDouble(tbValorCurso.Text) == Curso.Precio)
            {
                this.Close();
            }
            else
            {
                DialogResult prompt = MessageBox.Show("¿Desea guardar los cambios efectuados? ", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (prompt == DialogResult.OK)
                {
                    GuardarCambios();
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            }
        }


        private void ousEncabezado_Load(object sender, EventArgs e)
        {
            ousEncabezado.evCerrar += new Controles.usEncabezado.delHeader(Cerrar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }





    }
}
