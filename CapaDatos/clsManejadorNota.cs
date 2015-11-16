using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

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
                param[2] = new SqlParameter("@nota", String.Format(CultureInfo.InvariantCulture, "{0:00.00}", entidad.Nota));
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

            string query = "update Nota set Nota = '" + entidad.Nota + "', Fecha = '" + entidad.Fecha.Date.ToString() + "', Estado = '" + entidad.Estado + "' where IdAlumno = '" + entidad.IdAlumno + "' and IdCurso = '" + entidad.IdCurso + "';";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.ACTUALIZAR);

                string consulta = "SELECT COUNT(*) as Cantidad FROM Nota WHERE IdCurso = '" + entidad.IdCurso + "' AND IdAlumno = '" + entidad.IdAlumno + "';";
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
            DateTime nuevo = new DateTime(0001,01,01,0,00,00);
            if (DateTime.Compare(entidad.Fecha,nuevo) != 0)
            {
                if (idnota | alumno | curso | nota)
                {
                    query += " and";
                }
                query += " Fecha = '" + entidad.Fecha + "'";
                fecha = true;
            }
            if (entidad.Estado != -1)
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

        public List<clsNotaFormateada> Notas_por_Alumno(clsAlumno Alumno)
        {
            List<clsNotaFormateada> res = new List<clsNotaFormateada>();

            DataTable dt;

            try
            {
                dt = dbManager.Consultar(
                    "select resultado.IdNota,Alumnos.Nombre,Alumnos.Apellido,Cursos.Nombre as \"Curso\", resultado.Nota, resultado.Fecha,resultado.Estado " 
                    + "from Alumnos, Cursos,(select * from Nota where IdAlumno = '" +Alumno.Id.ToString() +"') as \"resultado\" " + 
                    "where Alumnos.IdAlumno = resultado.IdAlumno and Cursos.IdCurso = resultado.IdCurso"+
                    " and"+
                    " resultado.Estado = '1';");
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsNotaFormateada p = new clsNotaFormateada();

                p.Id = Convert.ToInt32(item["IdNota"]);
                p.Nombre_Alumno = Convert.ToString(item["Nombre"]);
                p.Apellido = Convert.ToString(item["Apellido"]);
                p.Nombre_Curso = Convert.ToString(item["Curso"]);
                p.Nota = Convert.ToInt32(item["Nota"]);
                p.Fecha = Convert.ToDateTime(item["Fecha"]);
                p.Estado = Convert.ToInt32(item["Estado"]);

                res.Add(p);
            }

            return res;
        }

        public List<clsNotaFormateada> Notas_por_Profesor(clsProfesor Profe)
        {
            List<clsNotaFormateada> res = new List<clsNotaFormateada>();

            DataTable dt;

            try
            {
                dt = dbManager.Consultar
                    (
                        "select resultado.IdNota,Alumnos.Nombre, Alumnos.Apellido,Cursos.Nombre as \"Curso\",resultado.Nota,resultado.Fecha,resultado.Estado " +
                        "from " +
                        " Alumnos , " +
                        "(select * from Nota where IdCurso In ( select IdCurso from Dicta where IdProfesor = '" + Profe.Id.ToString() + "') )as \"resultado\" ,Cursos " +
                        "where Alumnos.IdAlumno = resultado.IdAlumno " +
                        "and Cursos.IdCurso = resultado.IdCurso "+
                        "and resultado.Estado = 1; "
                    );
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsNotaFormateada p = new clsNotaFormateada();

                p.Id = Convert.ToInt32(item["IdNota"]);
                p.Nombre_Alumno = Convert.ToString(item["Nombre"]);
                p.Apellido = Convert.ToString(item["Apellido"]);
                p.Nombre_Curso = Convert.ToString(item["Curso"]);
                p.Nota = Convert.ToInt32(item["Nota"]);
                p.Fecha = Convert.ToDateTime(item["Fecha"]);
                p.Estado = Convert.ToInt32(item["Estado"]);

                res.Add(p);
            }

            return res;
        }
    }
}
