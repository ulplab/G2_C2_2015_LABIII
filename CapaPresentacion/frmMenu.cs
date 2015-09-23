using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;


namespace CapaPresentacion
{
    public partial class frmMenu : frmPrincipal
    {
        clsAdministrador Administrador = new clsAdministrador();

        public frmMenu(clsAdministrador Administrador)
        {
            InitializeComponent();
            this.Administrador = Administrador;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += "    Usuario: " + Administrador.Usuario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("¿Desea cerrar la aplicación? ", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (prompt == DialogResult.OK)
            {
                Application.Restart();
            }
        }


        private void btnListadoRegistros_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnAgregarAdministrador")
                {
                    btnAgregarAdministrador.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAdministrador-140x140.png");
                }
                else if ((sender as Button).Name == "btnAgregarAlumno")
                {
                    btnAgregarAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAlumnos-140x140.png");
                }
                else if ((sender as Button).Name == "btnAgregarCurso")
                {
                    btnAgregarCurso.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarCursos-140x140.png");
                }
                else if ((sender as Button).Name == "btnInscribirAlumno")
                {
                    btnInscribirAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAlumnosACursos-140x140.png");
                }
                else if ((sender as Button).Name == "btnDarBajaInscripcion")
                {
                    btnDarBajaInscripcion.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\BajaInscripcion-140x140.png");
                }
                else if ((sender as Button).Name == "btnAlumnosPorCurso")
                {
                    btnAlumnosPorCurso.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Registros-140x140.png");
                }
                else
                {
                    btnCursosPorAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Registros-140x140.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnListadoRegistros_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnAgregarAdministrador")
                {
                    btnAgregarAdministrador.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAdministrador-120x120.png");
                }
                else if ((sender as Button).Name == "btnAgregarAlumno")
                {
                    btnAgregarAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAlumnos-120x120.png");
                }
                else if ((sender as Button).Name == "btnAgregarCurso")
                {
                    btnAgregarCurso.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarCursos-120x120.png");
                }
                else if ((sender as Button).Name == "btnInscribirAlumno")
                {
                    btnInscribirAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAlumnosACursos-120x120.png");
                }
                else if ((sender as Button).Name == "btnDarBajaInscripcion")
                {
                    btnDarBajaInscripcion.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\BajaInscripcion-120x120.png");
                }
                else if ((sender as Button).Name == "btnAlumnosPorCurso")
                {
                    btnAlumnosPorCurso.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Registros-120x120.png");
                }
                else
                {
                    btnCursosPorAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Registros-120x120.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnAgregarAdministrador_Click(object sender, EventArgs e)
        {
            frmRegistrarAdministradores RegistrarAdministrador = new frmRegistrarAdministradores();
            RegistrarAdministrador.ShowDialog();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            frmCargarAlumnos CargarAlumnos = new frmCargarAlumnos();
            CargarAlumnos.ShowDialog();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            frmCargarCursos CargarCursos = new frmCargarCursos();
            CargarCursos.ShowDialog();
        }

        private void btnInscribirAlumno_Click(object sender, EventArgs e)
        {
            frmInscribirAlumnos InscribirAlumnos = new frmInscribirAlumnos();
            InscribirAlumnos.ShowDialog();
        }

        private void btnAlumnosPorCurso_Click(object sender, EventArgs e)
        {
            frmAlumnosPorCurso AlumnosPorCurso = new frmAlumnosPorCurso();
            AlumnosPorCurso.ShowDialog();
        }

        private void btnCursosPorAlumno_Click(object sender, EventArgs e)
        {
            frmCursosPorAlumno CursosPorAlumno = new frmCursosPorAlumno();
            CursosPorAlumno.ShowDialog();
        }




     


    }
}
