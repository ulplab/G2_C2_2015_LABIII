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
    public partial class frmRegistroCalificaciones : frmPrincipal
    {

        public frmRegistroCalificaciones(clsAdministrador Administrador,clsAlumno Alumno,clsProfesor Profesor)
        {
            InitializeComponent();
            if (Administrador != null)
            {
                this.Administrador = Administrador;
                iniciador = inicio.Administrador;
            }
            else
            {
                if (Alumno != null)
                {
                    this.Alumno = Alumno;
                    iniciador = inicio.Alumno;
                }
                else
                {
                    this.Profesor = Profesor;
                    this.iniciador = inicio.Profesor;
                }
            }
        }
        private enum inicio { Administrador,Alumno,Profesor}
        private inicio iniciador;
        clsAdministrador Administrador;
        clsProfesor Profesor;
        clsAlumno Alumno;
        clsCurso Curso;
        clsNotaFormateada Nota;
        clsRepositorioNota Nota_consultador;

        private void frmRegistroCalificaciones_Load(object sender, EventArgs e)
        {
            Curso = new clsCurso();
            Nota = new clsNotaFormateada();
            Nota_consultador = new clsRepositorioNota();
            this.ActualizarGrillaNotas(iniciador);
        }
        private void ActualizarGrillaNotas(inicio cambio)
        {
            if (cambio == inicio.Administrador)
            {
                dgvEtapaUno.Rows.Clear();
                this.ColumnasNotas();
                try
                {
                    List<IEntidad> LE = Nota_consultador.Lista();
                    foreach (clsNotaFormateada ECurso in LE)
                    {
                        if (ECurso.Estado == 1)
                        {
                            dgvEtapaUno.Rows.Add(ECurso.Id, ECurso.Nombre_Alumno, ECurso.Apellido, ECurso.Nombre_Curso, ECurso.Nota, ECurso.Fecha);
                        }
                    }
                    dgvEtapaUno.ClearSelection();
                    Nota = new clsNotaFormateada();
                    Nota.Id = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (cambio == inicio.Alumno)
                {
                    dgvEtapaUno.Rows.Clear();
                    this.ColumnasNotas();
                    try
                    {
                        List<IEntidad> LE = Nota_consultador.Notas_Por_Alumno(Alumno.Id);
                        foreach (clsNotaFormateada ECurso in LE)
                        {
                            if (ECurso.Estado == 1)
                            {
                                dgvEtapaUno.Rows.Add(ECurso.Id, ECurso.Nombre_Alumno, ECurso.Apellido, ECurso.Nombre_Curso, ECurso.Nota, ECurso.Fecha);
                            }
                        }
                        dgvEtapaUno.ClearSelection();
                        Nota = new clsNotaFormateada();
                        Nota.Id = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dgvEtapaUno.Rows.Clear();
                    this.ColumnasNotas();
                    try
                    {
                        List<IEntidad> LE = Nota_consultador.Notas_Por_Profesor(Profesor.Id);
                        foreach (clsNotaFormateada ECurso in LE)
                        {
                            if (ECurso.Estado == 1)
                            {
                                dgvEtapaUno.Rows.Add(ECurso.Id, ECurso.Nombre_Alumno, ECurso.Apellido,ECurso.Nombre_Curso, ECurso.Nota, ECurso.Fecha);
                            }
                        }
                        dgvEtapaUno.ClearSelection();
                        Nota = new clsNotaFormateada();
                        Nota.Id = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void ColumnasNotas()
        {
            dgvEtapaUno.Columns.Add("IdNota", "IdNota");
            dgvEtapaUno.Columns["idNota"].Visible = false;
            dgvEtapaUno.Columns.Add("NombreAlumno", "Nombre");
            dgvEtapaUno.Columns.Add("ApellidoAlumno", "Apellido");
            dgvEtapaUno.Columns.Add("Curso", "Curso");
            dgvEtapaUno.Columns.Add("Nota", "Nota");
            dgvEtapaUno.Columns.Add("Fecha", "Fecha");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}
