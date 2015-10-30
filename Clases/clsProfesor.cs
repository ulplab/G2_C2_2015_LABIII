using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsProfesor : IEntidad
    {
        int idProfesor = -1;

        public int Id
        {
            get { return idProfesor; }
            set { idProfesor = value; }
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

        int dni = -1;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        int contraseña = -1;

        public int Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        int estado = -1;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
