using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsAlumno : IEntidad
    {
        int idAlumno;

        public int Id
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        int dni;

        public int Dni
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

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
