using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsAdministrador : IEntidad
    {
        int idAdministrador;

        public int Id
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }

        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }



        string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
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

        int dni;

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

        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
