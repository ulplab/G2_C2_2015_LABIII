using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsInscripcion : IEntidad
    {
        int nroInscripcion = -1;

        public int NroInscripcion
        {
            get { return nroInscripcion; }
            set { nroInscripcion = value; }
        }

        int idAdministrador = -1;

        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }

        int idCurso = -1;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        int idAlumno = -1;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        int id = -1;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        int estado = -1;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
