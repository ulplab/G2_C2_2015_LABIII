using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsAlumnoFormateado : IEntidad
    {
        int idAlumno = -1;

        public int Id
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        int estado = -1;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        double pagado;

        public double Pagado
        {
            get { return pagado; }
            set { pagado = value; }
        }

        double esperado;

        public double Esperado
        {
            get { return esperado; }
            set { esperado = value; }
        }

        double porcentaje;

        public double Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }

        string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
