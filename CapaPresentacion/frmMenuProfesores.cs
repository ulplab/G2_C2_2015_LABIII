using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Interfaces;

namespace CapaPresentacion
{
    public partial class frmMenuProfesores : frmPrincipal
    {
        public frmMenuProfesores(IEntidad usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        IEntidad usuario;

        private void btnRegistrosCalificaciones_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnInscribirAlumno")
                {
                    btnInscribirAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAlumnosACursos-140x140.png");
                }
                else if ((sender as Button).Name == "btnDarBajaInscripcion")
                {
                    btnDarBajaInscripcion.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\BajaInscripcion-140x140.png");
                }
                else if ((sender as Button).Name == "btnRegistrosCalificaciones")
                {
                    btnRegistrosCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Calificaciones-140x140.png");
                }
                else
                {
                    btnAsignarCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AsignarCalificaciones-140x140.png");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnRegistrosCalificaciones_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnInscribirAlumno")
                {
                    btnInscribirAlumno.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarAlumnosACursos-120x120.png");
                }
                else if ((sender as Button).Name == "btnDarBajaInscripcion")
                {
                    btnDarBajaInscripcion.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\BajaInscripcion-120x120.png");
                }
                else if ((sender as Button).Name == "btnRegistrosCalificaciones")
                {
                    btnRegistrosCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Calificaciones-120x120.png");
                }
                else
                {
                    btnAsignarCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AsignarCalificaciones-120x120.png");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnInscribirAlumno_Click(object sender, EventArgs e)
        {
            frmInscripcionCurso InscribirCurso = new frmInscripcionCurso();
            this.Visible = false;
            InscribirCurso.ShowDialog();
            this.Visible = true;
        }

        private void btnDarBajaInscripcion_Click(object sender, EventArgs e)
        {
            frmBajarAlumnos BajarAlumnos = new frmBajarAlumnos();
            this.Visible = false;
            BajarAlumnos.ShowDialog();
            this.Visible = true;
        }

        private void btnAsignarCalificaciones_Click(object sender, EventArgs e)
        {
            frmNotas Notas = new frmNotas();
            this.Visible = false;
            Notas.ShowDialog();
            this.Visible = true;
        }

        private void btnRegistrosCalificaciones_Click(object sender, EventArgs e)
        {
            //frmRegistroCalificaciones RegistroCalificaciones = new frmRegistroCalificaciones();
            this.Visible = false;
            //RegistroCalificaciones.ShowDialog();
            this.Visible = true;
        }

        private void MenuProfesores_Load(object sender, EventArgs e)
        {
            ousEncabezado.Titulo += "    Profesor: " + ((clsProfesor)usuario).Apellido;
            ousPie.Usuario = ((clsProfesor)usuario).Nombre;
        }

        void Cerrar()
        {
            DialogResult prompt = MessageBox.Show("¿Desea cerrar la aplicación? ", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (prompt == DialogResult.OK)
            {
                Application.Restart();
            }

        }

        private void ousEncabezado_Load(object sender, EventArgs e)
        {
            ousEncabezado.evCerrar += new Controles.usEncabezado.delHeader(Cerrar);
        }
    }
}
