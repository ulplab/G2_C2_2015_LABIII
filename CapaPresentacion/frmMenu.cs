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
    public partial class frmMenu : frmPrincipal
    {
        IEntidad usuario;
        NivelSeguridad seguridad;

        public frmMenu(IEntidad usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ousEncabezado.Titulo += "    Administrador: " + ((clsAdministrador)usuario).Usuario;
            ousPie.Usuario = ((clsAdministrador)usuario).Usuario;

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
                else if ((sender as Button).Name == "btnRegistrosInstituto")
                {
                    btnRegistrosInstituto.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Registros-140x140.png");
                }
                else if ((sender as Button).Name == "btnEstadisticas")
                {
                    btnEstadisticas.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Estadisticas-140x140.png");
                }
                else if ((sender as Button).Name == "btnRegistrosCalificaciones")
                {
                    btnRegistrosCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Calificaciones-140x140.png");
                }
                else if ((sender as Button).Name == "btnAsignarProfesor")
                {
                    btnAsignarProfesor.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Asignar-Profesor-140x140.png");
                }
                else if ((sender as Button).Name == "btnAsignarCalificaciones")
                {
                    btnAsignarCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AsignarCalificaciones-140x140.png");
                }
                else if ((sender as Button).Name == "btnMorosos")
                {
                    btnMorosos.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\morosos-Grande.png");
                }
                else if ((sender as Button).Name == "btnPagarCuota")
                {
                    btnPagarCuota.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\pagar_cuota-Grande.png");
                }
                else
                {
                    btnAgregarDocentes.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarDocentes-140x140.png");
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
                else if ((sender as Button).Name == "btnRegistrosInstituto")
                {
                    btnRegistrosInstituto.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Registros-120x120.png");
                }
                else if ((sender as Button).Name == "btnEstadisticas")
                {
                    btnEstadisticas.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Estadisticas-120x120.png");
                }
                else if ((sender as Button).Name == "btnRegistrosCalificaciones")
                {
                    btnRegistrosCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Calificaciones-120x120.png");
                }
                else if ((sender as Button).Name == "btnAsignarProfesor")
                {
                    btnAsignarProfesor.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\Asignar-Profesor-120x120.png");
                }
                else if ((sender as Button).Name == "btnAsignarCalificaciones")
                {
                    btnAsignarCalificaciones.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AsignarCalificaciones-120x120.png");
                }
                else if ((sender as Button).Name == "btnMorosos")
                {
                    btnMorosos.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\morosos-Chico.png");
                }
                else if ((sender as Button).Name == "btnPagarCuota")
                {
                    btnPagarCuota.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\pagar_cuota-Chico.png");
                }
                else
                {
                    btnAgregarDocentes.Image = Image.FromFile(@"..\\..\\Imagenes\IconosMenu\AgregarDocentes-120x120.png");
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
            frmInscripcionCurso InscribirCurso = new frmInscripcionCurso();
            this.Visible = false;
            InscribirCurso.ShowDialog();
            this.Visible = true;
        }

        private void btnAlumnosPorCurso_Click(object sender, EventArgs e)
        {
            frmAlumnosPorCurso AlumnosPorCurso = new frmAlumnosPorCurso();
            AlumnosPorCurso.ShowDialog();
        }
        private void btnDarBajaInscripcion_Click(object sender, EventArgs e)
        {
            frmBajarAlumnos BajarAlumnos = new frmBajarAlumnos();
            this.Visible = false;
            BajarAlumnos.ShowDialog();
            this.Visible = true;

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmIngresos ConsultarEstadisticas = new frmIngresos();
            this.Visible = false;
            ConsultarEstadisticas.ShowDialog();
            this.Visible = true;
        }

        private void btnRegistrosCalificaciones_Click(object sender, EventArgs e)
        {
          //  GOnza llama al formulario con la sesion iniciada, mandando null en los demas parametros.
            frmRegistroCalificaciones RegistroCalificaciones = new frmRegistroCalificaciones((clsAdministrador)usuario,null,null);
            this.Visible = false;
            RegistroCalificaciones.ShowDialog();
            this.Visible = true;
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

        private void btnAgregarDocentes_Click(object sender, EventArgs e)
        {
            frmCargarDocentes CargarDocentes = new frmCargarDocentes();
            CargarDocentes.ShowDialog();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmRegistrarCuota RegistrarCuota = new frmRegistrarCuota();
            this.Visible = false;
            RegistrarCuota.ShowDialog();
            this.Visible = true;
        }

        private void btnAsignarProfesor_Click(object sender, EventArgs e)
        {
            frmAsignarDocentes AsignarDocentes = new frmAsignarDocentes();
            AsignarDocentes.ShowDialog();
        }


        private void btnAsignarCalificaciones_Click(object sender, EventArgs e)
        {
            frmNotas Notas = new frmNotas((clsAdministrador) usuario,null);
            this.Visible = false;
            Notas.ShowDialog();
            this.Visible = true;
        }

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            frmAlumnosMorosos AlumnosMorosos = new frmAlumnosMorosos();
            this.Visible = false;
            AlumnosMorosos.ShowDialog();
            this.Visible = true;
        }









     


    }
}
