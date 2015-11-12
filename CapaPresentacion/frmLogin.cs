using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Interfaces;
using Clases;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {

        clsRepositorioAdministrador RepoAdmin = new clsRepositorioAdministrador();
        clsRepositorioAlumno RepoAlum = new clsRepositorioAlumno();
        clsRepositorioProfesor RepoPro = new clsRepositorioProfesor();
        NivelSeguridad Seguridad;
        
        public frmLogin()
        {
            InitializeComponent();
        }
        private Point Coordenadas;
        private bool EventoMouseDown = false;


        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbUsuario.Focus();
            cbNivelSeguridad.Items.Add("Administrador");
            cbNivelSeguridad.Items.Add("Profesor");
            cbNivelSeguridad.Items.Add("Alumno");
            cbNivelSeguridad.SelectedIndex = 0;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnMinimizar")
                {
                    btnMinimizar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\MinimizarChico.png");
                }
                else
                {
                    btnCerrar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\CerrarChico.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnMinimizar")
                {
                    btnMinimizar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\MinimizarGrande.png");
                }
                else
                {
                    btnCerrar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\CerrarGrande.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            int Horizontal, Vertical;

            if (e.Button == MouseButtons.Left)
            {
                Horizontal = -e.X - SystemInformation.FrameBorderSize.Width + 4;
                Vertical = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height + 23;
                Coordenadas = new Point(Horizontal, Vertical);
                EventoMouseDown = true;
            }

        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (EventoMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(Coordenadas.X, Coordenadas.Y);
                Location = mousePos;
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventoMouseDown = false;
            }
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font("Arial", 20, FontStyle.Bold);
            (sender as Button).ForeColor = Color.White;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font("Arial", 16, FontStyle.Bold);
            (sender as Button).ForeColor = Color.Black;
        }

        private void Logeo()
        {

            clsAdministrador Administrador = null;
            clsAlumno Alumno = null;
            clsProfesor Profesor = null;

            if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty)
            {
                try
                {

                    if (cbNivelSeguridad.SelectedIndex == 0)
                    {
                        Administrador = RepoAdmin.Login(tbUsuario.Text, tbContraseña.Text);

                        if (Administrador != null)
                        {
                            if (Administrador.Estado == 1)
                            {

                                frmMenu ABMA = new frmMenu(Administrador, NivelSeguridad.ADMINISTRADOR);
                                this.Hide();
                                ABMA.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Tu cuenta a sido deshabilitada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña invalidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if (cbNivelSeguridad.SelectedIndex == 1)
                    {
                        Profesor = RepoPro.Login(tbUsuario.Text, tbContraseña.Text);

                        if (Profesor != null)
                        {
                            if (Profesor.Estado == 1)
                            {
                                frmMenu ABMA = new frmMenu(Profesor, NivelSeguridad.PROFESOR);
                                this.Hide();
                                ABMA.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Fuiste dado de baja. Consulta con un administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña invalidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbNivelSeguridad.SelectedIndex == 2)
                    {
                        Alumno = RepoAlum.Login(tbUsuario.Text, tbContraseña.Text);

                        if (Alumno != null)
                        {
                            if (Alumno.Estado == 1)
                            {
                                frmMenu ABMA = new frmMenu(Alumno, NivelSeguridad.ALUMNO);
                                this.Hide();
                                ABMA.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Fuiste dado de baja. Consulta con un administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña invalidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logeo();
           
        }

        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Logeo();
            }
                
        }
    }
}
