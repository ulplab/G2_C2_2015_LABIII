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
    public partial class frmModificarAlumnos : frmPrincipal
    {
        public frmModificarAlumnos(clsAlumno Alumno)
        {
            InitializeComponent();
            this.Alumno = Alumno;
        }

        clsAlumno Alumno;
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
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

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
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

        private void frmModificarAlumnos_Load(object sender, EventArgs e)
        {
            CargarTextBox();
        }

        private void CargarTextBox()
        {
            if(Alumno != null)
            {
                tbNombre.Text = Alumno.Nombre;
                tbApellido.Text = Alumno.Apellido;
                tbDni.Text = Convert.ToString(Alumno.Dni);
                tbDireccion.Text = Alumno.Direccion;
                tbTelefono.Text = Alumno.Telefono;
                tbEmail.Text = Alumno.Email;
                if (Alumno.Estado == 1)
                {
                    ckbEstado.Checked = true;
                }
                else
                {
                    ckbEstado.Checked = false;
                }
            }
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



        private void GuardarCambios()
        {
            if (tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty && tbDireccion.Text != string.Empty && tbTelefono.Text != string.Empty && tbEmail.Text != string.Empty)
            {
                try
                {
                    if (tbDni.Text.Length == 8)
                    {
                        Repo = RepoF.getRepositorio(RepoType.ALUMNO);
                        clsAlumno AlumnoModificado = new clsAlumno();

                        AlumnoModificado.Id = Alumno.Id;
                        AlumnoModificado.Nombre = tbNombre.Text;
                        AlumnoModificado.Apellido = tbApellido.Text;
                        AlumnoModificado.Dni = Convert.ToInt32(tbDni.Text);
                        AlumnoModificado.Direccion = tbDireccion.Text;
                        AlumnoModificado.Telefono = tbTelefono.Text;
                        AlumnoModificado.Email = tbEmail.Text;
                        AlumnoModificado.Estado = Convert.ToInt32(ckbEstado.Checked);

                        Repo.Actualizar(AlumnoModificado);
                        Alumno = AlumnoModificado;

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == Alumno.Nombre && tbApellido.Text == Alumno.Apellido && Convert.ToInt32(tbDni.Text) == Alumno.Dni && tbDireccion.Text == Alumno.Direccion && tbTelefono.Text == Alumno.Telefono && tbEmail.Text == Alumno.Email && Convert.ToInt32(ckbEstado.Checked) == Alumno.Estado)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == Alumno.Nombre && tbApellido.Text == Alumno.Apellido && Convert.ToInt32(tbDni.Text) == Alumno.Dni && tbDireccion.Text == Alumno.Direccion && tbTelefono.Text == Alumno.Telefono && tbEmail.Text == Alumno.Email && Convert.ToInt32(ckbEstado.Checked) == Alumno.Estado)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

 




    }
}
