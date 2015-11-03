using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsCursoFormateado : IEntidad
    {
        int idCurso = -1;

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

        int estado = -1;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        double recaudado;

        public double Recaudado
        {
            get { return recaudado; }
            set { recaudado = value; }
        }

        double esperado;

        public double Esperado
        {
            get { return esperado; }
            set { esperado = value; }
        }

        double porcentaje_pagado;

        public double Porcentaje_pagado
        {
            get { return porcentaje_pagado; }
            set { porcentaje_pagado = value; }
        }

    }
}
