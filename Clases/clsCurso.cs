using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsCurso : IEntidad
    {
        int idCurso;

        public int Id
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}

