 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
namespace Clases
{
    public class clsCuotaFormateada : IEntidad
    {
        int idCuota = -1;
        public int Id
        {
            get { return idCuota; }
            set { idCuota = value; }
        }

        string idAlumno;

        public string IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        string idCurso;

        public string IdCurso
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

        double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}
