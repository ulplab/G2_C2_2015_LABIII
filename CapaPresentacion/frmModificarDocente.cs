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
    public partial class frmModificarDocente : frmPrincipal
    {
        public frmModificarDocente(clsProfesor Profesor)
        {
            InitializeComponent();
            this.Profesor = Profesor;
        }

        clsProfesor Profesor;
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;

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

        private void frmModificarProfesor_Load(object sender, EventArgs e)
        {
            CargarTextBox();
        }

        private void CargarTextBox()
        {
            if (Profesor != null)
            {
                tbNombre.Text = Profesor.Nombre;
                tbApellido.Text = Profesor.Apellido;
                tbDni.Text = Convert.ToString(Profesor.Dni);
                tbDireccion.Text = Profesor.Direccion;
                tbTelefono.Text = Profesor.Telefono;
                tbEmail.Text = Profesor.Email;
                tbContraseña.Text = Profesor.Contraseña;
                tbUsuario.Text = Profesor.Dni;
                if (Profesor.Estado == 1)
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
            if (tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty)
            {
                try
                {
                    if (tbDni.Text.Length == 8)
                    {
                        Repo = RepoF.getRepositorio(RepoType.PROFESOR);
                        clsProfesor ProfesorModificado = new clsProfesor();

                        ProfesorModificado.Id = Profesor.Id;
                        ProfesorModificado.Nombre = tbNombre.Text;
                        ProfesorModificado.Apellido = tbApellido.Text;
                        ProfesorModificado.Dni = tbDni.Text;
                        ProfesorModificado.Direccion = tbDireccion.Text;
                        ProfesorModificado.Telefono = tbTelefono.Text;
                        ProfesorModificado.Email = tbEmail.Text;
                        ProfesorModificado.Contraseña = tbContraseña.Text;
                        ProfesorModificado.Estado = Convert.ToInt32(ckbEstado.Checked);

                        Repo.Actualizar(ProfesorModificado);
                        Profesor = ProfesorModificado;
                        tbUsuario.Text = ProfesorModificado.Dni;

                        MessageBox.Show("Los cambios del alumno se guardaron correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        void Cerrar()
        {
            if (tbNombre.Text == Profesor.Nombre && tbApellido.Text == Profesor.Apellido && tbDni.Text == Profesor.Dni && tbDireccion.Text == Profesor.Direccion && tbTelefono.Text == Profesor.Telefono && tbEmail.Text == Profesor.Email && Convert.ToInt32(ckbEstado.Checked) == Profesor.Estado)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }
   






    }
}
