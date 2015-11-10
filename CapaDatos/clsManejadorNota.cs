using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsManejadorNota
    {
        clsDBManager dbManager = new clsDBManager();

        public int InsertarNota(clsNota entidad)
        {
            int filas;

            //string query = "insert Nota values('" + entidad.IdAlumno + "','" + entidad.IdCurso + "','" + entidad.Nota + "','" + entidad.Fecha + "','" + entidad.Estado + "');";

            try
            {
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@idAlumno", entidad.IdAlumno);
                param[1] = new SqlParameter("@idCurso", entidad.IdCurso);
                param[2] = new SqlParameter("@nota", entidad.Nota);
                param[3] = new SqlParameter("@fecha", entidad.Fecha);
                param[4] = new SqlParameter("@estado", entidad.Estado);

                filas = dbManager.Ejecutar("insertarNota", param, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateNota(clsNota entidad)
        {
            int filas;

            string query = "update Dicta set Nota = '" + entidad.Nota + "', Fecha = '" + String.Format("{0,s}", entidad.Fecha) + "', Estado = '" + entidad.Estado + "' where IdAlumno = " + entidad.IdAlumno + " and IdCurso = " + entidad.IdCurso + ";";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.ACTUALIZAR);

                string consulta = "SELECT COUNT(*) as Cantidad FROM Nota WHERE IdCurso = " + entidad.IdCurso + " AND IdAlumno = " + entidad.IdAlumno + ";";
                DataTable dt = dbManager.Consultar(consulta);
                int alumnos = Convert.ToInt32(dt.Rows[0]["Cantidad"]);
                if (alumnos > 1)
                {
                    throw new Exception("Esta nota ya fue cargada, acceda al menu de modificacion para cambiarla");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int DeleteNota(clsNota entidad)
        {
            int filas = 0;

            string query = "delete Dicta where IdAlumno = '" + entidad.IdAlumno + "', IdCurso = '" + entidad.IdCurso + "';";

            return filas;
        }

        public List<clsNota> SelectNota(clsNota entidad)
        {
            List<clsNota> list = new List<clsNota>();

            bool idnota = false, alumno = false, curso = false, nota = false, fecha = false;

            string query = "select * from Nota where";

            if (entidad.Id != -1)
            {
                query += " IdNota = '" + entidad.Id + "'";
                idnota = true;
            }
            if (entidad.IdAlumno != -1)
            {
                if (idnota)
                {
                    query += " and";
                }

                query += " IdAlumno = '" + entidad.IdAlumno + "'";
                alumno = true;
            }
            if (entidad.IdCurso != -1)
            {
                if (idnota | alumno)
                {
                    query += " and";
                }
                query += " IdCurso = '" + entidad.IdCurso + "'";
                curso = true;
            }
            if (entidad.Nota != -1)
            {
                if (idnota | alumno | curso)
                {
                    query += " and";
                }
                query += " Nota = '" + entidad.Nota + "'";
                nota = true;
            }
            if (entidad.Fecha != null)
            {
                if (idnota | alumno | curso | nota)
                {
                    query += " and";
                }
                query += " Fecha = '" + entidad.Fecha + "'";
                fecha = true;
            }
            if (entidad.Estado != null)
            {
                if (idnota | alumno | curso | nota | fecha)
                {
                    query += " and";
                }
                query += " Estado = '" + entidad.Estado + "'";
            }

            query += ";";

            DataTable dt;
            try
            {
                dt = dbManager.Consultar(query);
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsNota n = new clsNota();

                n.Id = Convert.ToInt32(item["IdNota"]);
                n.IdAlumno = Convert.ToInt32(item["IdAlumno"]);
                n.IdCurso = Convert.ToInt32(item["IdCurso"]);
                n.Nota = Convert.ToInt32(item["Nota"]);
                n.Fecha = Convert.ToDateTime(item["Fecha"]);
                n.Estado = Convert.ToInt32(item["Estado"]);

                list.Add(n);
            }

            return list;
        }

        public List<clsNota> ListarNota()
        {
            List<clsNota> res = new List<clsNota>();

            DataTable dt;

            try
            {
                dt = dbManager.Consultar("select * from Nota;");
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsNota p = new clsNota();

                p.Id = Convert.ToInt32(item["IdNota"]);
                p.IdAlumno = Convert.ToInt32(item["IdAlumno"]);
                p.IdCurso = Convert.ToInt32(item["IdCurso"]);
                p.Nota = Convert.ToInt32(item["Nota"]);
                p.Fecha = Convert.ToDateTime(item["Fecha"]);
                p.Estado = Convert.ToInt32(item["Estado"]);

                res.Add(p);
            }

            return res;
        }
    }
}
