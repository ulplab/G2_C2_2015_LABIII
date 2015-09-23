using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class clsAsiste
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

        int nroInscripcion;

        public int NroInscripcion
        {
            get { return nroInscripcion; }
            set { nroInscripcion = value; }
        }

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
