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
    public partial class frmModificarAdministradores : frmPrincipal
    {
        public frmModificarAdministradores(clsAdministrador Administrador)
        {
            InitializeComponent();
            this.Administrador = Administrador;
        }

        clsAdministrador Administrador = new clsAdministrador();
        IRepoFactory RepoF = new clsRepoFactory();
        IRepositorio Repo;


        private void frmModificarAdministradores_Load(object sender, EventArgs e)
        {
            CargarTextBox();
        }

        private void CargarTextBox()
        {
            if (Administrador != null)
            {
                tbUsuario.Text = Administrador.Usuario;
                tbContraseña.Text = Administrador.Contraseña;
                tbNombre.Text = Administrador.Nombre;
                tbApellido.Text = Administrador.Apellido;
                tbDni.Text = Convert.ToString(Administrador.Dni);
                tbTelefono.Text = Administrador.Telefono;
                if (Administrador.Estado)
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
            if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty && tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty && tbTelefono.Text != string.Empty)
            {
                try
                {
                    if (tbDni.Text.Length == 8)
                    {
                        Repo = RepoF.getRepositorio(RepoType.ADMINISTRADOR);
                        clsAdministrador AdministradorModificado = new clsAdministrador();

                        AdministradorModificado.Id = Administrador.Id;
                        AdministradorModificado.Usuario = tbUsuario.Text;
                        AdministradorModificado.Contraseña = tbContraseña.Text;
                        AdministradorModificado.Nombre = tbNombre.Text;
                        AdministradorModificado.Apellido = tbApellido.Text;
                        AdministradorModificado.Dni = Convert.ToInt32(tbDni.Text);
                        AdministradorModificado.Telefono = tbTelefono.Text;
                        AdministradorModificado.Estado = ckbEstado.Checked;

                        Repo.Actualizar(AdministradorModificado);
                        Administrador = AdministradorModificado;

                        MessageBox.Show("Administrador modificado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    CargarTextBox();
                    tbUsuario.Focus();
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
            if (tbUsuario.Text == Administrador.Usuario && tbContraseña.Text == Administrador.Contraseña && tbNombre.Text == Administrador.Nombre && tbApellido.Text == Administrador.Apellido && Convert.ToInt32(tbDni.Text) == Administrador.Dni && tbTelefono.Text == tbTelefono.Text)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty && tbNombre.Text != string.Empty && tbApellido.Text != string.Empty && tbDni.Text != string.Empty && tbTelefono.Text != string.Empty)
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




    }
}
