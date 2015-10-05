using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsInscripcion : IEntidad
    {

        int idAdministrador;

        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }

        int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        int idAlumno;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
