using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsNotaFormateada : IEntidad
    {
        int id = -1;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        int idAlumno = -1;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        int idCurso = -1;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        double nota = -1;

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        int estado = -1;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string nombre_Alumno = string.Empty;

        public string Nombre_Alumno
        {
            get { return nombre_Alumno; }
            set { nombre_Alumno = value; }
        }

        private string apellido = string.Empty;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string nombre_Curso = string.Empty;

        public string Nombre_Curso
        {
            get { return nombre_Curso; }
            set { nombre_Curso = value; }
        }
    }
}
