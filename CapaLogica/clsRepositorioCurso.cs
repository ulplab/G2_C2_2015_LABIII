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
    public class clsRepositorioCurso : IRepositorio
    {
        IDBManager DBManager = new clsDBManager();

        private clsCurso getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsCurso)))
                return (clsCurso)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            DataTable dt = new DataTable();

            try
            {
                entidad = getCast(entidad);
                dt = DBManager.Consultar("SELECT * FROM Cursos;");

                foreach (DataRow r in dt.Rows)
                {
                    if (Convert.ToString(r["Nombre"]) == ((clsCurso)entidad).Nombre && Convert.ToString(r["Descripcion"]) == ((clsCurso)entidad).Descripcion)
                    {
                        throw new ArgumentException("El Curso ya existe");
                    }
                }

                DBManager.Ejecutar("INSERT INTO Cursos VALUES('" + ((clsCurso)entidad).Nombre + "','" + String.Format("{0:s}",((clsCurso)entidad).FechaInicio) + "','" + String.Format("{0:s}", ((clsCurso)entidad).FechaFin) + "','" + ((clsCurso)entidad).Descripcion + "','" + ((clsCurso)entidad).Estado + "');", Tipo.INSERTAR);

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

                filaAfectada = DBManager.Ejecutar("UPDATE Cursos Set Nombre='" + ((clsCurso)entidad).Nombre + "', FechaInicio='" + String.Format("{0:s}", ((clsCurso)entidad).FechaInicio) + "', FechaFin='" + String.Format("{0:s}", ((clsCurso)entidad).FechaFin) + "', Descripcion='" + ((clsCurso)entidad).Descripcion + "', Estado='" + ((clsCurso)entidad).Estado + "' WHERE IdCurso =" + entidad.Id + ";", Tipo.ACTUALIZAR);

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

                filaAfectada = DBManager.Ejecutar("DELETE Cursos WHERE IdCurso = " + entidad.Id + ";", Tipo.ELIMINAR);

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
            clsCurso C = new clsCurso();
            try
            {

                dt = DBManager.Consultar("SELECT * FROM Cursos WHERE IdCurso=" + id);

                if (dt == null)
                {
                    throw new ArgumentException("Curso Inexistente");
                }
                else
                {
                    C.Id = Convert.ToInt32(dt.Rows[0]["IdCurso"]);
                    C.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                    C.FechaInicio = Convert.ToDateTime(dt.Rows[0]["FechaInicio"]);
                    C.FechaFin = Convert.ToDateTime(dt.Rows[0]["FechaFin"]);
                    C.Descripcion = Convert.ToString(dt.Rows[0]["Descripcion"]);
                    C.Estado = Convert.ToBoolean(dt.Rows[0]["Estado"]);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return C;

        }

        public List<IEntidad> Lista()
        {
            DataTable dt = new DataTable();
            List<IEntidad> CL = new List<IEntidad>();

            try
            {
                dt = DBManager.Consultar("SELECT * FROM Cursos;");

                foreach (DataRow r in dt.Rows)
                {
                    clsCurso C = new clsCurso();
                    C.Id = Convert.ToInt32(r["IdCurso"]);
                    C.Nombre = Convert.ToString(r["Nombre"]);
                    C.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    C.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    C.Descripcion = Convert.ToString(r["Descripcion"]);
                    C.Estado = Convert.ToBoolean(r["Estado"]);

                    CL.Add(C);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return CL;
        }

        public List<IEntidad> Lista(string filtro)
        {
            DataTable dt = new DataTable();
            List<IEntidad> CL = new List<IEntidad>();

            try
            {
                dt = DBManager.Consultar(filtro);

                foreach (DataRow r in dt.Rows)
                {
                    clsCurso C = new clsCurso();
                    C.Id = Convert.ToInt32(r["IdCurso"]);
                    C.Nombre = Convert.ToString(r["Nombre"]);
                    C.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    C.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    C.Descripcion = Convert.ToString(r["Descripcion"]);
                    C.Estado = Convert.ToBoolean(r["Estado"]);

                    CL.Add(C);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return CL;
        }



    }
}
