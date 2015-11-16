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
    }
}
