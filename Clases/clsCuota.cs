using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class clsCuota
    {
        int idCuota = -1;

        public int Id
        {
            get { return idCuota; }
            set { idCuota = value; }
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

        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
