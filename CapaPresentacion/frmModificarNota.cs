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
using CapaLogica;
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class frmModificarNota : frmPrincipal
    {
        public frmModificarNota(clsNotaFormateada Nota)
        {
            InitializeComponent();
            nota_Original = new clsNota();
            nota_Original.Id = Nota.Id;
            nota_Original.Nota = Nota.Nota;
            nota_Original.Estado = Nota.Estado;
            nota_Original.Fecha = nota_Original.Fecha;
        }

        private clsNota nota_Original;
        private clsRepositorioAlumno alumno_Consultador;
        private clsRepositorioCurso curso_Consultador;
        private clsRepositorioNota nota_Consultador;
        private clsAlumno Alumno;
        private clsAlumno Alumno_nuevo;
        private clsCurso Curso;
        private clsCurso Curso_Nuevo;

        private void frmModificarNota_Load(object sender, EventArgs e)
        {
            alumno_Consultador = new clsRepositorioAlumno();
            curso_Consultador = new clsRepositorioCurso();
            nota_Consultador = new clsRepositorioNota();
            Alumno = (clsAlumno) alumno_Consultador.ObtenerPorId(nota_Original.IdAlumno);
            Curso = (clsCurso)curso_Consultador.ObtenerPorId(nota_Original.IdCurso);
            tbNombre.Text = Alumno.Nombre + " " + Alumno.Apellido;
            tbCurso.Text = Curso.Nombre;
            tbCalificacion.Text = nota_Original.Nota.ToString().Replace('.',',');
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarAlumno_Click(object sender, EventArgs e)
        {
            frmCambioDeAlumno Cambiar = new frmCambioDeAlumno(Alumno,Alumno_nuevo);
            this.Visible = false;
            Cambiar.ShowDialog();
            Alumno_nuevo = Cambiar.Alumno;
            tbNombre.Text = Alumno_nuevo.Nombre + " " + Alumno_nuevo.Apellido;
            if (Alumno_nuevo.Id != Alumno.Id)
            {
                this.tbCurso.Text = "Sin seleccionar";
            }
            else
            {
                this.tbCurso.Text = Curso.Nombre;
            }
            this.Visible = true;        
        }

        private void btnCambiarCurso_Click(object sender, EventArgs e)
        {
            if (Alumno_nuevo != null)
            {
                if (Alumno.Id == Alumno_nuevo.Id)
                {
                    frmCambiarCurso Cambiar_Curso = new frmCambiarCurso(Alumno, Curso);
                    this.Visible = false;
                    Cambiar_Curso.ShowDialog();
                    if (Cambiar_Curso.Curso != null)
                    {
                        Curso_Nuevo = Cambiar_Curso.Curso;
                        tbCurso.Text = Curso_Nuevo.Nombre;
                    }
                    this.Visible = true;
                }
                else
                {
                    frmCambiarCurso Cambiar_Curso = new frmCambiarCurso(Alumno_nuevo, Curso);
                    this.Visible = false; 
                    Cambiar_Curso.ShowDialog();
                    if (Cambiar_Curso.Curso != null)
                    {
                        Curso_Nuevo = Cambiar_Curso.Curso;
                        tbCurso.Text = Curso_Nuevo.Nombre;
                    }
                    this.Visible = true;
                }
            }
            else
            {
                frmCambiarCurso Cambiar_Curso = new frmCambiarCurso(Alumno, Curso);
                this.Visible = false;
                Cambiar_Curso.ShowDialog();
                if (Cambiar_Curso.Curso != null)
                {
                    Curso_Nuevo = Cambiar_Curso.Curso;
                    tbCurso.Text = Curso_Nuevo.Nombre;
                }
                this.Visible = true;
            }
        }

        private void btnCambiarNota_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCalificacion.Text))
            {
                string expresion1 =  "^[,][0-9]{0,4}$";
                if (Regex.IsMatch(tbCalificacion.Text.Trim(), expresion1))
                {
                    MessageBox.Show("La nota tiene un valor invalido");
                    tbCalificacion.Text = nota_Original.Nota.ToString().Replace('.', ',');
                }
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (tbCurso.Text == "Sin Seleccionar")
            {
                MessageBox.Show("Seleccione un Curso");
            }
            else
            {
                try
                {
                    if (Alumno_nuevo != null)
                    {
                        if (Alumno_nuevo.Id != null)
                        {
                            nota_Original.IdAlumno = Alumno_nuevo.Id;
                        }
                    }
                    if (Curso_Nuevo != null)
                    {
                        if (Curso_Nuevo.Id != null)
                        {
                            nota_Original.IdCurso = Curso_Nuevo.Id;
                        }
                    }
                    if(tbCalificacion.Text != nota_Original.Nota.ToString().Replace('.',','))
                    {
                        nota_Original.Nota = Convert.ToDouble( tbCalificacion.Text.Replace(',', '.'));
                    }
                    if (chbEstado.Checked)
                    {
                        nota_Original.Estado = '1';
                    }
                    else
                    {
                        nota_Original.Estado = '0';
                    }
                    clsNota Nota_nuevo = new clsNota();
                    Nota_nuevo.Id = nota_Original.Id;
                    Nota_nuevo.Nota = nota_Original.Nota;
                    Nota_nuevo.Estado = nota_Original.Estado;
                    Nota_nuevo.Fecha = nota_Original.Fecha;
                    nota_Consultador.Actualizar(nota_Original);
                    MessageBox.Show("Curso modificado exitosamente", "Exito!");
                    this.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error" + a.Message);
                }

            }
        }
    }
}
