using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interfaces;
using Clases;

namespace CapaPresentacion
{
    public partial class frmMenuAlumnos : frmPrincipal
    {
        public frmMenuAlumnos(clsAlumno Alumno)
        {
            InitializeComponent();
            usuario = Alumno;
        }

        IEntidad usuario;

        private void frmMenuAlumnos_Load(object sender, EventArgs e)
        {
            ousEncabezado.Titulo += "    Alumno: " + ((clsAlumno)usuario).Apellido;
            ousPie.Usuario = ((clsAlumno)usuario).Nombre;
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
                else
                {
                    btnRegistrosCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Calificaciones-140x140.png");
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
                else
                {
                    btnRegistrosCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Calificaciones-120x120.png");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnInscribirAlumno_Click(object sender, EventArgs e)
        {
            frmInscripcion2 Inscripcion = new frmInscripcion2((clsAlumno)usuario);
            Inscripcion.ShowDialog();
        }

        private void btnDarBajaInscripcion_Click(object sender, EventArgs e)
        {
            frmBajarAlumno2 Baja = new frmBajarAlumno2((clsAlumno)usuario);
            Baja.ShowDialog();
        }

        private void btnRegistrosCalificaciones_Click(object sender, EventArgs e)
        {
            frmRegistroCalificaciones RegistroCalificaciones = new frmRegistroCalificaciones(null, (clsAlumno)usuario, null);
            this.Visible = false;
            RegistroCalificaciones.ShowDialog();
            this.Visible = true;
        }
    }
}
