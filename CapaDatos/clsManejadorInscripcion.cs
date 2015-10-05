using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

namespace CapaDatos
{
    public class clsManejadorInscripcion
    {
        clsDBManager dbman = new clsDBManager();

        public int InsertInscripcion(clsInscripcion entidad)
        {
            int filas;
            try
            {
                string query = "INSERT INTO Asiste VALUES(" + "'" + entidad.IdAdministrador + "','" + entidad.IdCurso + "','" + entidad.IdAlumno + "','" + entidad.Estado + "');";
                filas = dbman.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateInscripcion(clsInscripcion entidad)
        {
            int filas;
            try
            {
                string query = "UPDATE Asiste Set IdAdministrador = '" + entidad.IdAdministrador + "', IdCurso = '" + entidad.IdCurso + "', IdAlumno = '" + entidad.IdAlumno + "', Estado = '" + entidad.Estado + "' WHERE NroInscripcion =" + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int DeleteInscripcion(clsInscripcion entidad)
        {
            int filas;
            try
            {
                string query = "DELETE Asiste WHERE NroInscripcion = " + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public List<clsInscripcion> SelectInscripcion(clsInscripcion entidad)
        {
            bool id = false, idAd = false, idC = false, idAl = false, estado = false;

            string query = "SELECT * FROM Asiste WHERE";
            if (entidad.Id != null)
            {
                query += " NroInscripcion = " + entidad.Id;
                id = true;
            }
            if (entidad.IdAdministrador != null)
            {
                if (id)
                {
                    query += " AND";
                }
                query += " IdAdministrador = " + entidad.IdAdministrador;
                idAd = true;
            }
            if (entidad.IdAlumno != null)
            {
                if (id || idAd)
                {
                    query += " AND";
                }
                query += " IdAlumno = " + entidad.IdAlumno;
                idAl = true;
            }
            if (entidad.Estado != null)
            {
                if (id || idAd || idAl)
                {
                    query += " AND";
                }
                query += " Estado = " + entidad.Estado;
                estado = true;
            }

            query += ";";

            List<clsInscripcion> list = new List<clsInscripcion>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar(query);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsInscripcion a = new clsInscripcion();

                a.Id = Convert.ToInt32(dr["NroInscripcion"]);
                a.IdAdministrador = Convert.ToInt32(dr["IdAdministrador"]);
                a.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                a.IdAlumno = Convert.ToInt32(dr["IdAlumno"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }

        public List<clsInscripcion> ListarInscripciones()
        {
            List<clsInscripcion> list = new List<clsInscripcion>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar("SELECT * FROM Asiste;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsInscripcion a = new clsInscripcion();

                a.Id = Convert.ToInt32(dr["NroInscripcion"]);
                a.IdAdministrador = Convert.ToInt32(dr["IdAdministrador"]);
                a.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                a.IdAlumno = Convert.ToInt32(dr["IdAlumno"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }
    }
}
