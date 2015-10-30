using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsNota : IEntidad
    {
        int id;

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

        int nota = -1;

        public int Nota
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
    }
}
