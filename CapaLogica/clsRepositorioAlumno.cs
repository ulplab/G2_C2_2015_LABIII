using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class clsRepositorioAlumno : IRepositorio
    {
        IDBManager DBManager = new clsDBManager();
            
        private clsAlumno getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsAlumno)))
                return (clsAlumno)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            DataTable dt = new DataTable();

            try
            {
                entidad = getCast(entidad);
                dt = DBManager.Consultar("SELECT * FROM Alumnos;");

                foreach (DataRow r in dt.Rows)
                {
                    if (Convert.ToInt32(r["Dni"]) == ((clsAlumno)entidad).Dni)
                    {
                        throw new ArgumentException("El Alumno ya existe");
                    }
                }

                DBManager.Ejecutar("INSERT INTO Alumnos VALUES('" + ((clsAlumno)entidad).Dni + "','" + ((clsAlumno)entidad).Nombre + "','" + ((clsAlumno)entidad).Apellido + "','" + ((clsAlumno)entidad).Direccion + "','" + ((clsAlumno)entidad).Telefono + "','" + ((clsAlumno)entidad).Email + "','" +((clsAlumno)entidad).Estado + "');", Tipo.INSERTAR);

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        public void Actualizar(IEntidad entidad)
        {

            try
            {
                entidad = getCast(entidad);
                int filaAfectada;

                filaAfectada = DBManager.Ejecutar("UPDATE Alumnos Set Dni=" + ((clsAlumno)entidad).Dni + ", Nombre='" + ((clsAlumno)entidad).Nombre + "', Apellido='" + ((clsAlumno)entidad).Apellido + "', Direccion='" + ((clsAlumno)entidad).Direccion + "', Telefono='" + ((clsAlumno)entidad).Telefono + "', Email='" + ((clsAlumno)entidad).Email + "', Estado='" + ((clsAlumno)entidad).Estado + "' WHERE IdAlumno =" + entidad.Id + ";", Tipo.ACTUALIZAR);

                if (filaAfectada == 0)
                {
                    throw new ArgumentException("Error al Actualizar");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar(IEntidad entidad)
        {

            try
            {
                entidad = getCast(entidad);
                int filaAfectada;

                filaAfectada = DBManager.Ejecutar("DELETE Alumnos WHERE IdAlumnos = " + entidad.Id + ";", Tipo.ELIMINAR);

                if (filaAfectada == 0)
                {
                    throw new ArgumentException("Error al Eliminar");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {

            DataTable dt = new DataTable();
            clsAlumno Alum = new clsAlumno();
            try
            {

                dt = DBManager.Consultar("SELECT * FROM Alumnos WHERE IdAlumnos =" + id);

                if (dt == null)
                {
                    throw new ArgumentException("Alumno Inexistente");
                }
                else
                {
                    Alum.Id = Convert.ToInt32(dt.Rows[0]["IdAlumno"]);
                    Alum.Dni = Convert.ToInt32(dt.Rows[0]["Dni"]);
                    Alum.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                    Alum.Apellido = Convert.ToString(dt.Rows[0]["Apellido"]);
                    Alum.Direccion = Convert.ToString(dt.Rows[0]["Direccion"]);
                    Alum.Telefono = Convert.ToString(dt.Rows[0]["Telefono"]);
                    Alum.Email = Convert.ToString(dt.Rows[0]["Email"]);
                    Alum.Estado = Convert.ToBoolean(dt.Rows[0]["Estado"]);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return Alum;

        }

        public List<IEntidad> Lista()
        {
            DataTable dt = new DataTable();
            List<IEntidad> AlumL = new List<IEntidad>();

            try
            {
                dt = DBManager.Consultar("SELECT * FROM Alumnos;");

                foreach (DataRow r in dt.Rows)
                {
                    clsAlumno Alum = new clsAlumno();
                    Alum.Id = Convert.ToInt32(r["IdAlumno"]);
                    Alum.Dni = Convert.ToInt32(r["Dni"]);
                    Alum.Nombre = Convert.ToString(r["Nombre"]);
                    Alum.Apellido = Convert.ToString(r["Apellido"]);
                    Alum.Direccion = Convert.ToString(r["Direccion"]);
                    Alum.Telefono = Convert.ToString(r["Telefono"]);
                    Alum.Email = Convert.ToString(r["Email"]);
                    Alum.Estado = Convert.ToBoolean(r["Estado"]);

                    AlumL.Add(Alum);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return AlumL;
        }

        public List<IEntidad> Lista(string filtro)
        {
            DataTable dt = new DataTable();
            List<IEntidad> AlumL = new List<IEntidad>();

            try
            {
                dt = DBManager.Consultar(filtro);

                foreach (DataRow r in dt.Rows)
                {
                    clsAlumno Alum = new clsAlumno();
                    Alum.Id = Convert.ToInt32(r["IdAlumno"]);
                    Alum.Dni = Convert.ToInt32(r["Dni"]);
                    Alum.Nombre = Convert.ToString(r["Nombre"]);
                    Alum.Apellido = Convert.ToString(r["Apellido"]);
                    Alum.Direccion = Convert.ToString(r["Direccion"]);
                    Alum.Telefono = Convert.ToString(r["Telefono"]);
                    Alum.Email = Convert.ToString(r["Email"]);
                    Alum.Estado = Convert.ToBoolean(r["Estado"]);

                    AlumL.Add(Alum);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return AlumL;
        }


    }
}
