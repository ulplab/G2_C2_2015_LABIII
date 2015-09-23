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
        
        public frmLogin()
        {
            InitializeComponent();
        }
        private Point Coordenadas;
        private bool EventoMouseDown = false;


        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbUsuario.Focus();

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            clsAdministrador Administrador = null;

            if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty)
            {
                try
                {
                    Administrador = RepoAdmin.Login(tbUsuario.Text, tbContraseña.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Administrador != null)
                {
                    if (Administrador.Estado)
                    {

                        frmMenu ABMA = new frmMenu(Administrador);
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
                    MessageBox.Show("El usuario o contraseña es invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


           
        }


        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                clsAdministrador Administrador = null;

                if (tbUsuario.Text != string.Empty && tbContraseña.Text != string.Empty)
                {
                    try
                    {
                        Administrador = RepoAdmin.Login(tbUsuario.Text, tbContraseña.Text);


                        if (Administrador != null)
                        {
                            if (Administrador.Estado)
                            {
                                frmMenu ABMA = new frmMenu(Administrador);
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
                            MessageBox.Show("El usuario o contraseña es invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
        }





    }
}
