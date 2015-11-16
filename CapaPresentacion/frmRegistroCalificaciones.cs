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
        private enum TipoBuscarNota{Nombre,Apellido,Curso,Fecha};

        private void frmRegistroCalificaciones_Load(object sender, EventArgs e)
        {
            Curso = new clsCurso();
            Nota = new clsNotaFormateada();
            Nota_consultador = new clsRepositorioNota();
            this.ColumnasNotas();
            this.ActualizarGrillaNotas(iniciador);
            rdNombre.Checked = true;
        }
        private void ActualizarGrillaNotas(inicio cambio)
        {
            
            if (cambio == inicio.Administrador)
            {
                dgvEtapaUno.Rows.Clear();
                try
                {
                    List<IEntidad> LE = Nota_consultador.Lista_Formateada();
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
        private void label1_Click(object sender, EventArgs e)
        {
            this.ActualizarGrillaNotas(iniciador);
        }
        private void texto_buscar()
        {
            if (rdNombre.Checked)
            {
                tbBuscar.Text = rdNombre.Text;
            }
            if (rdApellido.Checked)
            {
                tbBuscar.Text = rdApellido.Text;
            }
            if (rdCurso.Checked)
            {
                tbBuscar.Text = rdCurso.Text;
            }
            if (rdFecha.Checked)
            {
                tbBuscar.Text = rdFecha.Text;
            }
        }
        private void texto_limpiar()
        {
            if (rdNombre.Checked)
            {
                if (tbBuscar.Text == rdNombre.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdApellido.Checked)
            {
                if (tbBuscar.Text == rdApellido.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdCurso.Checked)
            {
                if (tbBuscar.Text == rdCurso.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }
            if (rdFecha.Checked)
            {
                if (tbBuscar.Text == rdFecha.Text)
                {
                    tbBuscar.Text = string.Empty;
                }
            }

        }
        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.texto_limpiar();
        }
        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.texto_buscar();
        }
        private void chbParamAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlBusquedaAlumnos.Visible)
            {
                pnlBusquedaAlumnos.Visible = false;
            }
            else
            {
                pnlBusquedaAlumnos.Visible = true;
            }
        }
        private void Buscar_Nota(string Tarjet, TipoBuscarNota tipo)
        {
            try
            {
                string busqueda = string.Empty;
                switch (tipo)
                {
                    case TipoBuscarNota.Nombre: busqueda = "NombreAlumno"; break;
                    case TipoBuscarNota.Apellido: busqueda = "ApellidoAlumno"; break;
                    case TipoBuscarNota.Curso: busqueda = "Curso"; break;
                    case TipoBuscarNota.Fecha: busqueda = "Fecha"; break;
                }
                List<DataGridViewRow> encontrados = new List<DataGridViewRow>();
                if (tipo != TipoBuscarNota.Fecha)
                {
                    foreach (DataGridViewRow temp in dgvEtapaUno.Rows)
                    {
                        if (temp.Cells[busqueda].Value.ToString().Trim().Contains(Tarjet.Trim()))
                        {
                            encontrados.Add(temp);
                        }
                    }
                }
                else
                {
                    try
                    {
                        foreach (DataGridViewRow temp in dgvEtapaUno.Rows)
                        {
                            if (DateTime.Compare(Convert.ToDateTime( temp.Cells[busqueda].Value.ToString()),Convert.ToDateTime(Tarjet)) == 0)
                            {
                                encontrados.Add(temp);
                            }
                        }
                    }
                    catch (FormatException a)
                    {
                        MessageBox.Show("La fache ingresada no tiene el formato correcto");
                        this.ActualizarGrillaNotas(iniciador);
                    }
                }

                dgvEtapaUno.Rows.Clear();
                dgvEtapaUno.Rows.AddRange(encontrados.ToArray());
                dgvEtapaUno.ClearSelection();
                Nota = new clsNotaFormateada();
            }
            catch (Exception a)
            {
                throw new Exception("Se produjo el siguiente error: " + a.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdNombre.Checked)
                {
                    this.Buscar_Nota(tbBuscar.Text, TipoBuscarNota.Nombre);
                }
                if (rdApellido.Checked)
                {
                    this.Buscar_Nota(tbBuscar.Text, TipoBuscarNota.Apellido);
                }
                if (rdCurso.Checked)
                {
                    this.Buscar_Nota(tbBuscar.Text, TipoBuscarNota.Curso);
                }
                if (rdFecha.Checked)
                {
                    this.Buscar_Nota(tbBuscar.Text, TipoBuscarNota.Fecha);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
